using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manina.Windows.Forms;
using Models.DB;

namespace Controllers
{
    public class StoreController
    {
        private Singleton _singleton;
        public StoreController() {
            _singleton = Singleton.GetInstance();
        }
      

        public void CopyFiles(ImageListView.ImageListViewItemCollection files, String strDestinyOriginal) 
        {

            string strDestiny = strDestinyOriginal + "\\Galeria\\";
            if (strDestiny == string.Empty)
                throw new Exception("Seleccione un Directorio de Destino Válido");

            if (!Directory.Exists(strDestiny)) {
                try 
                { 
                    Directory.CreateDirectory(strDestiny);
                }catch (Exception)
                {
                    strDestiny = strDestinyOriginal;
                }
            }
            foreach(var img in files) 
            {
                try
                {
                    string copyfile = Path.Combine(strDestiny,Path.GetFileName(img.FileName));
                    File.Copy(img.FileName, copyfile , true);
                } 
                catch (UnauthorizedAccessException ) 
                {
                    throw new Exception( $"No se tienen permisos para copiar el archivo {img.FileName}, revise la configuracion del sistema operativo");
                }
                catch (ArgumentException)
                {
                    throw new Exception ($"El Archivo {img.FileName} o el Directorio {strDestiny}, tienen un formato incorrecto y no se pueden copiar, verifique los nombres");
                }
                catch (PathTooLongException)
                {
                    throw new Exception ( $"El Nombre del Archivo o del Destino es demasiado largo ({img.FileName}, {strDestiny} )");
                }
                catch (IOException)
                {
                    throw new Exception ($"El Nombre del Archivo o del Destino no se encontraron ({img.FileName}, {strDestiny} )");
                }
                catch (NotSupportedException)
                {
                    throw new Exception ($"El Nombre del Archivo o del Destino tiene un formato invalido ({img.FileName}, {strDestiny} )");
                }
            }
        }
        
        
        public void CopyImage(string strDestiny, string source)
        {
            string pathFinal = strDestiny + $"\\{_singleton._directoryCopy}\\";

            if (!Directory.Exists(pathFinal))
            {
                try
                {
                    Directory.CreateDirectory(pathFinal);
                }
                catch (Exception)
                {
                    pathFinal = strDestiny;
                }
            }

            try
            {
                string copyfile = Path.Combine(pathFinal, Path.GetFileName(source));
                File.Copy(source, copyfile, true);
            }
            catch (UnauthorizedAccessException)
            {
                throw new Exception($"No se tienen permisos para copiar el archivo {Path.GetFileName(source)}, revise la configuracion del sistema operativo");
            }
            catch (ArgumentException)
            {
                throw new Exception($"El Archivo {Path.GetFileName(source)} o el Directorio {strDestiny}, tienen un formato incorrecto y no se pueden copiar, verifique los nombres");
            }
            catch (PathTooLongException)
            {
                throw new Exception($"El Nombre del Archivo o del Destino es demasiado largo ({Path.GetFileName(source)}, {strDestiny} )");
            }
            catch (IOException)
            {
                throw new Exception($"El Nombre del Archivo o del Destino no se encontraron ({Path.GetFileName(source)}, {strDestiny} )");
            }
            catch (NotSupportedException)
            {
                throw new Exception($"El Nombre del Archivo o del Destino tiene un formato invalido ({Path.GetFileName(source)}, {strDestiny} )");
            }
        }

        
        public  void DeleteFiles(string directory) 
        {
            DirectoryInfo di = new DirectoryInfo(directory);
            FileInfo[] files = di.GetFiles();
            try { 
                foreach (var file in files) 
                {
                    file.Delete();
                }
            }catch (Exception ex)
            {
                throw new Exception("Los Archivos no se puede Borrar"+ ex.Message);
            }
        }

        public void SaveSale(string concepto, float precio) 
        {
            using (var db = new DBAPPContext ())
            {
                var venta = new Venta {
                    Concepto = concepto,
                    Fecha = DateTime.Now,
                    Costo = precio,
                    TurnoId = _singleton.TurnoId
                };

                db.Add(venta);
                db.SaveChanges();
            }
        }
        

        public async void SavePrints ()
        {
            using (var db = new DBAPPContext())
            {
                var venta = new Venta
                {
                    Concepto = "IMPRESION",
                    Fecha = DateTime.Now,
                    Costo  = _singleton._PricePrint,
                    TurnoId = _singleton.TurnoId
                };
                db.Add(venta);
                await db.SaveChangesAsync();
            }

        }

    
    }
}
