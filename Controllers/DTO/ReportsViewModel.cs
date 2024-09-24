using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.DTO
{
    public class ReportsViewModel
    {
        public string concepto { get; set; }
        public DateTime InitDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UserSolicita { get; set; }
        public float TotalAcumlado { get; set; }
        public float TotalImpresiones { get; set; }
        public float TotalCopias { get; set; }
        public List<VentasViewModel> ventas { get; set; }


    }
}
