using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using ControlPhotoApp.Forms;
using Controllers;
using ControlPhotoApp.Forms.Config;

namespace ControlPhotoApp
{
    public partial class FrmMain : Form
    {

        private Form currentForm;
        private IconButton currentButton;
        private IconButton currentSubButton;


        private FrmStore _FrmStore;



        private Singleton _singleton;
        private MainController _controller;
        
                    
        private struct RGBColors 
        {
            public static Color primaryColor = Color.FromArgb(7, 18, 36);
            public static Color secundaryColor = Color.FromArgb(2, 8, 19);
            public static Color iconPrimary = Color.FromArgb(76, 201, 240);
            public static Color iconSelected = Color.DarkSalmon;
            public static Color textDefault = Color.Gainsboro;
        }

        public FrmMain()
        {
            _singleton = Singleton.GetInstance();
            _controller = new MainController();
            _controller.InitConfig();
            InitializeComponent();
            this.Text = "";
            this.TopMost = _singleton._Lock;
        }


        private void InitEventsGlobals()
        {
            _singleton.ConfigUpdate += OnConfigUpdateEvent;
            _singleton.LogIn += _singleton_LogIn;
            _singleton.LogOut += _singleton_LogOut;
        }

        private void DisableBtnsMenu()
        {
            btnStore.Enabled = false;
            btnReports.Enabled = false;
            btnConfig.Enabled = false;
            btnCloseTurno.Enabled = false;
            btnCloseSession.Enabled = false;
        }

        private void EnableBtnsMenu ()
        {
            btnStore.Enabled = true;
            btnReports.Enabled = true;
            btnCloseTurno.Enabled = true;
            btnCloseSession.Enabled = true;
            btnConfig.Enabled = true;
            if (_singleton._TypeUser == "ADMINISTRADOR")
                btnUsuarios.Enabled = true;
            else
                btnUsuarios.Enabled = false;
        }

        //MENU BUTTONS
        private void btnStore_Click(object sender, EventArgs e)
        {
            if (_FrmStore == null)
                _FrmStore = new FrmStore();

            EnableButton(sender);
            OpenChildForm(_FrmStore);
            HideSubmenu();
            DisableSubButton();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            EnableButton(sender);
            HideSubmenu();
            DisableSubButton();
            OpenChildForm(new FrmReports());
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            EnableButton(sender);
            subMenuSystem.Visible = !this.subMenuSystem.Visible;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            EnableButton(sender);
            if (this.subMenuSystem.Visible)
                this.subMenuSystem.Visible = false;
        }

        //SUBBUTTONS
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            EnableSubButton(sender);
            OpenChildForm(new FrmUsers());
        }

        private void btnEnterprise_Click(object sender, EventArgs e)
        {
            EnableSubButton(sender);
            FrmDataEnterprise frm = new FrmDataEnterprise ();
            OpenChildForm(frm);
        }

        private void btnTerminal_Click(object sender, EventArgs e)
        {
            EnableSubButton(sender);
            OpenChildForm(new FrmTerminal());
        }

        private void btnDataBase_Click(object sender, EventArgs e)
        {
            EnableSubButton(sender);
            OpenChildForm(new FrmMaintenance());
        }

        private void btnServidor_Click(object sender, EventArgs e)
        {
            EnableSubButton(sender);
            OpenChildForm(new Servidor ());
        }

        //BTN PARA SALIR

