
namespace ControlPhotoApp.Forms
{
    partial class FrmTurno
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
            this.label1 = new System.Windows.Forms.Label();
            this.inptCant = new System.Windows.Forms.TextBox();
            this.btnInitTurno = new FontAwesome.Sharp.IconButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caja Inicial";
            // 
            // inptCant
            // 
            this.inptCant.Location = new System.Drawing.Point(139, 25);
            this.inptCant.Name = "inptCant";
            this.inptCant.Size = new System.Drawing.Size(156, 29);
            this.inptCant.TabIndex = 1;
            // 
            // btnInitTurno
            // 
            this.btnInitTurno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInitTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.btnInitTurno.FlatAppearance.BorderSize = 0;
            this.btnInitTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInitTurno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnInitTurno.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnInitTurno.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnInitTurno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInitTurno.IconSize = 32;
            this.btnInitTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInitTurno.Location = new System.Drawing.Point(139, 70);
            this.btnInitTurno.Name = "btnInitTurno";
            this.btnInitTurno.Size = new System.Drawing.Size(156, 34);
            this.btnInitTurno.TabIndex = 6;
            this.btnInitTurno.Text = "Iniciar Turno";
            this.btnInitTurno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInitTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInitTurno.UseVisualStyleBackColor = false;
            this.btnInitTurno.Click += new System.EventHandler(this.btnInitTurno_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(37, 127);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(313, 63);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 7000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // FrmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(362, 199);
            this.Controls.Add(this.btnInitTurno);
            this.Controls.Add(this.inptCant);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTurno";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Turno";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inptCant;
        private FontAwesome.Sharp.IconButton btnInitTurno;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timerStatus;
    }
}