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
    public partial class FrmTurno : Form
    {
        private Singleton _singleton;
        private TurnoController _controller;
        public FrmTurno()
        {
            _singleton = Singleton.GetInstance();
            _controller = new TurnoController();
            InitializeComponent();
            inptCant.Text = "0";
        }

        private void btnInitTurno_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            if (inptCant.Text == string.Empty)
            {
                lblStatus.Text = "Ingrese una cantiadad a para iniciar el turno";
                return;
            }

            try
            {
                _controller.OpenTurno(inptCant.Text);
                _singleton.OnOpenTurno(EventArgs.Empty);
                this.Close();
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }


        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }

        private void FrmTurno_Load(object sender, EventArgs e)
        {
            timerStatus.Enabled = true;
        }
    }
}
