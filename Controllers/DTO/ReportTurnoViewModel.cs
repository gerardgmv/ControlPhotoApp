using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.DTO
{
    public class ReportTurnoViewModel
    {
        public float TotalVentas { get; set; }
        public float TotalCopias { get; set; }
        public float TotalImpresiones { get; set; }
        public float Inicio { get; set; } // Caja inicial
        public float Total { get; set; }  // totalVentas + caja Inicial
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public List<VentasViewModel> _Ventas { get; set; }
    }
}
