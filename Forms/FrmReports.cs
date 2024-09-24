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
using Controllers.PDF;
using Controllers.DTO;
using PagedList;

namespace ControlPhotoApp.Forms
{
    public partial class FrmReports : Form
    {

        Singleton _singleton;
        ReportsController _controller;
        ReportPDF _pdf;
        ReportsViewModel _report;
        IPagedList<VentasViewModel> _ventasPaginated;
        int page = 1;
        int itemsPerPage = 10;

        public FrmReports()
        {
            _singleton = Singleton.GetInstance();
            _controller = new ReportsController();
            InitializeComponent();

            lblloading.Visible = false;
            progressBar1.Visible = false;
            dateStart.MaxDate = dateEnd.Value;
            dateEnd.MinDate = dateStart.Value;

            dateStart.ValueChanged += OnStartDateChange;
            dateEnd.ValueChanged += OnEndDateChange;
            btnFirst.Enabled = false;
            btnLast.Enabled = false;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
            btnPdf.Enabled = false;
        }

        private void OnStartDateChange(object sender, EventArgs args)
        {
            dateEnd.MinDate = dateStart.Value;
        }

        private void OnEndDateChange (object sender, EventArgs args)
        {
            dateStart.MaxDate = dateEnd.Value;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if ((checkCopies.Checked && checkPrints.Checked) || (!checkPrints.Checked && !checkCopies.Checked))
                _report = _controller.GetReportGeneral(dateStart.Value, dateEnd.Value);
            else
            {
                if (checkCopies.Checked)
                    _report = _controller.GetReportGeneral(dateStart.Value, dateEnd.Value, "COPIADO");
                else
                    _report = _controller.GetReportGeneral(dateStart.Value, dateEnd.Value, "IMPRESIONES");
            }
            lblTotal.Text = string.Format("{0:0,0.00}", _report.TotalAcumlado);
            lbltotalCopias.Text = string.Format("{0:0,0.00}", _report.TotalCopias);
            lbltotalImpresiones.Text = string.Format("{0:0,0.00}", _report.TotalImpresiones);
            page = 1;
            _ventasPaginated = _report.ventas.ToPagedList(page, itemsPerPage);

            lblPaginator.Text = string.Format("Pagina: {0} de {1}", page, _ventasPaginated.PageCount);

            btnNext.Enabled = _ventasPaginated.HasNextPage;
            btnPrev.Enabled = _ventasPaginated.HasPreviousPage;
            
            if (_ventasPaginated.PageCount > 2)
            {
                btnFirst.Enabled = true;
                btnLast.Enabled = true;
            }


            dataGridView1.DataSource = _ventasPaginated.ToList();
            btnPdf.Enabled = true;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (_report == null)
            {
                MessageBox.Show("Genere primero un reporte", "Reportes");
                return;
            }

            folderBrowser.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            DialogResult rs = folderBrowser.ShowDialog();

            if (rs == DialogResult.OK)
            {
                if (!pdfworker.IsBusy)
                {
                    lblloading.Visible = true;
                    progressBar1.Visible = true;
                    pdfworker.RunWorkerAsync();
                }
            }
        }

        private void pdfworker_DoWork(object sender, DoWorkEventArgs e)
        {
            _pdf = new ReportPDF(folderBrowser.SelectedPath + "\\Reporte.pdf", _report, _singleton._LogoEnterprise);
            _pdf.CreatePDF();
        }

        private void pdfworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show("Operacion Cancelada", "PDF Reporte");
            else
                if (e.Error != null)
                    MessageBox.Show("Ocurrio un error al generar el archivo, intente de nuevo", "PDF Reporte");
                else
                    MessageBox.Show("Reporte Generado", "PDF Reporte");
            lblloading.Visible = false;
            progressBar1.Visible = false;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_ventasPaginated.HasPreviousPage)
            {
                page--;
                ShowPage();
                if (page == 1)
                    btnFirst.Enabled = false;
                
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_ventasPaginated.HasNextPage)
            {
                page++;
                ShowPage();
                if (page == _ventasPaginated.PageCount)
                    btnLast.Enabled = false;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            page = _ventasPaginated.PageCount;
            ShowPage();
            btnLast.Enabled = false;
        }

        private void ShowPage()
        {
            _ventasPaginated = _report.ventas.ToPagedList(page, itemsPerPage);
            dataGridView1.DataSource = _ventasPaginated.ToList();

            if (_ventasPaginated.PageCount > 2)
            {
                btnFirst.Enabled = true;
                btnLast.Enabled = true;
            }
            else
            {
                btnFirst.Enabled = false;
                btnLast.Enabled = false;
            }

            btnPrev.Enabled = _ventasPaginated.HasPreviousPage;
            btnNext.Enabled = _ventasPaginated.HasNextPage;
            lblPaginator.Text = string.Format("Pagina: {0} de {1}", page, _ventasPaginated.PageCount);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            page = 1;
            ShowPage();
            btnFirst.Enabled = false;
        }
    }
}
