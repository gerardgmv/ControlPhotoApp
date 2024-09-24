using Models;
using Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
   public class UsuarioController
    {
        private Singleton _singleton;

        public UsuarioController() 
        {
            _singleton = Singleton.GetInstance();
        }

        public bool Login(string Usuario, string Pass)
        {
            Pass = Encrypt.GetSHA256(Pass);     
            using (var db = new DBAPPContext ()) 
            {
                try
                {
                    var usr = (from d in db.User
                               where d.Usuario == Usuario && d.Password == Pass
                               select d).First();
                    _singleton._IdUser = usr.UserId;
                    _singleton._User = usr.Usuario;
                    _singleton._UserName = usr.Nombre;
                    _singleton._TypeUser = usr.Tipo;
                    _singleton._Login = true;
                    return true;
                }
                catch (ArgumentNullException ae)
                {
                    return false;
                }
                catch (InvalidOperationException ie) 
                {
                    return false;
                }
            }
        }

        public bool Logout() 
        {
            _singleton._Login = false;
            _singleton._IdUser = 0;
            return true;
        }

        public bool Unlock(string pass) 
        {
            pass = Encrypt.GetSHA256(pass);
            using var db = new DBAPPContext();
                try
                {
                    var unlock = (from d in db.User
                             where d.Nombre == "Desbloqueo" && d.Password == pass
                             select d).First();
                    return true;
                }
                catch (ArgumentException ae)
                {
                    return false;
                }
                catch (InvalidOperationException ioe)
                {
                    return false;
                }
            

        }
        public async Task<string> Register(string[] inputs)
        {
            if (inputs.Length == 6)
            {
                foreach (var value in inputs)
                {
                    if (value == string.Empty)
                        throw new ArgumentException("Todos los Campos son Necesarios");
                }

                if (inputs[2] != inputs[3])
                    throw new ArgumentException("Las Contraseñas no coinciden");
                using (var db = new DBAPPContext())
                {

                    var usrcheck = db.User.Where(d => d.Usuario == inputs[1]).FirstOrDefault();

                    if (usrcheck != null)
                        throw new Exception("El Usuario ya se encuentra registrado en la Base de Datos");

                    User usr = new User
                    {
                        Nombre = inputs[0],
                        Usuario = inputs[1],
                        Password = Encrypt.GetSHA256(inputs[2]),
                        Tipo = inputs[4],
                        Estado = inputs[5]
                    };
                    db.Add(usr);
                    int response = await db.SaveChangesAsync();
                    if (response == -1)
                        throw new Exception("El Registro del Nuevo Usuario no pudo ser completado, revise el estado de la base de datos");
                    else
                        return "Usuarios Registrado";
                }
            }
            else
                throw new ArgumentException("Los Datos enviados no corresponden, intente de nuevo");
        }
        public async Task<string> Update(string[] inputs, int ID)
        {
            if (inputs.Length == 6)
            {
                inputs[2] = inputs[2] == string.Empty ? "12345" : inputs[2];
                inputs[3] = inputs[3] == string.Empty ? "12345" : inputs[3];

                foreach (var inpt in inputs)
                {
                    if (inpt == string.Empty)
                    {
                        throw new Exception("Todos los Campos son Necesarios");
                    }
                }

                if (inputs[2] != inputs[3])
                    throw new ArgumentException("Las Contraseñas no coinciden");

                using (var db = new DBAPPContext())
                {
                    var usrcheck = db.User.Where(d => d.Usuario == inputs[1] && d.UserId != ID).FirstOrDefault();
                    if (usrcheck != null)
                        throw new Exception("El Usuario ya se encuentra registrado en la base de Datos");

                    var usr = await db.User.FindAsync(ID);
                    usr.Nombre = inputs[0];
                    usr.Usuario = inputs[1];

                    if (inputs[2] != "12345")
                        usr.Password = Encrypt.GetSHA256(inputs[2]);
                    usr.Tipo = inputs[4];
                    usr.Estado = inputs[5];

                    db.Update(usr);
                    if (await db.SaveChangesAsync() <= 0)
                        throw new Exception("La Actualización del Usuario no pudo ser completado, revise el estado de la base de datos");
                    else
                        return "Usuario Actualizado";

                }
            }
            else
                throw new Exception("Los Datos enviados no corresponden, intente de nuevo");
        }

        public async Task<int> Delete(int ID)
        {
            using (var db = new DBAPPContext())
            {
                var usr = await db.User.FindAsync(ID);
                db.Remove(usr);
                return await db.SaveChangesAsync();
            }
        }


        public List<User> Search(string value)
        {
            using (var db = new DBAPPContext())
            {
                var users = from d in db.User
                            where (d.UserId != 1 && d.UserId!= 2) && (d.Nombre.Contains(value) || d.Usuario.Contains(value))
                            select d;
                return users.ToList();
            }
        }

        public async Task<User> Show(int ID) 
        {
            using (var db= new DBAPPContext()) 
            {
                return await db.User.FindAsync(ID);
            }
        }

    }
}
