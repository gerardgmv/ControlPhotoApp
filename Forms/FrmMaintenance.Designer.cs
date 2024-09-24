
namespace ControlPhotoApp.Forms
{
    partial class FrmMaintenance
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDataBase = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnCopyGalery = new FontAwesome.Sharp.IconButton();
            this.btnInitDB = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInitDB);
            this.panel1.Controls.Add(this.btnDataBase);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.btnCopyGalery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 60);
            this.panel1.TabIndex = 0;
            // 
            // btnDataBase
            // 
            this.btnDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDataBase.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnDataBase.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDataBase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDataBase.IconSize = 32;
            this.btnDataBase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataBase.Location = new System.Drawing.Point(291, 9);
            this.btnDataBase.Name = "btnDataBase";
            this.btnDataBase.Size = new System.Drawing.Size(155, 45);
            this.btnDataBase.TabIndex = 0;
            this.btnDataBase.Text = "Respaldar Base de Datos";
            this.btnDataBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataBase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDataBase.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(156, 9);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(120, 45);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Eliminar Galeria";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnCopyGalery
            // 
            this.btnCopyGalery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyGalery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCopyGalery.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnCopyGalery.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCopyGalery.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCopyGalery.IconSize = 32;
            this.btnCopyGalery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyGalery.Location = new System.Drawing.Point(20, 9);
            this.btnCopyGalery.Name = "btnCopyGalery";
            this.btnCopyGalery.Size = new System.Drawing.Size(120, 45);
            this.btnCopyGalery.TabIndex = 0;
            this.btnCopyGalery.Text = "Respaldar Galeria";
            this.btnCopyGalery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyGalery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCopyGalery.UseVisualStyleBackColor = true;
            // 
            // btnInitDB
            // 
            this.btnInitDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInitDB.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnInitDB.IconColor = System.Drawing.Color.Gainsboro;
            this.btnInitDB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInitDB.IconSize = 32;
            this.btnInitDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInitDB.Location = new System.Drawing.Point(462, 9);
            this.btnInitDB.Name = "btnInitDB";
            this.btnInitDB.Size = new System.Drawing.Size(155, 45);
            this.btnInitDB.TabIndex = 0;
            this.btnInitDB.Text = "Inicializar Base de Datos";
            this.btnInitDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInitDB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInitDB.UseVisualStyleBackColor = true;
            this.btnInitDB.Click += new System.EventHandler(this.btnInitDB_Click);
            // 
            // FrmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(948, 588);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMaintenance";
            this.Text = "Mantenimiento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMaintenance_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnDataBase;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnCopyGalery;
        private FontAwesome.Sharp.IconButton btnInitDB;
    }
}