
namespace ControlPhotoApp.Forms.Config
{
    partial class FrmTerminal
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
            this.inptPriceCopies = new System.Windows.Forms.TextBox();
            this.inptPricePrint = new System.Windows.Forms.TextBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inptTerminal = new System.Windows.Forms.TextBox();
            this.checkLock = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPrinters = new System.Windows.Forms.ComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.inptMaxCopies = new System.Windows.Forms.NumericUpDown();
            this.inptMinCopies = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inptMaxCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptMinCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio por Copia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Precio por Impresion";
            // 
            // inptPriceCopies
            // 
            this.inptPriceCopies.Location = new System.Drawing.Point(253, 97);
            this.inptPriceCopies.Name = "inptPriceCopies";
            this.inptPriceCopies.Size = new System.Drawing.Size(200, 26);
            this.inptPriceCopies.TabIndex = 1;
            // 
            // inptPricePrint
            // 
            this.inptPricePrint.Location = new System.Drawing.Point(657, 97);
            this.inptPricePrint.Name = "inptPricePrint";
            this.inptPricePrint.Size = new System.Drawing.Size(200, 26);
            this.inptPricePrint.TabIndex = 1;
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
            this.btnSave.Location = new System.Drawing.Point(253, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 47);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Máximo de Copias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Minimo de Copias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Numero/Terminal";
            // 
            // inptTerminal
            // 
            this.inptTerminal.Location = new System.Drawing.Point(253, 40);
            this.inptTerminal.Name = "inptTerminal";
            this.inptTerminal.Size = new System.Drawing.Size(604, 26);
            this.inptTerminal.TabIndex = 1;
            // 
            // checkLock
            // 
            this.checkLock.AutoSize = true;
            this.checkLock.Location = new System.Drawing.Point(253, 268);
            this.checkLock.Name = "checkLock";
            this.checkLock.Size = new System.Drawing.Size(146, 24);
            this.checkLock.TabIndex = 5;
            this.checkLock.Text = "Bloquear Equipo";
            this.checkLock.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Impresora ";
            // 
            // cmbPrinters
            // 
            this.cmbPrinters.FormattingEnabled = true;
            this.cmbPrinters.Location = new System.Drawing.Point(253, 211);
            this.cmbPrinters.Name = "cmbPrinters";
            this.cmbPrinters.Size = new System.Drawing.Size(403, 28);
            this.cmbPrinters.TabIndex = 6;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(671, 211);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(140, 28);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Refrescar Impresoras";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // inptMaxCopies
            // 
            this.inptMaxCopies.Location = new System.Drawing.Point(253, 156);
            this.inptMaxCopies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inptMaxCopies.Name = "inptMaxCopies";
            this.inptMaxCopies.Size = new System.Drawing.Size(120, 26);
            this.inptMaxCopies.TabIndex = 7;
            this.inptMaxCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // inptMinCopies
            // 
            this.inptMinCopies.Location = new System.Drawing.Point(657, 154);
            this.inptMinCopies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inptMinCopies.Name = "inptMinCopies";
            this.inptMinCopies.Size = new System.Drawing.Size(120, 26);
            this.inptMinCopies.TabIndex = 7;
            this.inptMinCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(948, 588);
            this.Controls.Add(this.inptMinCopies);
            this.Controls.Add(this.inptMaxCopies);
            this.Controls.Add(this.cmbPrinters);
            this.Controls.Add(this.checkLock);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.inptPricePrint);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inptTerminal);
            this.Controls.Add(this.inptPriceCopies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTerminal";
            this.Text = "Configuración de Terminal";
            this.Load += new System.EventHandler(this.FrmPrecios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inptMaxCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptMinCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inptPriceCopies;
        private System.Windows.Forms.TextBox inptPricePrint;
        private FontAwesome.Sharp.IconButton btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inptTerminal;
        private System.Windows.Forms.CheckBox checkLock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPrinters;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.NumericUpDown inptMaxCopies;
        private System.Windows.Forms.NumericUpDown inptMinCopies;
    }
}