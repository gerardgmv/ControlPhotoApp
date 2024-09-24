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

namespace ControlPhotoApp.Forms
{
    public partial class FrmLogin : Form
    {
        private UsuarioController oUsrController;
        private Singleton _singleton;
        public FrmLogin()
        {
            oUsrController = new UsuarioController();
            _singleton = Singleton.GetInstance();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SendLogin();
        }

        private void InptPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13) 
            {
                this.SendLogin();   
            }
        }


        private void SendLogin() 
        {
            if (InptUser.Text == string.Empty || InptPass.Text == string.Empty)
            {
                MessageBox.Show("El Usuario y  la Contraseña son obligatorios");
                return;
            }

            if (oUsrController.Login(InptUser.Text, InptPass.Text))
                _singleton.OnLogIn(EventArgs.Empty);
            else
                MessageBox.Show("El Usuario y/o la contraseña no son correctas");
        }

        private void InptUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13) 
            {
                this.SendLogin();
            }
        }
    }
}
