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
    public partial class FrmUsers : Form
    {
        private UsuarioController UsrController;
        private int Id = 0;
        private bool IsEdit = false;

        public FrmUsers()
        {
            UsrController = new UsuarioController();
            InitializeComponent();
            inptTipo.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            string[] Params = new string[6]
            {
                inptNombre.Text,
                inptUsuario.Text,
                inptPass.Text,
                inptPass2.Text,
                (string) inptTipo.SelectedItem,
                (string) cmbEstado.SelectedItem
            };
            try
            {
                if (!IsEdit)
                    MessageBox.Show(await UsrController.Register(Params), "Registro de Usuarios");
                else
                {
                    MessageBox.Show(await UsrController.Update(Params, Id), "Actualización de Usuarios");
                    IsEdit = false;
                    Id = 0;
                }
                ClearForm();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registro de Usuarios");
            }
           
        }

       
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FrmSearchUsers frm = new FrmSearchUsers();
            frm.SelectUser += Frm_SelectUser;
            frm.ShowDialog();
        }

        private void Frm_SelectUser(object sender, UserSelectedEventArgs e)
        {
            this.IsEdit             = true;
            this.Id                 = e.Id;
            this.inptNombre.Text    = e.Nombre;
            this.inptUsuario.Text   = e.Usuario;
            this.inptPass.Text      = "";
            this.inptPass2.Text     = "";
            this.inptTipo.SelectedItem  = e.Tipo;
            this.cmbEstado.SelectedItem = e.Estado;
        }
        private void ClearForm()
        {
            this.inptNombre.Text = string.Empty;
            this.inptUsuario.Text = "";
            this.inptPass.Text = "";
            this.inptPass2.Text = "";
            this.inptTipo.SelectedIndex = 0;
            this.cmbEstado.SelectedIndex = 0;
        }
    }
}
