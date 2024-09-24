using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;

namespace ControlPhotoApp.Forms.Config
{
    public partial class FrmDataEnterprise : Form
    {      
        private ConfigController _controller;
        private Singleton _singleton;
        private string nameImage = "";
        private string tmpImage = "";        

        private struct RGBButtons
        {
            public static Color btnPrimary = Color.FromArgb(76, 201, 240);
            public static Color btnWarning = Color.Gold;
            public static Color btnDanger = Color.Crimson;
            public static Color btnBg = Color.FromArgb(7, 18, 36);
        }

        public FrmDataEnterprise()
        {
            _singleton = Singleton.GetInstance();
            _controller = new ConfigController();
            InitializeComponent();  
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            btnSave.BackColor = RGBButtons.btnBg;
            btnSave.ForeColor = RGBButtons.btnPrimary;
            btnSave.IconColor = RGBButtons.btnPrimary;
            btnSave.FlatAppearance.BorderSize = 1;
            btnSave.FlatAppearance.BorderColor = RGBButtons.btnPrimary;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = RGBButtons.btnPrimary;
            btnSave.ForeColor = RGBButtons.btnBg;
            btnSave.IconColor = RGBButtons.btnBg;
            btnSave.FlatAppearance.BorderSize = 0;
        }

      

       

        private void FrmDataEnterprise_Load(object sender, EventArgs e)
        {
            string razonsocial = _controller.GetConfig(new string[] { "EMPRESA", "RS"});
            string ubicacion = _controller.GetConfig(new string[] { "EMPRESA", "DIR" });
            string telefono = _controller.GetConfig(new string[] { "EMPRESA", "TEL" });
            string logo = _controller.GetConfig(new string[] { "EMPRESA", "LOGO"});

            if (razonsocial == "No Found" || razonsocial == "Fail, Missing Data")
                razonsocial = "";
            if (ubicacion == "No Found" || razonsocial == "Fail, Missing Data")
                ubicacion = "";
            if (telefono == "No found" || razonsocial == "Fail, Missing Data")
                telefono = "";
            if (logo == "No Found" || logo == "Fail, Missing Data")
                logo = "logo.jpg";

            inptRazonSocial.Text = razonsocial;
            inptUbicación.Text = ubicacion;
            inptTelefono.Text = telefono;
            nameImage = logo;

            try
            {
                Bitmap img = new Bitmap(nameImage);
                picLogo.Image = img;
            }catch (Exception)
            {
                picLogo.Image = null;
            }
        }
        
        private void btnOpenLogo_Click(object sender, EventArgs e)
        {
            if (_singleton._TypeUser == "ADMINISTRADOR")
            {
                DialogResult dr = openFileLogo.ShowDialog();
                openFileLogo.Filter = "Images Files (*.jpg; *.jpeg; *.png )|*.jpg; *.jpeg; *.png";
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        tmpImage = openFileLogo.FileName;
                        picLogo.Image = Image.FromFile(openFileLogo.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo Cargar la imagen : " + ex.Message, "Configuraciones");
                    }
                }
            }
            else
                MessageBox.Show("No tienes permisos para realizar esta operacón", "Configuraciones");
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tmpImage != String.Empty)
                    nameImage = _controller.SaveImage(tmpImage); // copiamos y sobreescribimos la imagen
                string[,] inputs = new string[4, 3]
                {
                    {"EMPRESA", "RS", inptRazonSocial.Text },
                    {"EMPRESA", "DIR", inptUbicación.Text },
                    {"EMPRESA", "TEL", inptTelefono.Text },
                    {"EMPRESA" , "LOGO", nameImage}
                };
                MessageBox.Show(_controller.SaveConfig(inputs), "Configuraciones Datos de Empresa");  // guardamos datos
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Configuraciónes Datos de Empresa");
            }
        }
    }
}
