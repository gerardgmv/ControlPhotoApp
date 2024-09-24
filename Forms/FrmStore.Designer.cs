
namespace ControlPhotoApp.Forms
{
    partial class FrmStore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStore));
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTotalGaleria = new System.Windows.Forms.Label();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnList = new FontAwesome.Sharp.IconButton();
            this.btnGalery = new FontAwesome.Sharp.IconButton();
            this.btnThumbnail = new FontAwesome.Sharp.IconButton();
            this.btnSort = new FontAwesome.Sharp.IconButton();
            this.btnPanel = new FontAwesome.Sharp.IconButton();
            this.btnInitTurno = new FontAwesome.Sharp.IconButton();
            this.btnPrint = new FontAwesome.Sharp.IconButton();
            this.lblLimite = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnPhone = new FontAwesome.Sharp.IconButton();
            this._folderBrower = new System.Windows.Forms.FolderBrowserDialog();
            this.ListImages = new Manina.Windows.Forms.ImageListView();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelInnerContainer = new System.Windows.Forms.Panel();
            this.panelCopies = new System.Windows.Forms.Panel();
            this.panelloading = new System.Windows.Forms.Panel();
            this.barCopiando = new System.Windows.Forms.ProgressBar();
            this.lblCopiando = new System.Windows.Forms.Label();
            this.panelElements = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRemoveOne = new FontAwesome.Sharp.IconButton();
            this.btnRemoveAll = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.workerCopiando = new System.ComponentModel.BackgroundWorker();
            this.imgWatcher = new System.IO.FileSystemWatcher();
            this.fullScreen = new FontAwesome.Sharp.IconButton();
            this.panelTop.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.PanelInnerContainer.SuspendLayout();
            this.panelCopies.SuspendLayout();
            this.panelloading.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblTotalGaleria);
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.btnList);
            this.panelTop.Controls.Add(this.btnGalery);
            this.panelTop.Controls.Add(this.btnThumbnail);
            this.panelTop.Controls.Add(this.btnSort);
            this.panelTop.Controls.Add(this.fullScreen);
            this.panelTop.Controls.Add(this.btnPanel);
            this.panelTop.Controls.Add(this.btnInitTurno);
            this.panelTop.Controls.Add(this.btnPrint);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(958, 53);
            this.panelTop.TabIndex = 0;
            // 
            // lblTotalGaleria
            // 
            this.lblTotalGaleria.AutoSize = true;
            this.lblTotalGaleria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalGaleria.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalGaleria.Location = new System.Drawing.Point(399, 20);
            this.lblTotalGaleria.Name = "lblTotalGaleria";
            this.lblTotalGaleria.Size = new System.Drawing.Size(148, 17);
            this.lblTotalGaleria.TabIndex = 2;
            this.lblTotalGaleria.Text = "0 Imagenes en galeria";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 28;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(169, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 32);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Abrir";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnList
            // 
            this.btnList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnList.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnList.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.btnList.IconColor = System.Drawing.Color.MintCream;
            this.btnList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnList.IconSize = 24;
            this.btnList.Location = new System.Drawing.Point(894, 11);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(30, 32);
            this.btnList.TabIndex = 0;
            this.btnList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnGalery
            // 
            this.btnGalery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGalery.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnGalery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGalery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGalery.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGalery.IconChar = FontAwesome.Sharp.IconChar.Images;
            this.btnGalery.IconColor = System.Drawing.Color.MintCream;
            this.btnGalery.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGalery.IconSize = 24;
            this.btnGalery.Location = new System.Drawing.Point(843, 11);
            this.btnGalery.Name = "btnGalery";
            this.btnGalery.Size = new System.Drawing.Size(30, 32);
            this.btnGalery.TabIndex = 0;
            this.btnGalery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGalery.UseVisualStyleBackColor = true;
            this.btnGalery.Click += new System.EventHandler(this.btnGalery_Click);
            // 
            // btnThumbnail
            // 
            this.btnThumbnail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThumbnail.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnThumbnail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThumbnail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThumbnail.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThumbnail.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btnThumbnail.IconColor = System.Drawing.Color.MintCream;
            this.btnThumbnail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThumbnail.IconSize = 24;
            this.btnThumbnail.Location = new System.Drawing.Point(792, 12);
            this.btnThumbnail.Name = "btnThumbnail";
            this.btnThumbnail.Size = new System.Drawing.Size(30, 32);
            this.btnThumbnail.TabIndex = 0;
            this.btnThumbnail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThumbnail.UseVisualStyleBackColor = true;
            this.btnThumbnail.Click += new System.EventHandler(this.btnThumbnail_Click);
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSort.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSort.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSort.IconChar = FontAwesome.Sharp.IconChar.SortNumericDown;
            this.btnSort.IconColor = System.Drawing.Color.LightSeaGreen;
            this.btnSort.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSort.IconSize = 24;
            this.btnSort.Location = new System.Drawing.Point(611, 12);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(30, 32);
            this.btnSort.TabIndex = 0;
            this.btnSort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnPanel
            // 
            this.btnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPanel.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPanel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPanel.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.btnPanel.IconColor = System.Drawing.Color.MintCream;
            this.btnPanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPanel.IconSize = 24;
            this.btnPanel.Location = new System.Drawing.Point(740, 12);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(30, 32);
            this.btnPanel.TabIndex = 0;
            this.btnPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPanel.UseVisualStyleBackColor = true;
            this.btnPanel.Click += new System.EventHandler(this.btnPanel_Click);
            // 
            // btnInitTurno
            // 
            this.btnInitTurno.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnInitTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInitTurno.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInitTurno.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnInitTurno.IconColor = System.Drawing.Color.YellowGreen;
            this.btnInitTurno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInitTurno.IconSize = 28;
            this.btnInitTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInitTurno.Location = new System.Drawing.Point(12, 11);
            this.btnInitTurno.Name = "btnInitTurno";
            this.btnInitTurno.Size = new System.Drawing.Size(129, 32);
            this.btnInitTurno.TabIndex = 0;
            this.btnInitTurno.Text = "Iniciar Turno";
            this.btnInitTurno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInitTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInitTurno.UseVisualStyleBackColor = true;
            this.btnInitTurno.Click += new System.EventHandler(this.btnInitTurno_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPrint.IconColor = System.Drawing.Color.Goldenrod;
            this.btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrint.IconSize = 28;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(254, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 32);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLimite.Location = new System.Drawing.Point(134, 12);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(109, 17);
            this.lblLimite.TabIndex = 2;
            this.lblLimite.Text = "de 3 a 8 images";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Limite Permitido:";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancel.IconColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 28;
            this.btnCancel.Location = new System.Drawing.Point(12, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 32);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPhone
            // 
            this.btnPhone.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPhone.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPhone.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btnPhone.IconColor = System.Drawing.Color.Goldenrod;
            this.btnPhone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPhone.IconSize = 28;
            this.btnPhone.Location = new System.Drawing.Point(14, 65);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(102, 32);
            this.btnPhone.TabIndex = 0;
            this.btnPhone.Text = "Copiar";
            this.btnPhone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // _folderBrower
            // 
            this._folderBrower.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this._folderBrower.ShowNewFolderButton = false;
            // 
            // ListImages
            // 
            this.ListImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListImages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListImages.CacheLimit = "500MB";
            this.ListImages.Colors = new Manina.Windows.Forms.ImageListViewColor(resources.GetString("ListImages.Colors"));
            this.ListImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListImages.ForeColor = System.Drawing.Color.Gainsboro;
            this.ListImages.IntegralScroll = true;
            this.ListImages.Location = new System.Drawing.Point(0, 0);
            this.ListImages.Name = "ListImages";
            this.ListImages.PersistentCacheDirectory = "";
            this.ListImages.PersistentCacheSize = ((long)(0));
            this.ListImages.Size = new System.Drawing.Size(958, 407);
            this.ListImages.SortOrder = Manina.Windows.Forms.SortOrder.DescendingNatural;
            this.ListImages.TabIndex = 0;
            this.ListImages.UseWIC = true;
            this.ListImages.View = Manina.Windows.Forms.View.Pane;
            // 
            // PanelContainer
            // 
            this.PanelContainer.Controls.Add(this.panel3);
            this.PanelContainer.Controls.Add(this.PanelInnerContainer);
            this.PanelContainer.Controls.Add(this.panelCopies);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 53);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(958, 595);
            this.PanelContainer.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(8)))), ((int)(((byte)(19)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 397);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(958, 10);
            this.panel3.TabIndex = 4;
            // 
            // PanelInnerContainer
            // 
            this.PanelInnerContainer.Controls.Add(this.ListImages);
            this.PanelInnerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelInnerContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelInnerContainer.Name = "PanelInnerContainer";
            this.PanelInnerContainer.Size = new System.Drawing.Size(958, 407);
            this.PanelInnerContainer.TabIndex = 3;
            // 
            // panelCopies
            // 
            this.panelCopies.Controls.Add(this.panelloading);
            this.panelCopies.Controls.Add(this.panelElements);
            this.panelCopies.Controls.Add(this.panel1);
            this.panelCopies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCopies.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelCopies.Location = new System.Drawing.Point(0, 407);
            this.panelCopies.Name = "panelCopies";
            this.panelCopies.Size = new System.Drawing.Size(958, 188);
            this.panelCopies.TabIndex = 2;
            // 
            // panelloading
            // 
            this.panelloading.Controls.Add(this.barCopiando);
            this.panelloading.Controls.Add(this.lblLimite);
            this.panelloading.Controls.Add(this.lblCopiando);
            this.panelloading.Controls.Add(this.label1);
            this.panelloading.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelloading.Location = new System.Drawing.Point(141, 0);
            this.panelloading.Name = "panelloading";
            this.panelloading.Size = new System.Drawing.Size(817, 42);
            this.panelloading.TabIndex = 3;
            // 
            // barCopiando
            // 
            this.barCopiando.Location = new System.Drawing.Point(506, 28);
            this.barCopiando.Name = "barCopiando";
            this.barCopiando.Size = new System.Drawing.Size(182, 8);
            this.barCopiando.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barCopiando.TabIndex = 4;
            // 
            // lblCopiando
            // 
            this.lblCopiando.AutoSize = true;
            this.lblCopiando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCopiando.Location = new System.Drawing.Point(544, 8);
            this.lblCopiando.Name = "lblCopiando";
            this.lblCopiando.Size = new System.Drawing.Size(118, 15);
            this.lblCopiando.TabIndex = 0;
            this.lblCopiando.Text = "Copiando Imagenes";
            // 
            // panelElements
            // 
            this.panelElements.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelElements.Location = new System.Drawing.Point(141, 48);
            this.panelElements.Name = "panelElements";
            this.panelElements.Size = new System.Drawing.Size(817, 140);
            this.panelElements.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnPhone);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.btnRemoveOne);
            this.panel1.Controls.Add(this.btnRemoveAll);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 188);
            this.panel1.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(14, 39);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(81, 17);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "0 imagenes";
            // 
            // btnRemoveOne
            // 
            this.btnRemoveOne.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnRemoveOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveOne.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveOne.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnRemoveOne.IconColor = System.Drawing.Color.Orange;
            this.btnRemoveOne.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoveOne.IconSize = 24;
            this.btnRemoveOne.Location = new System.Drawing.Point(12, 141);
            this.btnRemoveOne.Name = "btnRemoveOne";
            this.btnRemoveOne.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveOne.TabIndex = 0;
            this.btnRemoveOne.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveOne.UseVisualStyleBackColor = true;
            this.btnRemoveOne.Click += new System.EventHandler(this.btnRemoveOne_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveAll.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveAll.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnRemoveAll.IconColor = System.Drawing.Color.OrangeRed;
            this.btnRemoveAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemoveAll.IconSize = 24;
            this.btnRemoveAll.Location = new System.Drawing.Point(53, 141);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveAll.TabIndex = 0;
            this.btnRemoveAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccionadas:";
            // 
            // workerCopiando
            // 
            this.workerCopiando.WorkerReportsProgress = true;
            this.workerCopiando.WorkerSupportsCancellation = true;
            this.workerCopiando.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerCopiando_DoWork);
            this.workerCopiando.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerCopiando_ProgressChanged);
            this.workerCopiando.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerCopiando_RunWorkerCompleted);
            // 
            // imgWatcher
            // 
            this.imgWatcher.EnableRaisingEvents = true;
            this.imgWatcher.SynchronizingObject = this;
            this.imgWatcher.Created += new System.IO.FileSystemEventHandler(this.imgWatcher_Created);
            this.imgWatcher.Deleted += new System.IO.FileSystemEventHandler(this.imgWatcher_Deleted);
            this.imgWatcher.Error += new System.IO.ErrorEventHandler(this.imgWatcher_Error);
            this.imgWatcher.Renamed += new System.IO.RenamedEventHandler(this.imgWatcher_Renamed);
            // 
            // fullScreen
            // 
            this.fullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullScreen.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.fullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullScreen.ForeColor = System.Drawing.Color.Gainsboro;
            this.fullScreen.IconChar = FontAwesome.Sharp.IconChar.ArrowsAlt;
            this.fullScreen.IconColor = System.Drawing.Color.MintCream;
            this.fullScreen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.fullScreen.IconSize = 24;
            this.fullScreen.Location = new System.Drawing.Point(647, 12);
            this.fullScreen.Name = "fullScreen";
            this.fullScreen.Size = new System.Drawing.Size(30, 32);
            this.fullScreen.TabIndex = 0;
            this.fullScreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.fullScreen.UseVisualStyleBackColor = true;
            this.fullScreen.Visible = false;
            this.fullScreen.Click += new System.EventHandler(this.fullScreen_Click);
            // 
            // FrmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(958, 648);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmStore";
            this.Text = "Tienda";
            this.Load += new System.EventHandler(this.FrmStore_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.PanelContainer.ResumeLayout(false);
            this.PanelInnerContainer.ResumeLayout(false);
            this.panelCopies.ResumeLayout(false);
            this.panelloading.ResumeLayout(false);
            this.panelloading.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgWatcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnPhone;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnPrint;
        private System.Windows.Forms.FolderBrowserDialog _folderBrower;
        private System.Windows.Forms.Panel PanelContainer;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnPanel;
        private FontAwesome.Sharp.IconButton btnGalery;
        private FontAwesome.Sharp.IconButton btnThumbnail;
        private FontAwesome.Sharp.IconButton btnList;
        private System.Windows.Forms.Panel panelCopies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelInnerContainer;
        private System.Windows.Forms.Panel panelElements;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelloading;
        private System.Windows.Forms.Label lblTotalGaleria;
        private System.Windows.Forms.ProgressBar barCopiando;
        private System.Windows.Forms.Label lblCopiando;
        private System.ComponentModel.BackgroundWorker workerCopiando;
        private Manina.Windows.Forms.ImageListView ListImages;
        private System.IO.FileSystemWatcher imgWatcher;
        private FontAwesome.Sharp.IconButton btnSort;
        private FontAwesome.Sharp.IconButton btnRemoveOne;
        private FontAwesome.Sharp.IconButton btnRemoveAll;
        private FontAwesome.Sharp.IconButton btnInitTurno;
        private FontAwesome.Sharp.IconButton fullScreen;
    }
}