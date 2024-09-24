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
    public partial class FrmTerminal : Form
    {
        private ConfigController _controller;


        public FrmTerminal()
        {
            _controller = new ConfigController();
            InitializeComponent();
        }

        private void FrmPrecios_Load(object sender, EventArgs e)
        {
            LoadPrinters();
            string priceCopies = _controller.GetConfig(new string[] { "VENTAS", "PRECIO_COPIAS" });
            string pricePrints = _controller.GetConfig(new string[] { "VENTAS", "PRECIO_IMPRESIONES"});
            string maxCopies = _controller.GetConfig(new string[] {"VENTAS", "MAX_COPIAS"});
            string minCopies = _controller.GetConfig(new string[] { "VENTAS", "MIN_COPIAS"});
            string terminal = _controller.GetConfig(new string[] { "SISTEMA", "TERMINAL"});
            string impresora = _controller.GetConfig(new string[] { "SISTEMA", "IMPRESORA"});
            string strBloqueo = _controller.GetConfig(new string[] { "SISTEMA", "BLOQUEO"});


            if (priceCopies == "No Found" || priceCopies == "Fail, Missing Data")
                inptPriceCopies.Text = "150.00";
            else
                inptPriceCopies.Text = priceCopies;
            if (pricePrints == "No Found" || pricePrints == "Fail, Missing Data")
                inptPricePrint.Text = "100.00";
            else
                inptPricePrint.Text = pricePrints;

            if (maxCopies == "No Found" || maxCopies == "Fail, Missing Data")
                inptMaxCopies.Text = "6";
            else
                inptMaxCopies.Text = maxCopies;
            if (minCopies == "No Found" || minCopies == "Fail, Missing Data")
                inptMinCopies.Text = "1";
            else
                inptMinCopies.Text = minCopies;
            if (terminal == "No Found" || terminal == "Fail, Missing Data")
                inptTerminal.Text = "";
            else
                inptTerminal.Text = terminal;
            if (strBloqueo == "No Found" || strBloqueo == "Fail, Missing Data" || strBloqueo == "0")
                checkLock.Checked = false;
            else
                checkLock.Checked = true;
            if (impresora == "No Found" || impresora == "Fail, Missing Data")
                cmbPrinters.SelectedIndex = 0;
            else
                cmbPrinters.SelectedItem = impresora;
            
        }

        private void LoadPrinters ()
        {
            List<string> lstprinters = new List<string>();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                lstprinters.Add(printer);
            }
            cmbPrinters.DataSource = lstprinters;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string[,] inputs = new string[7,3]
            {
                { "VENTAS", "PRECIO_COPIAS", inptPriceCopies.Text },
                { "VENTAS", "PRECIO_IMPRESIONES", inptPricePrint.Text },
                { "VENTAS", "MAX_COPIAS", inptMaxCopies.Text },
                { "VENTAS", "MIN_COPIAS", inptMinCopies.Text },
                { "SISTEMA", "TERMINAL", inptTerminal.Text },
                { "SISTEMA", "IMPRESORA", cmbPrinters.SelectedItem.ToString() },
                { "SISTEMA", "BLOQUEO", checkLock.Checked.ToString() }
            };
            try
            {
                MessageBox.Show(_controller.SaveConfig(inputs), "Configuracion de Precios");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Configuración de Precios");
            }
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            LoadPrinters();
        }
    }
}
