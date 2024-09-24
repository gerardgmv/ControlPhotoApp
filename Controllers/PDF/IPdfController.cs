using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Controllers.PDF
{
    public interface IPdfController
    {
        public void Init();
        public Table AddTable();
        public Table AddTitle();
        public Table AddSubTitle();
    }
}
