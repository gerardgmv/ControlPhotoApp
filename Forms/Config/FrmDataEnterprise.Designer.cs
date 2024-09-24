
namespace ControlPhotoApp.Forms.Config
{
    partial class FrmDataEnterprise
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inptRazonSocial = new System.Windows.Forms.TextBox();
            this.inptUbicación = new System.Windows.Forms.TextBox();
            this.inptTelefono = new System.Windows.Forms.TextBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.openFileLogo = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenLogo = new FontAwesome.Sharp.IconButton();
            this.lblLogoName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razon Social:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ubicación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefono";
            // 
            // inptRazonSocial
            // 
            this.inptRazonSocial.Location = new System.Drawing.Point(181, 65);
            this.inptRazonSocial.Name = "inptRazonSocial";
            this.inptRazonSocial.Size = new System.Drawing.Size(600, 26);
            this.inptRazonSocial.TabIndex = 1;
            // 
            // inptUbicación
            // 
            this.inptUbicación.Location = new System.Drawing.Point(181, 124);
            this.inptUbicación.Name = "inptUbicación";
            this.inptUbicación.Size = new System.Drawing.Size(600, 26);
            this.inptUbicación.TabIndex = 1;
            // 
            // inptTelefono
            // 
            this.inptTelefono.Location = new System.Drawing.Point(181, 178);
            this.inptTelefono.Name = "inptTelefono";
            this.inptTelefono.Size = new System.Drawing.Size(275, 26);
            this.inptTelefono.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(181, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 47);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Logotipo";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::ControlPhotoApp.Properties.Resources.logo_generic;
            this.picLogo.Location = new System.Drawing.Point(181, 229);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(471, 225);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // openFileLogo
            // 
            this.openFileLogo.FileName = "openFileDialog1";
            // 
            // btnOpenLogo
            // 
            this.btnOpenLogo.BackColor = System.Drawing.Color.Goldenrod;
            this.btnOpenLogo.FlatAppearance.BorderSize = 0;
            this.btnOpenLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnOpenLogo.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnOpenLogo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.btnOpenLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenLogo.IconSize = 28;
            this.btnOpenLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenLogo.Location = new System.Drawing.Point(658, 229);
            this.btnOpenLogo.Name = "btnOpenLogo";
            this.btnOpenLogo.Size = new System.Drawing.Size(123, 47);
            this.btnOpenLogo.TabIndex = 2;
            this.btnOpenLogo.Text = "Seleccionar Imagen";
            this.btnOpenLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenLogo.UseVisualStyleBackColor = false;
            this.btnOpenLogo.Click += new System.EventHandler(this.btnOpenLogo_Click);
            // 
            // lblLogoName
            // 
            this.lblLogoName.AutoSize = true;
            this.lblLogoName.Location = new System.Drawing.Point(181, 359);
            this.lblLogoName.Name = "lblLogoName";
            this.lblLogoName.Size = new System.Drawing.Size(0, 20);
            this.lblLogoName.TabIndex = 0;
            // 
            // FrmDataEnterprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(948, 588);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnOpenLogo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.inptTelefono);
            this.Controls.Add(this.inptUbicación);
            this.Controls.Add(this.inptRazonSocial);
            this.Controls.Add(this.lblLogoName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDataEnterprise";
            this.Text = "Datos Empresa";
            this.Load += new System.EventHandler(this.FrmDataEnterprise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inptRazonSocial;
        private System.Windows.Forms.TextBox inptUbicación;
        private System.Windows.Forms.TextBox inptTelefono;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.OpenFileDialog openFileLogo;
        private FontAwesome.Sharp.IconButton btnOpenLogo;
        private System.Windows.Forms.Label lblLogoName;
    }
}