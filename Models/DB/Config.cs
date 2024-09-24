using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DB
{
    public class Config
    {
        public int ConfigId { get; set; }
        public string Categoria { get; set; }
        public string Campo { get; set; }
        public string Valor { get; set; }
    }
}
