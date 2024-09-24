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
using Controllers.DTO;
using Controllers.PDF;


namespace ControlPhotoApp.Forms
{
    public partial class FrmCorteCaja : Form
    {
        private Singleton _singleton;
        private TurnoController _turnoController;
        private ReportTurnoViewModel reportTurno;
        public event EventHandler OnLogOut;

        public bool closeTurno = false;

        public FrmCorteCaja()
        {
            _singleton = Singleton.GetInstance();
            _turnoController = new TurnoController();
            InitializeComponent();
            lblLoadFile.Visible = false;
            barra.Visible = false;
        }

        private void FrmCorteCaja_Load(object sender, EventArgs e)
        {
            reportTurno = _turnoController.GetCorte();
            if (reportTurno != null)
            {
                reportTurno.Total = reportTurno.Inicio + reportTurno.TotalVentas;

                lblFechaInicio.Text = reportTurno.FechaInicio.ToLongDateString();
                lblFechaCierre.Text = reportTurno.FechaTermino.ToLongDateString();

                lblCaja.Text = $" $ {reportTurno.Inicio}";
                lblTotalCopias.Text = $" $ {reportTurno.TotalCopias}";
                lblImpresiones.Text = $" $ {reportTurno.TotalImpresiones}";
                lblVentasNetas.Text = $" $ {reportTurno.TotalVentas}";
                lblTotal.Text = $" $ {reportTurno.Total}";
                gridDetailCorte.DataSource = reportTurno._Ventas;
                gridDetailCorte.Columns[0].Visible = false;
            }
            else
                MessageBox.Show("No se encontro un turno abierto");
        }

        private void btnInitTurno_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rs = folderDialog.ShowDialog();
                if (rs == DialogResult.OK) 
                {
                    if (!pdfWorker.IsBusy) 
                    {
                        closeTurno = true;
                        lblLoadFile.Text = "Cerrando Turno.. Espere..!";
                        lblLoadFile.Visible = true;
                        barra.Visible = true;
                        pdfWorker.RunWorkerAsync();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un problema, Intente de nuevo.", "Warning");
                        this.Close();
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ocurrio un error al guardar los datos, contacte a soporte tecnico\n{ex.Message}", "Turnos");
            }

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            DialogResult rs = folderDialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                pdfWorker.RunWorkerAsync();
                lblLoadFile.Text = "Generarndo Archivo... Espere..!";
                lblLoadFile.Visible = true;
                barra.Visible = true;
            }
        }

        private void pdfWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (closeTurno)
                    _turnoController.CloseTurno(folderDialog.SelectedPath, reportTurno);
                CortePdf pdf = new CortePdf(folderDialog.SelectedPath + "\\Corte.pdf", reportTurno, _singleton._LogoEnterprise);
                pdf.CreatePDF();
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ocurrio un Error: {ex.Message}", "Error");
            }
        }

        private void pdfWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblLoadFile.Visible = false;
            barra.Visible = false;
            if (closeTurno)
            {
                MessageBox.Show($"Turno Finalizado", "Turnos");
                _singleton._IdUser = 0;
                _singleton._Login = false;
                _singleton.OnLogOut(EventArgs.Empty);
            }
            else    
                MessageBox.Show("Corte Guardado", "PDF");
        }
    }
}
