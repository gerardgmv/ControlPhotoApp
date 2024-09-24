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
    public partial class FrmSearchUsers : Form
    {
        public event EventHandler<UserSelectedEventArgs> SelectUser;

        UsuarioController _controller;
        public FrmSearchUsers()
        {
            
            _controller = new UsuarioController();
            InitializeComponent();
            ListUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FrmSearchUsers_Load(object sender, EventArgs e)
        {
            ListUsers.DataSource = _controller.Search("");
            ListUsers.Columns[3].Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ListUsers.SelectedRows.Count == 0)
                MessageBox.Show("Seleccion al menos a un Usuario");

            DataGridViewRow row =  ListUsers.SelectedRows[0];
            UserSelectedEventArgs args = new UserSelectedEventArgs {
                Id = (int) row.Cells[0].Value,
                Nombre = row.Cells[1].Value.ToString(),
                Usuario = row.Cells[2].Value.ToString(),
                Tipo = row.Cells[4].Value.ToString(),
                Estado = row.Cells[5].Value.ToString()
            };
            OnSelectUser(args);
            this.Close();
        }

        protected virtual void OnSelectUser(UserSelectedEventArgs e)
        {
            EventHandler<UserSelectedEventArgs> rSelectUser = SelectUser;
            if (rSelectUser != null)
                rSelectUser(this, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (inptSearch.Text == string.Empty)
            {
                MessageBox.Show("Ingresa un usario a buscar", "Usuarios");
                return;
            }
            ListUsers.DataSource = _controller.Search(inptSearch.Text);
            ListUsers.Columns[3].Visible = false;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (ListUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccion al menos a un Usuario");
            }

            DialogResult rs = MessageBox.Show("Estas Seguro de Eliminar el Usuario", "Usuarios", MessageBoxButtons.OKCancel);
            if (rs == DialogResult.OK)
            {
                int IdDel = (int) ListUsers.SelectedRows[0].Cells[0].Value;
                int res = await _controller.Delete(IdDel);
                if (res > 0)
                {
                    MessageBox.Show("Registro Eliminado", "Usuarios");
                    ListUsers.DataSource = _controller.Search("");
                    ListUsers.Columns[3].Visible = false;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ListUsers.DataSource = _controller.Search("");
            ListUsers.Columns[3].Visible = false;
        }
    }

    public class UserSelectedEventArgs : EventArgs
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }

    }
}
