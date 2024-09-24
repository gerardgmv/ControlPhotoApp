using System;
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
    public partial class Servidor : Form
    {
        Singleton _singleton;
        ConfigController _controller;
        public Servidor()
        {
            _singleton = Singleton.GetInstance();
            _controller = new ConfigController();
            InitializeComponent();
            btnSave.Enabled = false;
            btnConnection.Enabled = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (_singleton._TypeUser == "ADMINISTRADOR")
            {
                string servidor = _controller.GetConfig(new string[] { "CONECCION_FTP", "SERVIDOR" });
                string puerto = _controller.GetConfig(new string[] { "CONECCION_FTP", "PUERTO" });
                string tipo = _controller.GetConfig(new string[] { "CONECCION_FTP", "TIPO_CONECCION"});
                string usuario = _controller.GetConfig(new string[] { "CONECCION_FTP", "USUARIO"});
                string password = _controller.GetConfig(new string[] { "CONECCION_FTP", "PASSWORD"});

                if (servidor == "No Found" || servidor == "Fail, Missing Data")
                    inptServidor.Text = "";
                else
                    inptServidor.Text = servidor;

                if (puerto == "No Found" || puerto == "Fail, Missing Data")
                    inptPuerto.Text = "";
                else
                    inptPuerto.Text = puerto;

                if (tipo == "No Found" || tipo == "Fail, Missing Data")
                    inptTipo.Text = "";
                else
                    inptTipo.Text = tipo;

                if (usuario == "No Found" || usuario == "Fail, Missing Data")
                    inptUsuario.Text = "";
                else
                    inptUsuario.Text = usuario;

                if (password == "No Found" || password == "Fail, Missing Data")
                    inptPassword.Text = "";
                else
                    inptPassword.Text = password;

                btnConnection.Enabled = true;
                btnSave.Enabled = true;
            }
            else
                MessageBox.Show("No tienes suficientes permisos para este modulo", "Configuraciones");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[,] inputs = new string[5, 3]
            {
                {"CONECCION_FTP", "SERVIDOR", inptServidor.Text },
                {"CONECCION_FTP", "PUERTO", inptPuerto.Text },
                {"CONECCION_FTP", "USUARIO", inptUsuario.Text },
                {"CONECCION_FTP", "PASSWORD", inptPassword.Text },
                {"CONECCION_FTP", "TIPO_CONECCION", inptTipo.Text }
            };

            try 
            {
                MessageBox.Show(_controller.SaveConfig(inputs), "Configuraciones");
                ClearForm();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Configuraciones");
            }
        }

        private void ClearForm()
        {
            inptServidor.Text = "";
            inptPuerto.Text = "";
            inptTipo.Text = "";
            inptUsuario.Text = "";
            inptPassword.Text = "";

        }
    }
}