        private void btnCloseSession_Click(object sender, EventArgs e)
        {
            String msg = "";
            if (_singleton.TurnoId != 0)
                msg = "¿Desea cerrar su sesion y dejar su Turno abierto, para seguir despues?";
            else
                msg = "¿Desea cerrar su sesion?";
            DialogResult rs = MessageBox.Show(msg, "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (rs == DialogResult.OK)
            {
                _singleton._IdUser = 0;
                _singleton._Login = false;
                _singleton.TurnoId = 0;
                _singleton.OnLogOut(EventArgs.Empty);
            }
        }


        private void SubBtnUnLock_Click(object sender, EventArgs e)
        {
            FrmUnblock _FrmUnlock = new FrmUnblock();
            _FrmUnlock.OnCheckPass += OnUnlock;
            _FrmUnlock.ShowDialog(this);
        }

        private void btnCloseTurno_Click(object sender, EventArgs e)
        {

            FrmCorteCaja _frm = new FrmCorteCaja();
            OpenChildForm(_frm);
            EnableButton(sender);
        }

        private void SubbtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Apagar el Equipo?", _singleton._NameEnterprise, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("cmd", "/c shutdown -s -t 5");
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = info;
                proc.Start();
                //this.Close();
                Application.Exit();
            }
        }

        //Function to Forms, Menu and Buttons

        private void InitStore()
        {
            _FrmStore = new FrmStore();
            OpenChildForm(_FrmStore);
            EnableButton(btnStore);
        }

        private void OpenChildForm(Form childFrm)
        {
            if (currentForm != null && currentForm != childFrm)
                    panelContainer.Controls.Remove(currentForm);

            if (currentForm != childFrm)
            {
                childFrm.TopLevel = false;
                childFrm.FormBorderStyle = FormBorderStyle.None;
                childFrm.Dock = DockStyle.Fill;
                currentForm = childFrm;
                panelContainer.Controls.Add(currentForm);
                panelContainer.Tag = childFrm;
                currentLabel.Text = childFrm.Text;
                currentForm.BringToFront();
                currentForm.Show();
            }
        }
        private void HideSubmenu()
        {
            this.subMenuSystem.Visible = false;
        }
        private void EnableButton(object sender)
        {
            if (sender != null)
            {
                DisableButton();
                currentButton = (IconButton) sender;
                currentButton.BackColor = RGBColors.primaryColor;
                currentButton.IconColor = RGBColors.iconSelected;
                currentButton.Padding = new Padding(20, 0, 10, 0);
                currentIcon.IconChar = currentButton.IconChar;
                currentIcon.IconColor = RGBColors.iconSelected;
            }
        }
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = RGBColors.secundaryColor;
                currentButton.IconColor = RGBColors.iconPrimary;
                currentButton.Padding = new Padding(10, 0, 20, 0);
            }
        }
        private void EnableSubButton(object sender)
        {
            if (sender != null)
            {
                DisableSubButton();
                currentSubButton = (IconButton)sender;
                currentSubButton.BackColor = Color.DarkSlateBlue;
                currentSubButton.IconColor = RGBColors.iconSelected;
                currentIcon.IconChar = currentButton.IconChar;
                currentIcon.IconColor = RGBColors.iconSelected;
            }

        }
        private void DisableSubButton()
        {
            if (currentSubButton != null)
            {
                currentSubButton.BackColor = RGBColors.primaryColor;
                currentSubButton.IconColor = RGBColors.iconPrimary;
                currentIcon.IconChar = currentButton.IconChar;
                currentIcon.IconColor = RGBColors.iconSelected;
            }
        }

        //SetInfo

        private void SetTitles() 
        {
            lblPriceCopies.Text = _singleton._PriceCopy.ToString();
            lblPricePrints.Text = _singleton._PricePrint.ToString();
            lblTerminal.Text = _singleton._Terminal;
            lblEmpresa.Text = _singleton._NameEnterprise;
        }

        private Image SetLogo() 
        {
            try
            {
               return Image.FromFile(_singleton._LogoEnterprise);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo cargar el logotipo\n{ex.Message}", _singleton._NameEnterprise);
                return global::ControlPhotoApp.Properties.Resources.logo_generic;
            }
        }

        private void SetUserLabel(string usuario, string tipo) 
        {
            lblUsuario.Text = usuario;
            lblUserType.Text = tipo;
        }

        //Events

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DisableBtnsMenu();
            InitEventsGlobals();
            ClockTimer.Enabled = true;
            this.HideSubmenu();

            this.Text = String.Empty;
            this.ControlBox = false;

            if (!backWorker.IsBusy)
                backWorker.RunWorkerAsync();
        }


        private async void backWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var dbcheck = _controller.CheckDB();
            if (!dbcheck)
                await _controller.InitApp();
            _controller.InitConfig();
            this.Logo.Image = SetLogo();
        }

        private void backWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pBar.Hide();
            lblLoading.Hide();
            FrmLogin frmLogin = new FrmLogin();
            OpenChildForm(frmLogin);
            SetUserLabel("", "");
            SetTitles();
        }


        private void _singleton_LogOut(object sender, EventArgs e)
        {
            _FrmStore.Dispose();
            FrmLogin frmLogin = new FrmLogin();
            DisableBtnsMenu();
            SetUserLabel("", "");
            this.HideSubmenu();
            OpenChildForm(frmLogin);
        }

        private void _singleton_LogIn(object sender, EventArgs e)
        {
            _controller.checkTurno();
            EnableBtnsMenu();
            InitStore();
            SetUserLabel(_singleton._UserName, _singleton._TypeUser.ToUpper());
        }

        private void OnConfigUpdateEvent(object sender, EventArgs e)
        {
            string nowlogo = _singleton._LogoEnterprise;
            _controller.InitConfig();
            if (nowlogo != _singleton._LogoEnterprise)
                this.Logo.Image = SetLogo();
            SetTitles();
        }

        private void OnUnlock(object sender, EventArgs e) 
        {
            Application.Exit();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            if (e.KeyCode.Equals(Keys.LWin))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
