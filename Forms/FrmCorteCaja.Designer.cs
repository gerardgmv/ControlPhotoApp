
namespace ControlPhotoApp.Forms
{
    partial class FrmCorteCaja
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnPDF = new FontAwesome.Sharp.IconButton();
            this.btnInitTurno = new FontAwesome.Sharp.IconButton();
            this.lblFechaCierre = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelgrid = new System.Windows.Forms.Panel();
            this.gridDetailCorte = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVentasNetas = new System.Windows.Forms.Label();
            this.lblImpresiones = new System.Windows.Forms.Label();
            this.lblCaja = new System.Windows.Forms.Label();
            this.lblTotalCopias = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pdfWorker = new System.ComponentModel.BackgroundWorker();
            this.barra = new System.Windows.Forms.ProgressBar();
            this.lblLoadFile = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetailCorte)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnPDF);
            this.panelTop.Controls.Add(this.btnInitTurno);
            this.panelTop.Controls.Add(this.lblFechaCierre);
            this.panelTop.Controls.Add(this.label9);
            this.panelTop.Controls.Add(this.lblFechaInicio);
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(948, 86);
            this.panelTop.TabIndex = 0;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.SeaShell;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnPDF.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.btnPDF.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPDF.IconSize = 32;
            this.btnPDF.Location = new System.Drawing.Point(207, 25);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(156, 34);
            this.btnPDF.TabIndex = 7;
            this.btnPDF.Text = "Generar PDF";
            this.btnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnInitTurno
            // 
            this.btnInitTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.btnInitTurno.FlatAppearance.BorderSize = 0;
            this.btnInitTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInitTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnInitTurno.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.btnInitTurno.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnInitTurno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInitTurno.IconSize = 32;
            this.btnInitTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInitTurno.Location = new System.Drawing.Point(24, 25);
            this.btnInitTurno.Name = "btnInitTurno";
            this.btnInitTurno.Size = new System.Drawing.Size(156, 34);
            this.btnInitTurno.TabIndex = 7;
            this.btnInitTurno.Text = "Cerrar Turno";
            this.btnInitTurno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInitTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInitTurno.UseVisualStyleBackColor = false;
            this.btnInitTurno.Click += new System.EventHandler(this.btnInitTurno_Click);
            // 
            // lblFechaCierre
            // 
            this.lblFechaCierre.AutoSize = true;
            this.lblFechaCierre.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblFechaCierre.Location = new System.Drawing.Point(643, 49);
            this.lblFechaCierre.Name = "lblFechaCierre";
            this.lblFechaCierre.Size = new System.Drawing.Size(0, 21);
            this.lblFechaCierre.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(471, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "FECHA DE CIERRE";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblFechaInicio.Location = new System.Drawing.Point(643, 17);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(0, 21);
            this.lblFechaInicio.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "FECHA DE INICIO";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.lblLoadFile);
            this.panelContainer.Controls.Add(this.barra);
            this.panelContainer.Controls.Add(this.panelgrid);
            this.panelContainer.Controls.Add(this.label8);
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.label6);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.label5);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.lblVentasNetas);
            this.panelContainer.Controls.Add(this.lblImpresiones);
            this.panelContainer.Controls.Add(this.lblCaja);
            this.panelContainer.Controls.Add(this.lblTotalCopias);
            this.panelContainer.Controls.Add(this.lblTotal);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 86);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(948, 502);
            this.panelContainer.TabIndex = 1;
            // 
            // panelgrid
            // 
            this.panelgrid.Controls.Add(this.gridDetailCorte);
            this.panelgrid.ForeColor = System.Drawing.Color.Black;
            this.panelgrid.Location = new System.Drawing.Point(415, 59);
            this.panelgrid.Name = "panelgrid";
            this.panelgrid.Size = new System.Drawing.Size(521, 431);
            this.panelgrid.TabIndex = 2;
            // 
            // gridDetailCorte
            // 
            this.gridDetailCorte.AllowUserToAddRows = false;
            this.gridDetailCorte.AllowUserToDeleteRows = false;
            this.gridDetailCorte.AllowUserToOrderColumns = true;
            this.gridDetailCorte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDetailCorte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetailCorte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDetailCorte.Location = new System.Drawing.Point(0, 0);
            this.gridDetailCorte.MultiSelect = false;
            this.gridDetailCorte.Name = "gridDetailCorte";
            this.gridDetailCorte.ReadOnly = true;
            this.gridDetailCorte.RowTemplate.Height = 25;
            this.gridDetailCorte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetailCorte.Size = new System.Drawing.Size(521, 431);
            this.gridDetailCorte.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(623, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "DETALLE DEL DIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(124, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "CORTE GENERAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "VENTAS NETAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "TOTAL DE IMPRESIONES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "CAJA INICIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "TOTAL DE COPIAS";
            // 
            // lblVentasNetas
            // 
            this.lblVentasNetas.AutoSize = true;
            this.lblVentasNetas.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblVentasNetas.Location = new System.Drawing.Point(297, 234);
            this.lblVentasNetas.Name = "lblVentasNetas";
            this.lblVentasNetas.Size = new System.Drawing.Size(80, 21);
            this.lblVentasNetas.TabIndex = 0;
            this.lblVentasNetas.Text = "$ 1000.00";
            // 
            // lblImpresiones
            // 
            this.lblImpresiones.AutoSize = true;
            this.lblImpresiones.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblImpresiones.Location = new System.Drawing.Point(297, 186);
            this.lblImpresiones.Name = "lblImpresiones";
            this.lblImpresiones.Size = new System.Drawing.Size(80, 21);
            this.lblImpresiones.TabIndex = 0;
            this.lblImpresiones.Text = "$ 1000.00";
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCaja.Location = new System.Drawing.Point(297, 86);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(80, 21);
            this.lblCaja.TabIndex = 0;
            this.lblCaja.Text = "$ 1000.00";
            // 
            // lblTotalCopias
            // 
            this.lblTotalCopias.AutoSize = true;
            this.lblTotalCopias.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTotalCopias.Location = new System.Drawing.Point(297, 136);
            this.lblTotalCopias.Name = "lblTotalCopias";
            this.lblTotalCopias.Size = new System.Drawing.Size(80, 21);
            this.lblTotalCopias.TabIndex = 0;
            this.lblTotalCopias.Text = "$ 1000.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblTotal.Location = new System.Drawing.Point(108, 330);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(269, 74);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "$ 1000.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL DE EFECTIVO";
            // 
            // pdfWorker
            // 
            this.pdfWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.pdfWorker_DoWork);
            this.pdfWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.pdfWorker_RunWorkerCompleted);
            // 
            // barra
            // 
            this.barra.Location = new System.Drawing.Point(127, 476);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(237, 10);
            this.barra.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.barra.TabIndex = 3;
            // 
            // lblLoadFile
            // 
            this.lblLoadFile.AutoSize = true;
            this.lblLoadFile.Location = new System.Drawing.Point(142, 452);
            this.lblLoadFile.Name = "lblLoadFile";
            this.lblLoadFile.Size = new System.Drawing.Size(203, 21);
            this.lblLoadFile.TabIndex = 4;
            this.lblLoadFile.Text = "Espere... Generando Archivo";
            // 
            // FrmCorteCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(948, 588);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "FrmCorteCaja";
            this.Text = "Corte de Caja";
            this.Load += new System.EventHandler(this.FrmCorteCaja_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panelgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetailCorte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.DataGridView gridDetailCorte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblImpresiones;
        private System.Windows.Forms.Label lblTotalCopias;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnInitTurno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVentasNetas;
        private System.Windows.Forms.Label lblFechaCierre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelgrid;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private FontAwesome.Sharp.IconButton btnPDF;
        private System.Windows.Forms.Label lblLoadFile;
        private System.Windows.Forms.ProgressBar barra;
        private System.ComponentModel.BackgroundWorker pdfWorker;
    }
}