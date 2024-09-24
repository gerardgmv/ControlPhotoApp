using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DB;
using Controllers.DTO;

namespace Controllers.PDF
{
    public class ReportsController
    {
        Singleton _singleton;
        public ReportsController()
        {
            _singleton = Singleton.GetInstance();
        }

        public ReportsViewModel GetReportGeneral(DateTime init, DateTime end, string concepto = "") 
        {
            using (var db = new DBAPPContext ())
            {
                List<VentasViewModel> ventas;
                if (_singleton._TypeUser == "ADMINISTRADOR") 
                { 
                    if (concepto == string.Empty)
                    {
                        ventas = db.Venta
                        .Where(d => d.Fecha >= init.Date && d.Fecha <= end.Date.AddHours(23).AddMinutes(59).AddSeconds(59))
                        .OrderByDescending(d=> d.Fecha)
                        .Select(d => new VentasViewModel() 
                        { 
                            Usuario = db.User.Where(u=> u.UserId == d.Turno.UserId).Select(u=> u.Nombre).FirstOrDefault(),
                            Fecha = d.Fecha,
                            Concepto= d.Concepto,
                            Costo = d.Costo
                        }).ToList();
                    }
                    else
                    {
                        ventas = db.Venta
                        .Where(d => d.Fecha >= init.Date && d.Fecha <= end.Date.AddHours(23).AddMinutes(59).AddSeconds(59) && d.Concepto == concepto)
                        .OrderByDescending(d => d.Fecha)
                        .Select(d => new VentasViewModel()
                        {
                            Usuario = db.User.Where(u => u.UserId == d.Turno.UserId)
                            .Select(u => u.Nombre).FirstOrDefault(),
                            Fecha = d.Fecha,
                            Concepto = d.Concepto,
                            Costo = d.Costo
                        }).ToList();
                    }
                        
                }
                else
                {
                    if (concepto == string.Empty) 
                    { 
                        ventas = db.Venta
                        .Where(d => d.Fecha >= init.Date && d.Fecha <= end.Date.AddHours(23).AddMinutes(59).AddSeconds(59) && d.Turno.UserId == _singleton._IdUser )
                        .OrderByDescending(d => d.Fecha)
                        .Select(d => new VentasViewModel()
                        {
                            Usuario = _singleton._UserName,
                            Fecha = d.Fecha,
                            Concepto = d.Concepto,
                            Costo = d.Costo
                        }).ToList();
                    }
                    else
                    {
                        ventas = db.Venta
                        .Where(d => d.Fecha >= init.Date && d.Fecha <= end.Date.AddHours(23).AddMinutes(59).AddSeconds(59) && d.Concepto == concepto)
                        .OrderBy(d => d.Fecha)
                        .Select(d => new VentasViewModel()
                        {
                            Usuario = db.User.Where(u => u.UserId == d.Turno.UserId).Select(u => u.Nombre).FirstOrDefault(),
                            Fecha = d.Fecha,
                            Concepto = d.Concepto,
                            Costo = d.Costo
                        }).ToList();
                    }
                }


                ReportsViewModel report = new ReportsViewModel()
                {
                    concepto = concepto,
                    InitDate = init,
                    EndDate = end,
                    TotalAcumlado = ventas.Sum(v => v.Costo),
                    TotalCopias = ventas.Where(v => v.Concepto == "COPIADO").Sum(v => v.Costo),
                    TotalImpresiones = ventas.Where(v => v.Concepto == "IMPRESIONES").Sum(v => v.Costo),
                    ventas = ventas,
                    UserSolicita = _singleton._UserName                   
                };
                return report;
            }
        }


    }
}
