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
    public partial class FrmMaintenance : Form
    {
        private MainController oMainController;
        public FrmMaintenance()
        {
            oMainController = new MainController();
            InitializeComponent();
            btnInitDB.Enabled = false;
        }

        private void btnInitDB_Click(object sender, EventArgs e)
        {      

        }

        private void FrmMaintenance_Load(object sender, EventArgs e)
        {
            var resp = oMainController.CheckDB();
            if (!resp)
            {
                btnInitDB.Enabled = true;
            }
        }
    }
}
