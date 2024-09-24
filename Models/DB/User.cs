using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DB
{
    public class User
    {
        public int UserId { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }

        public List<Turno> Turnos { get; set; }


    }
}
