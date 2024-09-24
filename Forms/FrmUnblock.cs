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
    public partial class FrmUnblock : Form
    {
        private UsuarioController usrController;
        public event EventHandler OnCheckPass;

        public FrmUnblock()
        {
            usrController = new UsuarioController();
            InitializeComponent();
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (inptPass.Text == string.Empty) 
            {
                MessageBox.Show("Ingrese una Contraseña", "Desbloquear Equipo");
                return;
            }

            bool resp = usrController.Unlock(inptPass.Text);
            if (resp)
            {
                EventHandler evt = OnCheckPass;
                evt.Invoke(this, null);
                this.Close();
            }
            else 
            {
                MessageBox.Show("Contraseña Incorrecta", "Desbloquear Sistema");
            }


        }
    }
}
