using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manina.Windows.Forms;
using FontAwesome.Sharp;
using Controllers;
using System.Drawing.Printing;
using System.Printing;
using System.Threading;

namespace ControlPhotoApp.Forms
{
    public partial class FrmStore : Form
    {
        //private ImageListView ListImages { get; set; }
        private ImageListView ListImagesSelected { get; set; }
        

        private string CurrentDirectory { get; set; }
        private Task TaskLoadImages { get; set; }
        private string[] NameFiles { get; set; }

        private ImageListViewColor paleteColor { get; }


        private IconButton CurrentBtnView;

        private Singleton _singleton;
        private StoreController _controller;
        private string sort = "Desc";

        private string ImgToPrint;

        private FrmTurno frmTurno;

        private struct RGBColors 
        {
            public static Color background = Color.FromArgb(7,18,36);
            public static Color backgroundSecundary = Color.FromArgb(2,8,19);
            public static Color ColorFonts = Color.Gainsboro;
            public static Color ColorSelected = Color.Aqua;
        };


        public FrmStore()
        {
            _singleton = Singleton.GetInstance();
            _singleton.OpenTurno += OnOpenTurno;

            _controller = new StoreController();

            InitializeComponent();

            paleteColor = new ImageListViewColor
            {
                BackColor = RGBColors.background,
                ForeColor = RGBColors.ColorFonts,
                PaneBackColor = RGBColors.background,
                ControlBackColor = RGBColors.background,
                PaneLabelColor = RGBColors.ColorFonts,
                PaneSeparatorColor = RGBColors.backgroundSecundary,
                SelectedBorderColor = RGBColors.ColorSelected,
                SelectedForeColor = RGBColors.ColorFonts,
                CellForeColor = RGBColors.ColorFonts,
                AlternateBackColor = RGBColors.ColorFonts,
                AlternateCellForeColor = RGBColors.background,
                ColumnHeaderBackColor1 = RGBColors.backgroundSecundary,
                ColumnHeaderBackColor2 = RGBColors.backgroundSecundary,
                ColumnHeaderForeColor = RGBColors.ColorFonts,
            };

            this.ListImagesSelected = new ImageListView
            {
                BorderStyle = BorderStyle.None,
                CacheMode = CacheMode.OnDemand,
                Colors = paleteColor,
                Dock = DockStyle.Fill,
                CacheLimit = "100MB",
                SortColumn = 0,
                SortOrder = Manina.Windows.Forms.SortOrder.AscendingNatural,
                View = Manina.Windows.Forms.View.Thumbnails,
                MultiSelect = true,
            };

            sort = "Desc";

            this.ListImagesSelected.Columns.Add(ColumnType.Name, "Nombre", 300);
            this.ListImagesSelected.Columns.Add(ColumnType.DateCreated, "Creado", 200);

            panelElements.Controls.Add(this.ListImagesSelected);

            this.ListImages.Colors = paleteColor;
            this.ListImages.SortColumn = 0;
            this.ListImages.SortOrder = Manina.Windows.Forms.SortOrder.DescendingNatural;
            this.ListImages.Columns.Add(ColumnType.Name, "Archivo", 300);
            this.ListImages.Columns.Add(ColumnType.DateCreated, "Fecha", 200);
            this.ListImages.ItemDoubleClick += ListImages_ItemDoubleClick;
            this.ListImages.CacheError += ListImages_CacheError;


            lblLimite.Text = $"{_singleton._minCopies} de {_singleton._maxCopies} Images";

            if (!Directory.Exists(_singleton._dirCachePersistent))
                Directory.CreateDirectory(_singleton._dirCachePersistent);
                
            ListImages.CacheMode = CacheMode.OnDemand;
            ListImages.CacheLimit = "1024MB";

            ListImages.PersistentCacheDirectory = _singleton._dirCachePersistent;
            ListImages.PersistentCacheSize = _singleton._sizeCachePersistent;            


        }

        private void ListImages_CacheError(object sender, CacheErrorEventArgs e)
        {
            lblTotalGaleria.Text = "Error en la cache";
        }

        private void ListImages_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            ImageListViewItem item = new ImageListViewItem(e.Item.FileName);

            int count = this.ListImagesSelected.Items.Count;

            bool isContains = this.ListImagesSelected.Items.Contains(item);

            if (isContains)
            {
                MessageBox.Show("El Archivo ya se encuentra Agregado a la lista para copiar");
                return;
            }

            if (count == _singleton._maxCopies)
            {
                MessageBox.Show("Excedio el Máximo de imagenes permitidas para copiar o subir a la nube");
                return;
            }
            count++;
            this.ListImagesSelected.Items.Add(item);
            this.ListImagesSelected.Sort();
            this.lblTotal.Text = $"{count} Imagenes";
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            ActivateBtnView(sender);
            if (this.ListImages.View != Manina.Windows.Forms.View.Pane)
                this.ListImages.View = Manina.Windows.Forms.View.Pane;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (ListImages.Items.Count > 0)
            {
                if (sort == "Desc")
                {
                    ListImages.SortOrder = Manina.Windows.Forms.SortOrder.AscendingNatural;
                    ListImages.Sort();
                    btnSort.IconChar = IconChar.SortNumericDownAlt;
                    sort = "Asc";
                }
                else
                {
                    
                        ListImages.SortOrder = Manina.Windows.Forms.SortOrder.DescendingNatural;
                        ListImages.Sort();
                        btnSort.IconChar = IconChar.SortNumericDown;
                        sort = "Desc";
                    
                }

            }
        }

