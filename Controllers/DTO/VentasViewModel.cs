using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.DTO
{
    public class VentasViewModel
    {
        public string Usuario { get; set; }
        public string Concepto { get; set; }
        public float Costo { get; set; }
        public DateTime Fecha { get; set; }

    }
}
