
namespace ControlPhotoApp
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.SubbtnExit = new FontAwesome.Sharp.IconButton();
            this.SubBtnUnLock = new FontAwesome.Sharp.IconButton();
            this.btnCloseSession = new FontAwesome.Sharp.IconButton();
            this.btnCloseTurno = new FontAwesome.Sharp.IconButton();
            this.subMenuSystem = new System.Windows.Forms.Panel();
            this.btnDataBase = new FontAwesome.Sharp.IconButton();
            this.btnTerminal = new FontAwesome.Sharp.IconButton();
            this.btnEnterprise = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnConfig = new FontAwesome.Sharp.IconButton();
            this.btnReports = new FontAwesome.Sharp.IconButton();
            this.btnStore = new FontAwesome.Sharp.IconButton();
            this.PanelUser = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblTerminal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPricePrints = new System.Windows.Forms.Label();
            this.lblPriceCopies = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.currentIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.backWorker = new System.ComponentModel.BackgroundWorker();
            this.panelMain.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.subMenuSystem.SuspendLayout();
            this.PanelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentIcon)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(8)))), ((int)(((byte)(19)))));
            this.panelMain.Controls.Add(this.panelMenu);
            this.panelMain.Controls.Add(this.PanelUser);
            this.panelMain.Controls.Add(this.panelLogo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(186, 749);
            this.panelMain.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelMenu.AutoScroll = true;
            this.panelMenu.Controls.Add(this.SubbtnExit);
            this.panelMenu.Controls.Add(this.SubBtnUnLock);
            this.panelMenu.Controls.Add(this.btnCloseSession);
            this.panelMenu.Controls.Add(this.btnCloseTurno);
            this.panelMenu.Controls.Add(this.subMenuSystem);
            this.panelMenu.Controls.Add(this.btnConfig);
            this.panelMenu.Controls.Add(this.btnReports);
            this.panelMenu.Controls.Add(this.btnStore);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 70);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(186, 480);
            this.panelMenu.TabIndex = 0;
            // 
            // SubbtnExit
            // 
            this.SubbtnExit.CausesValidation = false;
            this.SubbtnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubbtnExit.FlatAppearance.BorderSize = 0;
            this.SubbtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubbtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubbtnExit.ForeColor = System.Drawing.Color.DarkOrange;
            this.SubbtnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.SubbtnExit.IconColor = System.Drawing.Color.OrangeRed;
            this.SubbtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubbtnExit.IconSize = 32;
            this.SubbtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubbtnExit.Location = new System.Drawing.Point(0, 426);
            this.SubbtnExit.Name = "SubbtnExit";
            this.SubbtnExit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.SubbtnExit.Size = new System.Drawing.Size(186, 45);
            this.SubbtnExit.TabIndex = 9;
            this.SubbtnExit.Text = "Salir";
            this.SubbtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SubbtnExit.UseVisualStyleBackColor = true;
            this.SubbtnExit.Click += new System.EventHandler(this.SubbtnExit_Click);
            // 
            // SubBtnUnLock
            // 
            this.SubBtnUnLock.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubBtnUnLock.FlatAppearance.BorderSize = 0;
            this.SubBtnUnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubBtnUnLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubBtnUnLock.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            this.SubBtnUnLock.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.SubBtnUnLock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubBtnUnLock.IconSize = 32;
            this.SubBtnUnLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubBtnUnLock.Location = new System.Drawing.Point(0, 381);
            this.SubBtnUnLock.Name = "SubBtnUnLock";
            this.SubBtnUnLock.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.SubBtnUnLock.Size = new System.Drawing.Size(186, 45);
            this.SubBtnUnLock.TabIndex = 8;
            this.SubBtnUnLock.Text = "Desbloquear";
            this.SubBtnUnLock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubBtnUnLock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SubBtnUnLock.UseVisualStyleBackColor = true;
            this.SubBtnUnLock.Click += new System.EventHandler(this.SubBtnUnLock_Click);
            // 
            // btnCloseSession
            // 
            this.btnCloseSession.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCloseSession.FlatAppearance.BorderSize = 0;
            this.btnCloseSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseSession.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnCloseSession.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.btnCloseSession.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseSession.IconSize = 32;
            this.btnCloseSession.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseSession.Location = new System.Drawing.Point(0, 336);
            this.btnCloseSession.Name = "btnCloseSession";
            this.btnCloseSession.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCloseSession.Size = new System.Drawing.Size(186, 45);
            this.btnCloseSession.TabIndex = 11;
            this.btnCloseSession.Text = "Cerrar Sesion";
            this.btnCloseSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseSession.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseSession.UseVisualStyleBackColor = true;
            this.btnCloseSession.Click += new System.EventHandler(this.btnCloseSession_Click);
            // 
            // btnCloseTurno
            // 
            this.btnCloseTurno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCloseTurno.FlatAppearance.BorderSize = 0;
            this.btnCloseTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseTurno.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnCloseTurno.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.btnCloseTurno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseTurno.IconSize = 32;
            this.btnCloseTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseTurno.Location = new System.Drawing.Point(0, 291);
            this.btnCloseTurno.Name = "btnCloseTurno";
            this.btnCloseTurno.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCloseTurno.Size = new System.Drawing.Size(186, 45);
            this.btnCloseTurno.TabIndex = 10;
            this.btnCloseTurno.Text = "Corte de Caja";
            this.btnCloseTurno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseTurno.UseVisualStyleBackColor = true;
            this.btnCloseTurno.Click += new System.EventHandler(this.btnCloseTurno_Click);
            // 
            // subMenuSystem
            // 
            this.subMenuSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.subMenuSystem.Controls.Add(this.btnDataBase);
            this.subMenuSystem.Controls.Add(this.btnTerminal);
            this.subMenuSystem.Controls.Add(this.btnEnterprise);
            this.subMenuSystem.Controls.Add(this.btnUsuarios);
            this.subMenuSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuSystem.Location = new System.Drawing.Point(0, 135);
            this.subMenuSystem.Name = "subMenuSystem";
            this.subMenuSystem.Size = new System.Drawing.Size(186, 156);
            this.subMenuSystem.TabIndex = 10;
            // 
            // btnDataBase
            // 
            this.btnDataBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDataBase.FlatAppearance.BorderSize = 0;
            this.btnDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDataBase.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnDataBase.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.btnDataBase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDataBase.IconSize = 32;
            this.btnDataBase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataBase.Location = new System.Drawing.Point(0, 115);
            this.btnDataBase.Name = "btnDataBase";
            this.btnDataBase.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.btnDataBase.Size = new System.Drawing.Size(186, 40);
            this.btnDataBase.TabIndex = 6;
            this.btnDataBase.Text = "Base de Datos";
            this.btnDataBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataBase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDataBase.UseVisualStyleBackColor = true;
            this.btnDataBase.Click += new System.EventHandler(this.btnDataBase_Click);
            // 
            // btnTerminal
            // 
            this.btnTerminal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTerminal.FlatAppearance.BorderSize = 0;
            this.btnTerminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTerminal.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnTerminal.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.btnTerminal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTerminal.IconSize = 32;
            this.btnTerminal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerminal.Location = new System.Drawing.Point(0, 80);
            this.btnTerminal.Name = "btnTerminal";
            this.btnTerminal.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.btnTerminal.Size = new System.Drawing.Size(186, 35);
            this.btnTerminal.TabIndex = 5;
            this.btnTerminal.Text = "Config Terminal";
            this.btnTerminal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerminal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTerminal.UseVisualStyleBackColor = true;
            this.btnTerminal.Click += new System.EventHandler(this.btnTerminal_Click);
            // 
            // btnEnterprise
            // 
            this.btnEnterprise.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnterprise.FlatAppearance.BorderSize = 0;
            this.btnEnterprise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterprise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnterprise.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.btnEnterprise.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.btnEnterprise.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnterprise.IconSize = 32;
            this.btnEnterprise.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnterprise.Location = new System.Drawing.Point(0, 40);
            this.btnEnterprise.Name = "btnEnterprise";
            this.btnEnterprise.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.btnEnterprise.Size = new System.Drawing.Size(186, 40);
            this.btnEnterprise.TabIndex = 4;
            this.btnEnterprise.Text = "Datos de Empresa";
            this.btnEnterprise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnterprise.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnterprise.UseVisualStyleBackColor = true;
            this.btnEnterprise.Click += new System.EventHandler(this.btnEnterprise_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnUsuarios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 32;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(186, 40);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfig.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnConfig.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.btnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfig.IconSize = 32;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 90);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConfig.Size = new System.Drawing.Size(186, 45);
            this.btnConfig.TabIndex = 3;
            this.btnConfig.Text = "Sistema";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReports.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnReports.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReports.IconSize = 32;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 45);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReports.Size = new System.Drawing.Size(186, 45);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Reportes";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnStore
            // 
            this.btnStore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStore.FlatAppearance.BorderSize = 0;
            this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStore.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btnStore.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.btnStore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStore.IconSize = 32;
            this.btnStore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStore.Location = new System.Drawing.Point(0, 0);
            this.btnStore.Name = "btnStore";
            this.btnStore.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStore.Size = new System.Drawing.Size(186, 45);
            this.btnStore.TabIndex = 1;
            this.btnStore.Text = "Ventas";
            this.btnStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // PanelUser
            // 
            this.PanelUser.Controls.Add(this.iconPictureBox1);
            this.PanelUser.Controls.Add(this.lblUserType);
            this.PanelUser.Controls.Add(this.lblUsuario);
            this.PanelUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelUser.Location = new System.Drawing.Point(0, 581);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Size = new System.Drawing.Size(186, 168);
            this.PanelUser.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(8)))), ((int)(((byte)(19)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.YellowGreen;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.YellowGreen;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 52;
            this.iconPictureBox1.Location = new System.Drawing.Point(63, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(55, 52);
            this.iconPictureBox1.TabIndex = 12;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblUserType
            // 
            this.lblUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserType.Location = new System.Drawing.Point(12, 134);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(154, 25);
            this.lblUserType.TabIndex = 5;
            this.lblUserType.Text = "Administrador";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(12, 73);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(154, 33);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Admin";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.Logo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(186, 70);
            this.panelLogo.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Image = global::ControlPhotoApp.Properties.Resources.logo_generic;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(177, 50);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoEllipsis = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(904, 4);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(250, 25);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Domingo 08 de agosto 2021";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha.UseMnemonic = false;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.Location = new System.Drawing.Point(832, 4);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(78, 29);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "16:00";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(8)))), ((int)(((byte)(19)))));
            this.panelHeader.Controls.Add(this.lblHora);
            this.panelHeader.Controls.Add(this.lblFecha);
            this.panelHeader.Controls.Add(this.lblEmpresa);
            this.panelHeader.Controls.Add(this.lblTerminal);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.lblPricePrints);
            this.panelHeader.Controls.Add(this.lblPriceCopies);
            this.panelHeader.Controls.Add(this.currentLabel);
            this.panelHeader.Controls.Add(this.currentIcon);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelHeader.Location = new System.Drawing.Point(186, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1166, 62);
            this.panelHeader.TabIndex = 1;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblEmpresa.Location = new System.Drawing.Point(215, 8);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(392, 50);
            this.lblEmpresa.TabIndex = 5;
            this.lblEmpresa.Text = "NOMBRE DE LA EMPRESA";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTerminal
            // 
            this.lblTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTerminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTerminal.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblTerminal.Location = new System.Drawing.Point(916, 32);
            this.lblTerminal.Name = "lblTerminal";
            this.lblTerminal.Size = new System.Drawing.Size(238, 25);
            this.lblTerminal.TabIndex = 5;
            this.lblTerminal.Text = "Terminal 1";
            this.lblTerminal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(613, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio por Impresion";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(613, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Precio por Copias";
            // 
            // lblPricePrints
            // 
            this.lblPricePrints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPricePrints.AutoSize = true;
            this.lblPricePrints.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPricePrints.Location = new System.Drawing.Point(759, 32);
            this.lblPricePrints.Name = "lblPricePrints";
            this.lblPricePrints.Size = new System.Drawing.Size(67, 20);
            this.lblPricePrints.TabIndex = 5;
            this.lblPricePrints.Text = "$100.00";
            // 
            // lblPriceCopies
            // 
            this.lblPriceCopies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPriceCopies.AutoSize = true;
            this.lblPriceCopies.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblPriceCopies.Location = new System.Drawing.Point(759, 9);
            this.lblPriceCopies.Name = "lblPriceCopies";
            this.lblPriceCopies.Size = new System.Drawing.Size(67, 20);
            this.lblPriceCopies.TabIndex = 5;
            this.lblPriceCopies.Text = "$100.00";
            // 
            // currentLabel
            // 
            this.currentLabel.Location = new System.Drawing.Point(57, 12);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(119, 44);
            this.currentLabel.TabIndex = 4;
            this.currentLabel.Text = "Datos de Empresa";
            this.currentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentIcon
            // 
            this.currentIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(8)))), ((int)(((byte)(19)))));
            this.currentIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.currentIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.currentIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.currentIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentIcon.Location = new System.Drawing.Point(19, 19);
            this.currentIcon.Name = "currentIcon";
            this.currentIcon.Size = new System.Drawing.Size(32, 32);
            this.currentIcon.TabIndex = 3;
            this.currentIcon.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.panelContainer.Controls.Add(this.lblLoading);
            this.panelContainer.Controls.Add(this.pBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(186, 62);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1166, 687);
            this.panelContainer.TabIndex = 2;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(465, 364);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(155, 20);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Cargando Aplicación";
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(370, 396);
            this.pBar.MarqueeAnimationSpeed = 200;
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(372, 10);
            this.pBar.Step = 5;
            this.pBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pBar.TabIndex = 0;
            // 
            // ClockTimer
            // 
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // backWorker
            // 
            this.backWorker.WorkerReportsProgress = true;
            this.backWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backWorker_DoWork);
            this.backWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backWorker_RunWorkerCompleted);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1352, 749);
            this.ControlBox = false;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.panelMain.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.subMenuSystem.ResumeLayout(false);
            this.PanelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentIcon)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnReports;
        private FontAwesome.Sharp.IconButton btnStore;
        private System.Windows.Forms.PictureBox Logo;
        private FontAwesome.Sharp.IconButton btnConfig;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label currentLabel;
        private FontAwesome.Sharp.IconPictureBox currentIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPricePrints;
        private System.Windows.Forms.Label lblPriceCopies;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel PanelUser;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblTerminal;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Panel subMenuSystem;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnDataBase;
        private FontAwesome.Sharp.IconButton btnTerminal;
        private FontAwesome.Sharp.IconButton btnEnterprise;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblEmpresa;
        private FontAwesome.Sharp.IconButton SubbtnExit;
        private FontAwesome.Sharp.IconButton SubBtnUnLock;
        private FontAwesome.Sharp.IconButton btnCloseTurno;
        private System.ComponentModel.BackgroundWorker backWorker;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.ProgressBar pBar;
        private FontAwesome.Sharp.IconButton btnCloseSession;
    }
}