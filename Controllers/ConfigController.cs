using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DB;

namespace Controllers
{
    public class ConfigController
    {
        private Singleton _singleton;
        private string directory = AppDomain.CurrentDomain.BaseDirectory + "images\\";

        public ConfigController()
        {
            _singleton = Singleton.GetInstance();
        }

        public string SaveConfig (string [,] inputs)
        {
            if (_singleton._TypeUser == "ADMINISTRADOR")
            {
                using (var db = new DBAPPContext())
                {
                    for (int i = 0; i<inputs.GetLength(0); i++)
                    {
                        if (inputs[i, 2] == string.Empty)
                            throw new Exception("Todos los campos son necesarios");
                        var config = (from d in db.Config
                                            where d.Categoria == inputs[i,0] && d.Campo == inputs[i,1]
                                            select d).FirstOrDefault();
                        if (config != null)
                        {
                            config.Valor = inputs[i,2];
                            db.Update(config);
                        }
                        else
                        {
                            config = new Config
                            {
                                Categoria = inputs[i,0],
                                Campo = inputs[i,1],
                                Valor = inputs[i,2]
                            };
                            db.Add(config);
                        }
                    }

                    db.SaveChanges();
                }
                _singleton.OnConfigUpdate(EventArgs.Empty);
                return "Configuración Guardada";
            }
            else
                throw new Exception("No tienes los permisos para realizar modificaciones en este modulo");
        }

        public string SaveImage(string sourcepath)
        {
            if (_singleton._TypeUser == "ADMINISTRADOR")
            {
                string name = Path.GetFileName(sourcepath);
                string targetpath = directory + name;
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);
                File.Copy(sourcepath, targetpath, true);
                return targetpath;
            }
            throw new Exception("No tienes permisos para realizar esta operación");
        }

        public string GetConfig(string [] inputs)
        {
            if (inputs.Length == 2)
            {
                using(var db= new DBAPPContext())
                {
                    
                    var config = (from d in db.Config
                                where d.Categoria == inputs[0] && d.Campo == inputs[1]
                                select d).FirstOrDefault();
                    if (config != null)
                        return config.Valor;
                    return "No Found";
                }
            }else
                return "Fail, Missing Data";
        }
        

    
    }
}
