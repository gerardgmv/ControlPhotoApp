using System;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using Models.DB;
using System.Collections.Generic;

namespace Controllers
{
    public class MainController
    {
        private Singleton _singleton;    
        public MainController() 
        {
            _singleton = Singleton.GetInstance();
        }

        public void checkTurno()
        {
            using var db = new DBAPPContext();
            var check = db.Turno.Where(row => row.UserId == _singleton._IdUser && row.Estado == "OPEN").FirstOrDefault();
            if (check != null)
                _singleton.TurnoId = check.TurnoId;
        }

        public void  InitConfig ()
        {
            using (var db = new DBAPPContext ())
            {
                List<Config> configs = db.Config.ToList();
                foreach (var config in configs)
                {
                    switch (config.Categoria + config.Campo)
                    {
                        case "EMPRESARS":
                            _singleton._NameEnterprise = config.Valor;
                            break;
                        case "EMPRESADIR":
                            _singleton._AddressEnterprise = config.Valor;
                            break;
                        case "EMPRESATEL":
                            _singleton._PhoneEnterprise = config.Valor;
                            break;
                        case "EMPRESALOGO":
                            _singleton._LogoEnterprise = config.Valor;
                            break;
                        case "VENTASPRECIO_COPIAS":
                            try {
                                _singleton._PriceCopy = float.Parse(config.Valor);
                            } catch (Exception) 
                            {
                                _singleton._PriceCopy = 150;
                            }
                            break;
                        case "VENTASPRECIO_IMPRESIONES":
                            try {
                                _singleton._PricePrint = float.Parse(config.Valor);
                            }
                            catch (Exception)
                            {
                                _singleton._PricePrint = 100;
                            }
                            break;
                        case "VENTASMAX_COPIAS":
                            try
                            {
                                _singleton._maxCopies = int.Parse(config.Valor);
                            }catch (Exception)
                            {
                                _singleton._maxCopies = 6;
                            }
                            break;

                        case "VENTASMIN_COPIAS":
                            try 
                            {
                                _singleton._minCopies = int.Parse(config.Valor);
                            }catch (Exception)
                            {
                                _singleton._minCopies = 1;

                            }
                            break;
                        case "SISTEMATERMINAL":
                            _singleton._Terminal = config.Valor;
                            break;

                        case "SISTEMAIMPRESORA":
                            _singleton._Printer = config.Valor;
                            break;
                        case "SISTEMABLOQUEO":
                            try
                            {
                                _singleton._Lock = bool.Parse(config.Valor);
                            }catch (Exception)
                            {
                                _singleton._Lock = false; // cambiar a true al final
                            }
                            break;
                    }
                }
            }
        }

        public void SetMaxAndMin()
        {
            using (var db = new DBAPPContext())
            {
                try
                {
                        var configMax = (from d in db.Config
                                         where d.Categoria == "VENTAS" && d.Campo == "MAX_COPIES"
                                         select d).First();
                        _singleton._maxCopies = int.Parse(configMax.Valor);
                }
                catch (Exception)
                {
                    _singleton._maxCopies = 6;
                }

                try
                {
                    var configMin = (from d in db.Config
                                     where d.Categoria == "VENTAS" && d.Campo == "MIN_COPIES"
                                     select d).First();
                    _singleton._minCopies = int.Parse(configMin.Valor);
                }
                catch (Exception)
                {
                    _singleton._minCopies = 1;
                }
            }

        }

        public void SetDataEmpresa()
        {
            using(var db = new DBAPPContext())
            {
                try
                {
                    var configNombre = (from d in db.Config
                                    where d.Categoria == "EMPRESA" && d.Campo == "RS"
                                    select d).First();
                    _singleton._NameEnterprise = configNombre.Valor;
                }catch (Exception)
                {
                    _singleton._NameEnterprise = "";
                }

                try
                {
                    var configAddress = (from d in db.Config
                                         where d.Categoria == "EMPRESA" && d.Campo == "DIR"
                                         select d).First();
                    _singleton._AddressEnterprise = configAddress.Valor;
                }
                catch (Exception)
                {
                    _singleton._AddressEnterprise = "";
                }

                try
                {
                    var configPhone = (from d in db.Config
                                       where d.Categoria == "EMPRESA" && d.Campo == "TEL"
                                       select d).First();
                    _singleton._PhoneEnterprise = configPhone.Valor;
                }catch (Exception)
                {
                    _singleton._PhoneEnterprise = "";
                }
            }
        }


