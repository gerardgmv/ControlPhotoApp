using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Management;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;

namespace ControlPhotoApp.Forms
{
    public partial class FrmPrint : Form
    {
        private string _image { get; set; }

        Singleton _singleton;
        StoreController _controller;
        PrintServer _printserver;
        PrintQueue _queue;
        PrintDocument pd;

        bool imprimiendo = false;
        bool printsInQueue = false;
        bool Canceling = false;

        public FrmPrint(string img)
        {
            _singleton = Singleton.GetInstance();
            _controller = new StoreController();
            _image = img;
            InitializeComponent();

        }

        private void FrmPrint_Load(object sender, EventArgs e)
        {
            try
            {
                picImage.Image = Image.FromFile(_image);
                lblNameImage.Text = Path.GetFileName(_image);
                lblStatus.Text = "";

            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Ocurrio un error al leer el archivo \n {ex.Message}";
                btnPhone.Enabled = false;
            }

            try
            {
                _printserver = new PrintServer();
                _queue = new PrintQueue(_printserver, _singleton._Printer, PrintSystemDesiredAccess.AdministratePrinter);

                if (_queue.NumberOfJobs > 0)
                {
                    btnPhone.Enabled = false;
                    printsInQueue = true;
                    Canceling = true;

                    _queue.Refresh();
                    _queue.Purge();
                }
                timerCheck.Enabled = true;
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"NO SE PUDO INICIAR EL SERVICIO DE IMPRESION \n {ex.Message}";
                btnPhone.Enabled = false;
            }
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            pd = new PrintDocument();
            pd.PrinterSettings.PrinterName = _singleton._Printer;
            pd.DocumentName = "PRINT_PHOTO";
            pd.PrintPage += Pd_PrintPage;
            pd.Print();
            imprimiendo = true;
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image img = Image.FromFile(this._image);
            Point loc = new Point(0, 0);
            e.Graphics.DrawImage(img, loc);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_queue != null)
            {
                _queue.Refresh();
                _queue.Purge();
                imprimiendo = false;
                Canceling = true;
            }
        }

