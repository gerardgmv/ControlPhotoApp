using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DB
{
    public class Turno
    {
        public int TurnoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public float Inicio { get; set; }
        public float Termino { get; set; }
        public string Estado { get; set; }

        public int UserId { get; set; }
        public User usuario { get; set; }
        public List<Venta> Ventas { get; set; }
    }
}