        public bool CheckDB()
        {
            using (var db = new DBAPPContext ()) 
            {
                try
                {
                    var ban = db.Config.FirstOrDefault();
                    if (ban == null)
                        return false;
                    return true;
                } catch (Exception) 
                {
                    return false;
                }
            }
        }

        public async Task<bool> InitApp ()
        {
            using (var dbcontext = new DBAPPContext())
            {
                bool r =  await dbcontext.Database.EnsureCreatedAsync();
                if (r) 
                { 
                    var usr = new User
                    {
                        Nombre = "SuperAdmin",
                        Usuario = "admin",
                        Password = Encrypt.GetSHA256("gerard123"),
                        Tipo = "ADMINISTRADOR",
                        Estado = "ACTIVO"                    
                    };

                    var usrblock = new User
                    {
                        Nombre = "Desbloqueo",
                        Usuario = "desbloqueo",
                        Password = Encrypt.GetSHA256("$administrador$"),
                        Tipo = "ESPECIAL",
                        Estado = "ACTIVO",
                    };

                    var usrOperador = new User()
                    {
                        Nombre = "Operador1",
                        Usuario = "operador",
                        Password = Encrypt.GetSHA256("operador"),
                        Tipo = "OPERADOR",
                        Estado = "ACTIVO"
                    };

                    dbcontext.Add(usr);
                    dbcontext.Add(usrblock);
                    dbcontext.Add(usrOperador);


                    Config configCopias = new Config
                    {
                        Categoria = "VENTAS",
                        Campo = "PRECIO_COPIAS",
                        Valor = "150",
                    };
                    dbcontext.Add(configCopias);

                    Config configPrints = new Config
                    {
                        Categoria = "VENTAS",
                        Campo = "PRECIO_IMPRESIONES",
                        Valor = "100"
                    };
                    dbcontext.Add(configPrints);
                    Config configRS = new Config
                    {
                        Categoria = "EMPRESA",
                        Campo = "RS",
                        Valor = "CENTRO ECOTURISTICO EL CHIFLON"
                    };
                    dbcontext.Add(configRS);
                    Config configDir = new Config
                    {
                        Categoria = "EMPRESA",
                        Campo = "DIR",
                        Valor = "TZIMOL CHIAPAS"
                    };
                    dbcontext.Add(configDir);
                    Config configTel = new Config
                    {
                        Categoria = "EMPRESA",
                        Campo = "TEL",
                        Valor = "963 271 5162",
                    };
                    dbcontext.Add(configTel);

                    Config configLogo = new Config 
                    {
                        Categoria = "EMPRESA",
                        Campo = "LOGO",
                        Valor = _singleton._Directory + "default.png"
                    };
                    dbcontext.Add(configLogo);

                    Config configBlock = new Config 
                    {
                        Categoria = "SISTEMA",
                        Campo = "BLOQUEO",
                        Valor = "true"
                    };
                    dbcontext.Add(configBlock);

                    Config configPrintToPrint = new Config { 
                        Categoria = "SISTEMA",
                        Campo = "IMPRESORA",
                        Valor = "DEFAULT" // TOMARA LA IMPRESORA PREDETERMINADA EN EL SISTEMA
                    };
                    dbcontext.Add(configPrintToPrint);

                    Config configMaxCopies = new Config
                    {
                        Categoria = "VENTAS",
                        Campo = "MAX_COPIES",
                        Valor = "6"
                    };
                    dbcontext.Add(configMaxCopies);

                    Config configMinCopies = new Config
                    {
                        Categoria = "VENTAS",
                        Campo = "MIN_COPIAS",
                        Valor = "1"
                    };
                    dbcontext.Add(configMinCopies);

                    Config configTerminalname = new Config
                    {
                        Categoria = "SISTEMA",
                        Campo = "TERMINAL",
                        Valor = "TERMINAL 1"
                    };
                    dbcontext.Add(configTerminalname);

                    int r2 = await dbcontext.SaveChangesAsync();

                    if (r2 == 0)
                        return false;
                    return true;
                }else
                    return r;
            }
        }

        public void DeleteImage(string oldImg)
        {
            if (oldImg != string.Empty)
                File.Delete(oldImg);            
        }
    }


}