        private void btnThumbnail_Click(object sender, EventArgs e)
        {
            ActivateBtnView(sender);
            if (this.ListImages.View != Manina.Windows.Forms.View.Thumbnails)
               this.ListImages.View = Manina.Windows.Forms.View.Thumbnails;
        }

        private void btnGalery_Click(object sender, EventArgs e)
        {
            ActivateBtnView(sender);
            if (this.ListImages.View != Manina.Windows.Forms.View.Gallery)
                this.ListImages.View = Manina.Windows.Forms.View.Gallery;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ActivateBtnView(sender);
            if (this.ListImages.View != Manina.Windows.Forms.View.Details)
                this.ListImages.View = Manina.Windows.Forms.View.Details;
        }



        private void ActivateBtnView(object sender) 
        {
            if (sender != null) 
            {
                if ((IconButton)sender != CurrentBtnView) 
                {
                    DeactivateBtnView();
                    CurrentBtnView = (IconButton)sender;
                    CurrentBtnView.IconColor = Color.Aqua;
                    CurrentBtnView.FlatAppearance.BorderColor = Color.Aqua;
                }                
            }
        }

        private void DeactivateBtnView() 
        {
            if (CurrentBtnView != null) 
            {
                CurrentBtnView.IconColor = Color.MintCream;
                CurrentBtnView.FlatAppearance.BorderColor = Color.MintCream;
            }
        
        }



        private void FrmStore_Load(object sender, EventArgs e)
        {
            lblCopiando.Visible = false;
            barCopiando.Visible = false;


            if (_singleton.TurnoId != 0)
            {
                btnInitTurno.Enabled = false;
                btnPrint.Enabled = true;
                btnSearch.Enabled = true;
                MessageBox.Show("Se Encontro un Turno abierto y se continuara con este\nSi deseas cerrar el turno ve a la opcion corte de caja\n e inicia de nuevo sesion", "Ventas");
            }
            else
            {
                btnPrint.Enabled = false;
                btnSearch.Enabled = false;
                btnInitTurno.Enabled = true;
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            _folderBrower.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            DialogResult rs = _folderBrower.ShowDialog();
            if (rs == DialogResult.OK)
            {
                //if (this.CurrentDirectory != FolderBrowser.SelectedPath)
                //{
                this.PanelContainer.Controls.Remove(this.ListImages);
                this.CurrentDirectory = _folderBrower.SelectedPath;
                this.imgWatcher.Path = this.CurrentDirectory;
                this.imgWatcher.SynchronizingObject = this.ListImages;

                this.ListImages.Visible = false;
                this.NameFiles = Directory.GetFiles(this.CurrentDirectory, "*.jpg");
                this.lblTotalGaleria.Text = $"Total Imagenes: {this.NameFiles.Length}";

                if (this.NameFiles.Length > 0)
                {
                    ListImages.View = Manina.Windows.Forms.View.Pane;
                    ListImages.Items.Clear();
                    ListImages.Items.AddRange(this.NameFiles);
                    ListImages.Sort();
                }
                else
                {
                    ListImages.Items.Clear();

                }
                this.ListImages.Visible = true;
                ActivateBtnView(btnPanel);
                //}
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (this.ListImages.SelectedItems.Count != 1)
            {
                MessageBox.Show("Seleccione solo un Archivo de la lista para imprimir");
                this.ListImages.ClearSelection();
                return;
            }

            ImgToPrint = this.ListImages.SelectedItems[0].FileName;
            FrmPrint frm = new FrmPrint(ImgToPrint);
            frm.ShowDialog();
        }


        private void btnPhone_Click(object sender, EventArgs e)
        {

            if (this.ListImagesSelected.Items.Count < _singleton._minCopies || this.ListImagesSelected.Items.Count > _singleton._maxCopies)
            {
                MessageBox.Show($"Debe de seleccionar entre {_singleton._minCopies} y {_singleton._maxCopies} Fotografias");
                return;
            }

            _folderBrower.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            DialogResult rs = _folderBrower.ShowDialog();
            if (rs == DialogResult.OK)
            {
                if (!workerCopiando.IsBusy)
                {
                    lblCopiando.Visible = true;
                    barCopiando.Visible = true;
                    lblCopiando.Text = "Copiando Imagenes ....";
                    barCopiando.Minimum = 1;
                    barCopiando.Maximum = ListImagesSelected.Items.Count + 1;
                    barCopiando.Value = 1;
                    barCopiando.Step = 1;
                    workerCopiando.RunWorkerAsync();
                }
                else
                {
                    workerCopiando.CancelAsync();
                    MessageBox.Show("Intente de Nuevo, para copiar las imagenes..!", "Fotos");
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            workerCopiando.CancelAsync();
        }

        private void workerCopiando_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                _controller.CopyFiles(ListImagesSelected.Items, _folderBrower.SelectedPath);
                int cont = 1;
                bool error = false;
                foreach  (var item in ListImagesSelected.Items)
                {
                    try
                    {
                        _controller.CopyImage(_folderBrower.SelectedPath, item.FileName);
                        workerCopiando.ReportProgress(cont);
                        cont++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}", "Error");
                        error = true;
                        e.Cancel = true;
                        break;
                    }
                }

                if (!error)
                {
                    try
                    {
                        //lblCopiando.Text = "Guardando Venta";
                        _controller.SaveSale("COPIADO", _singleton._PriceCopy);
                        workerCopiando.ReportProgress(cont);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrio un error al Guardar la Venta, Revise el estado de la Base de Datos o Contacte a Soporte Técnico\n{ex.Message}", "Error");
                        //_controller.DeleteFiles(FolderBrowser.SelectedPath + $"\\{_singleton._directoryCopy}\\");
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                MessageBox.Show(ex.Message, "Error al Copiar Archivos");
            }
        }

        private void workerCopiando_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ListImagesSelected.Items.Clear();
            lblCopiando.Visible = false;
            barCopiando.Visible = false;
            lblTotal.Text = "0 Imagenes";
            if (e.Cancelled == true)
                MessageBox.Show("Operacion Cancelada", "Ventas");
            else
                if (e.Error != null)
                     MessageBox.Show("Ocurrio un Error al copiar los archivos", "Ventas");
                else
                    MessageBox.Show("Fotos Copiadas", "Ventas");
                
        }

        private void workerCopiando_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            /*int total = ListImagesSelected.Items.Count + 1;
            if ((total - 1) == e.ProgressPercentage)
                lblCopiando.Text = "Guardando Venta";
            else
                lblCopiando.Text = $"Copiando {e.ProgressPercentage} de {(total - 1)}";*/
            barCopiando.Value = e.ProgressPercentage;
        }


        private void imgWatcher_Created(object sender, FileSystemEventArgs e)
        {
            if (ListImages.InvokeRequired)
            {
                var item = new ImageListViewItem(e.FullPath);
                ListImages.Invoke(new MethodInvoker (
                    delegate {
                        ListImages.Items.Add(item);
                        ListImages.Sort();
                        lblTotalGaleria.Text = $"Total Imagenes: {ListImages.Items.Count}";
                    }));
            }
        }

        private void imgWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            if (ListImages.InvokeRequired)
            {
                ListImages.Invoke(new MethodInvoker (
                    delegate {
                        int i = ListImages.FindString(e.Name);
                        ListImages.Items.RemoveAt(i);
                        lblTotalGaleria.Text = $"Total Imagenes: {ListImages.Items.Count}";
                    }));
            }
        }

