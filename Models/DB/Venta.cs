using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DB
{
    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Concepto { get; set; }
        public float Costo { get; set;}

        public int TurnoId { get; set; }
        public Turno Turno { get; set; }

    }
}
