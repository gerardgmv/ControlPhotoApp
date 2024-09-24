using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class Singleton
    {
        private static Singleton _instance;
        public int _IdUser = 0;
        public bool _Login = false;
        public bool _InitApp = false;

        public string _NameEnterprise;
        public string _AddressEnterprise;
        public string _PhoneEnterprise;
        public string _LogoEnterprise;


        public string _Terminal = "";
        public bool _Lock = true;
        public string _Printer = "";



        public float _PricePrint = 100.00f;
        public float _PriceCopy = 100.00f;
        public int _minCopies = 1;
        public int _maxCopies = 6;


        public string _UserName;
        public string _User;
        public string _TypeUser;

        public string _directoryCopy = "Galeria";

        //Datos del Turno ID
        public int TurnoId;


        public string _dirCachePersistent = AppContext.BaseDirectory + "\\Cache";
        public long _sizeCachePersistent = 1024;




        public event EventHandler ConfigUpdate;
        public event EventHandler OpenTurno;
        public event EventHandler CloseTurno;
        public event EventHandler LogIn;
        public event EventHandler LogOut;

        public string _Directory = AppDomain.CurrentDomain.BaseDirectory + "images\\";


        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (_instance == null)
                _instance = new Singleton();
            return _instance;
        }

        //Events
        public void OnConfigUpdate(EventArgs e) => this.ConfigUpdate?.Invoke(this, e);
        public void OnLogIn(EventArgs e)  => this.LogIn?.Invoke(this, e);
        public void OnLogOut(EventArgs e) => this.LogOut?.Invoke(this, e);
        public void OnOpenTurno(EventArgs e) => this.OpenTurno?.Invoke(this, e);
        public void OnCloseTurno(EventArgs e) => this.CloseTurno?.Invoke(this, e);
    }
}