        private void imgWatcher_Error(object sender, ErrorEventArgs e)
        {
            MessageBox.Show($"No se pueden cargar las imagenes\n" +
                $"Puede que la computadora esta offline o se cargaron demasiadas Imagenes\n" +
                $"Intente Cargar de nuevo el Directorio\n" +
                $"{e.GetException().Message}", 
                "Imagenes");
            ListImages.Invoke(new MethodInvoker (
                delegate
                {
                    ListImages.Items.Clear();
                    lblTotalGaleria.Text = $"Total Imagenes: 0";
                }));
        }

        private void imgWatcher_Renamed(object sender, RenamedEventArgs e)
        {

            if (ListImages.InvokeRequired)
            {
                ListImages.Invoke(new MethodInvoker(
                    delegate {
                        var newitem = new ImageListViewItem(e.FullPath);
                        int i = ListImages.FindString(e.OldName);
                        ListImages.Items.RemoveAt(i);
                        ListImages.Items.Add(newitem);
                        ListImages.Sort();
                    }));
            }
        }

        private void btnRemoveOne_Click(object sender, EventArgs e)
        {
            if (ListImagesSelected.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una imagen de la Lista a copiar", "Imagenes");
                return;
            }

            foreach (var item in ListImagesSelected.SelectedItems)
            {
                ListImagesSelected.Items.Remove(item);
            }
            if (ListImagesSelected.Items.Count > 0)
                ListImagesSelected.Sort();
            lblTotal.Text = $"{ListImagesSelected.Items.Count} imagenes";
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (ListImagesSelected.Items.Count == 0)
            {
                MessageBox.Show("No se encontraron imagenes para remover", "Imagenes");
                return;
            }
            ListImagesSelected.Items.Clear();
            lblTotal.Text = $"{ListImagesSelected.Items.Count} imagenes";
        }

        private void btnInitTurno_Click(object sender, EventArgs e)
        {
            if (_singleton.TurnoId == 0)
            {
                frmTurno = new FrmTurno();
                frmTurno.ShowDialog();
            }
        }

        private void OnOpenTurno(object sender, EventArgs e)
        {            
            btnSearch.Enabled = true;
            btnPrint.Enabled = true;
        }

        private void fullScreen_Click(object sender, EventArgs e)
        {
            
        }
    }

    


}