        private void checkStatusPrint()
        {
            try
            {
                if (_queue != null)
                {
                    _queue.Refresh();
                    if (_queue.QueueStatus == PrintQueueStatus.Busy)
                        lblStatus.Text = $"IMPRESORA OCUPADA";
                    if (_queue.QueueStatus == PrintQueueStatus.DoorOpen)
                        lblStatus.Text = "IMPRESORA ABIERTA";
                    if (_queue.QueueStatus == PrintQueueStatus.Error)
                        lblStatus.Text = "ERROR EN LA IMPRESION";
                    if (_queue.QueueStatus == PrintQueueStatus.Initializing)
                        lblStatus.Text = "INICIALIZANDO LA IMPRESORA";
                    if (_queue.QueueStatus == PrintQueueStatus.IOActive)
                        lblStatus.Text = "IOACTIVE";
                    if (_queue.QueueStatus == PrintQueueStatus.ManualFeed || _queue.QueueStatus == PrintQueueStatus.UserIntervention)
                        lblStatus.Text = "ESPERANDO INTERVENCION DEL USUARIO";
                    if (_queue.QueueStatus == PrintQueueStatus.NotAvailable)
                        lblStatus.Text = "ESTADO DE LA IMPRESORA NO DISPONIBLE";
                    if (_queue.QueueStatus == PrintQueueStatus.NoToner)
                        lblStatus.Text = "SIN TONER O TINTA";
                    if (_queue.QueueStatus == PrintQueueStatus.Offline)
                        lblStatus.Text = "IMPRESORA DESCONECTADA";
                    if (_queue.QueueStatus == PrintQueueStatus.OutOfMemory)
                        lblStatus.Text = "IMPRESORA SIN ESPACION EN MEMORIA";
                    if (_queue.QueueStatus == PrintQueueStatus.OutputBinFull)
                        lblStatus.Text = "OUT PUT BIN FULL";
                    if (_queue.QueueStatus == PrintQueueStatus.PagePunt)
                        lblStatus.Text = "BANDEJA NO DISPONIBLE";
                    if (_queue.QueueStatus == PrintQueueStatus.Paused)
                        lblStatus.Text = "IMPRESION PAUSADA";
                    if (_queue.QueueStatus == PrintQueueStatus.PendingDeletion)
                        lblStatus.Text = "BORRANDO COLA DE IMPRESION";
                    if (_queue.QueueStatus == PrintQueueStatus.PowerSave)
                        lblStatus.Text = "ENCENDIDO EN MODO SEGURO";
                    if (_queue.QueueStatus == PrintQueueStatus.Printing)
                        lblStatus.Text = "IMPRIMIENDO";
                    if (_queue.QueueStatus == PrintQueueStatus.Processing)
                        lblStatus.Text = "PROCESANDO IMPRESION";
                    if (_queue.QueueStatus == PrintQueueStatus.ServerUnknown)
                        lblStatus.Text = "ERROR EN LA IMPRESORA";
                    if (_queue.QueueStatus == PrintQueueStatus.TonerLow)
                        lblStatus.Text = "TONER O TINTA EN NIVEL BAJO";
                    if (_queue.QueueStatus == PrintQueueStatus.Waiting)
                        lblStatus.Text = "IMPRESORA ESPERANDO";
                    if (_queue.QueueStatus == PrintQueueStatus.WarmingUp)
                        lblStatus.Text = "CALENTANDO IMPRESORA";
                    if (_queue.QueueStatus == PrintQueueStatus.PaperOut)
                        lblStatus.Text = "SIN PAPEL";
                    if (_queue.QueueStatus == PrintQueueStatus.PaperJam || _queue.QueueStatus == PrintQueueStatus.PaperProblem)
                        lblStatus.Text = "PAPEL ATORADO";

                    GetJobs();

                    if (_queue.NumberOfJobs == 0)
                    {
                        if (imprimiendo)
                        {
                            lblStatus.Text = "IMPRESION TERMINADA";
                            imprimiendo = false;
                            //save Venta
                            try { 
                                _controller.SaveSale("IMPRESIONES", _singleton._PricePrint);
                            }catch (Exception ex)
                            {
                                MessageBox.Show("Ocurrio un error al guardar en la base de datos, notifica de inmediato el error", "IMPRESIONES");
                                lblStatus.Text = ex.Message;
                            }
                        }

                        if (printsInQueue || Canceling)
                        {
                            lblStatus.Text = "COLA DE IMPRESION CANCELADA";
                            btnPhone.Enabled = true;
                            imprimiendo = false;
                            printsInQueue = false;
                            Canceling = false;
                        }
                        listQueue.Items.Clear();
                    }
                }
                else
                {
                    lblStatus.Text = "NO SE PUDO INICIAR EL SERVICIO DE IMPRESION\nDesbloquee el equipo y reinicie la cola de impresion";
                    imprimiendo = false;
                    Canceling = false;
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"ERROR EN LA COLA DE IMPRESION\n{ex.Message}";
                timerCheck.Enabled = false;
                imprimiendo = false;
            }
        }

        private void GetJobs ()
        {
            try
            {
                PrintJobInfoCollection Jobs = _queue.GetPrintJobInfoCollection();
                listQueue.Items.Clear();
                foreach (PrintSystemJobInfo job in Jobs)
                {
                    listQueue.Items.Add($"JOB: {job.Name}");
                    listQueue.Items.Add($"STATUS: {job.JobStatus}");
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"NO SE PUDO LEER LA COLA DE IMPRESION {ex.Message}";
                timerCheck.Enabled = false;
                btnPhone.Enabled = false;
                btnCancel.Enabled = false;
                imprimiendo = false;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (imprimiendo)
            {
                MessageBox.Show("Hay una impresion pendiente", "Impresiones");
                return;
            }
            this.Close();
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            checkStatusPrint();
        }
    }
}
