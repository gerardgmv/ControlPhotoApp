using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DB;
using Controllers.DTO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel.Geom;
using iText.Layout.Element;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
    public class TurnoController
    {
        private Singleton _singleton;

        public TurnoController()
        {
            _singleton = Singleton.GetInstance();
        }

        public ReportTurnoViewModel  GetCorte ()
        {
            using (var db = new DBAPPContext ())
            {
                var turno = db.Turno
                    .Where(t=> t.TurnoId ==_singleton.TurnoId && t.Estado == "OPEN").FirstOrDefault ();

                if (turno == null)
                    return null;

                List<VentasViewModel> ventas = db.Venta
                    .Where(v => v.TurnoId == _singleton.TurnoId)
                    .OrderByDescending(v=> v.Fecha)
                    .Select(v => new VentasViewModel
                    {
                        Fecha = v.Fecha,
                        Concepto = v.Concepto,
                        Costo = v.Costo,
                    })
                    .ToList();

                return new ReportTurnoViewModel()
                {
                    FechaInicio = turno.FechaInicio,
                    FechaTermino = DateTime.Now,
                    Inicio = turno.Inicio,
                    TotalCopias = ventas.Where(v => v.Concepto == "COPIADO").Sum(v => v.Costo),
                    TotalImpresiones = ventas.Where(v => v.Concepto == "IMPRESIONES").Sum(v => v.Costo),
                    TotalVentas = ventas.Sum(v=> v.Costo),
                    Total = 0f,
                    _Ventas = ventas
                };
            }
        }


        public void OpenTurno (string str)
        {
            if (float.TryParse(str, out float result))
            {
                try
                {
                    using (var db = new DBAPPContext())
                    {
                        var check = db.Turno.Where(row => row.UserId == _singleton._IdUser && row.Estado == "OPEN").FirstOrDefault();
                        if (check != null)
                        {
                            _singleton.TurnoId = check.TurnoId;
                            throw new ExistTurnoException();
                        }

                        Turno turno = new Turno
                        {
                            UserId = _singleton._IdUser,
                            Inicio = result,
                            Termino = 0f,
                            FechaInicio = DateTime.Now,
                            FechaTermino = DateTime.Now,
                            Estado = "OPEN"
                        };

                        db.Add(turno);
                        db.SaveChanges();
                        _singleton.TurnoId = turno.TurnoId;
                    }
                }catch (DbUpdateException dbexception)
                {
                    throw new Exception(dbexception.Message);
                }
            }
            else
                throw new ArithmeticException("El texto ingresado no es un valor númerico");
        }

        public void CloseTurno (string ruta, ReportTurnoViewModel report)
        {
            using (var db = new DBAPPContext ())
            {
                var turno = db.Turno.Find(_singleton.TurnoId);
                //var ventasTotal = db.Venta.Where(v => v.IdTurno == _singleton.TurnoId).Sum(v => v.Costo);
                if (turno == null)
                    throw new NoFoundTurno("Turno no encontrado");
                turno.Estado = "CLOSE";
                turno.Termino = report.Inicio + report.TotalVentas;

                turno.FechaTermino = DateTime.Now;
                db.Update(turno);
                db.SaveChanges();
                _singleton.TurnoId = 0;

            }
        }


    }



    public class ExistTurnoException : Exception
    {
        public ExistTurnoException ():base() { } 
        public ExistTurnoException (string message) :base(message) { }
        public ExistTurnoException (string message,Exception inner) :base (message, inner) { }

        public ExistTurnoException (System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            :base (info, context) { }
    }

    public class NoFoundTurno :Exception
    {
        public NoFoundTurno() { }
        public NoFoundTurno (string message) : base(message) { }
        public NoFoundTurno (string message, Exception inner) :base (message, inner) { }
        public NoFoundTurno (System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            :base (info, context) { }
    }
}
