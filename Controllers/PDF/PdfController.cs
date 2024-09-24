using System;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Events;
using iText.Kernel.Colors;

using Controllers.DTO;

namespace Controllers.PDF
{

    
    public class HeaderEventHandler : IEventHandler
    {
        private string[] Titles { get; set; }
        private string [] SubTitles { get; set; }
        private Image _ImgLogo;


        public HeaderEventHandler(Image img, string[] titles, string[] subTitles)
        {
            this._ImgLogo = img;
            this.Titles = titles;
            this.SubTitles = subTitles;
        }

        public void HandleEvent(Event @event)
        {
            PdfDocumentEvent docEvent = (PdfDocumentEvent)@event;
            PdfDocument pdf = docEvent.GetDocument();

            PdfPage page = docEvent.GetPage();
            Rectangle pagesize = new Rectangle(35, page.GetPageSize().GetTop() - 100, page.GetPageSize().GetRight() - 70, 80);

            Canvas canvas = new Canvas(page, pagesize);
            canvas.Add(TableHeader());

        }

        public Table TableHeader()
        {
            Table tbl = new Table(UnitValue.CreatePercentArray(new float[] { 2f, 8f }))
                .UseAllAvailableWidth();

            Style titleStyle = new Style()
                .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD))
                .SetFontSize(12f)
                .SetBorder(Border.NO_BORDER)
                .SetTextAlignment(TextAlignment.RIGHT);

            Style subtitleStyle = new Style()
                .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA))
                .SetFontSize(10f)
                .SetBorder(Border.NO_BORDER)
                .SetTextAlignment(TextAlignment.RIGHT);

            int _rowspan = 1;

            if (this.Titles != null || this.SubTitles != null)
            {
                if (this.SubTitles != null && this.Titles != null)
                    _rowspan = this.Titles.Length + this.SubTitles.Length;
                else
                {
                    if (this.Titles != null)
                        _rowspan = this.Titles.Length;
                    else
                        _rowspan = this.SubTitles.Length;
                }
            }

            Cell cell = new Cell(_rowspan, 1)
                .Add(_ImgLogo.SetAutoScale(true))
                .SetBorder(Border.NO_BORDER)
                .SetTextAlignment(TextAlignment.LEFT);

            tbl.AddCell(cell);

            if (this.Titles != null)
            {
                for (int i = 0; i < this.Titles.Length; i++)
                {
                    tbl.AddCell(
                        new Cell()
                        .Add(new Paragraph(this.Titles[i]))
                        .AddStyle(titleStyle));
                }
            }

            if (this.SubTitles != null)
            {
                for (int i = 0; i< this.SubTitles.Length; i++)
                {
                    tbl.AddCell(new Cell ()
                        .Add(new Paragraph(this.SubTitles[i]))
                        .AddStyle(subtitleStyle));
                }
            }
            return tbl;
        }
    }
    public class PdfController
    {
        protected PdfWriter PdfW;
        protected PdfDocument PdfDoc;
        protected Document Doc;

        protected PageSize _PageSize = PageSize.LETTER;

        protected float[] _Margins = new float[4] { 100, 35, 70, 35 };
        protected float[] _SizePercent = new float[2] { 2, 8 };

        protected PdfFont _Font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
        protected PdfFont _FontBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

        protected Style _NormalFontStyle;
        protected Style _BoldFontStyle;

        protected Style _normalCellStyle;
        protected Style _boldCellStyle;

        protected Style _headerCellStyle;
        protected Style _dataCellStyle;

        protected Style _warningCellStyle;
        protected Style _successCellStyle;

        protected Color _bgColor;

        protected Image _Logo;
        protected Image _WaterMark;



        public PdfController(string ruta)
        {
            PdfW = new PdfWriter(ruta);
            PdfDoc = new PdfDocument(PdfW);
            Doc = new Document(PdfDoc);
            InitDoc();
        }

        protected void InitDoc()
        {
            PdfDoc.SetDefaultPageSize(PageSize.LETTER);
            Doc.SetMargins(_Margins[0], _Margins[1], _Margins[2], _Margins[3]);
            Doc.SetFont(_Font);
            _bgColor = ColorConstants.LIGHT_GRAY;

            _NormalFontStyle = new Style()
                .SetFont(_Font)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(12)
                .SetFontColor(ColorConstants.BLACK);

            _BoldFontStyle = new Style()
                .SetFont(_FontBold)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(14)
                .SetFontColor(ColorConstants.BLACK);

            /*
             No border
             */
            _normalCellStyle = new Style()
                .SetFont(_Font)
                .SetFontSize(12f)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontColor(ColorConstants.BLACK)
                .SetBorder(Border.NO_BORDER)
                .SetVerticalAlignment(VerticalAlignment.MIDDLE);

            _boldCellStyle = new Style()
                .SetFont(_FontBold)
                .SetFontSize(14f)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontColor(ColorConstants.BLACK)
                .SetBorder(Border.NO_BORDER)
                .SetVerticalAlignment(VerticalAlignment.MIDDLE);

            /*
             for tables
             */

            _headerCellStyle = new Style()
                .SetFont(_Font)
                .SetFontSize(14f)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontColor(ColorConstants.BLACK)
                .SetVerticalAlignment(VerticalAlignment.MIDDLE)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY);

            _dataCellStyle = new Style()
                .SetFont(_Font)
                .SetFontSize(14f)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontColor(ColorConstants.BLACK)
                .SetVerticalAlignment(VerticalAlignment.MIDDLE);

        }

        protected Cell AddCell(string content, Style cellStyle)
        {
            Cell cell = new Cell();
            cell.Add(new Paragraph(content))
                .AddStyle(_dataCellStyle);
            return cell;
        }

        protected Cell AddCellHeader(string content)
        {
            Cell cell = new Cell();
            cell.Add(new Paragraph(content)).AddStyle(_headerCellStyle);
            return cell;
        }

        protected Cell AddImgCell(Image img, Style cellStyle)
        {
            Cell cell = new Cell();
            cell.Add(img).AddStyle(cellStyle);
            return cell;
        }

        protected Table AddTitle(string[] titles)
        {
            Table tbl = new Table(UnitValue.CreatePercentArray(new float[] { 10 })).UseAllAvailableWidth();

            for (int i = 0; i < titles.Length; i++)
            {
                tbl.AddCell(new Cell()
                    .Add(new Paragraph(titles[i]))
                    .AddStyle(_normalCellStyle));
            }
            return tbl;
        }


        protected Table AddTitle(string[] titles, Style fontStyle)
        {
            _BoldFontStyle = fontStyle;
            return this.AddTitle(titles);
        }

        public Table AddSubTitle(string[] subtitles)
        {
            Table tbl = new Table(UnitValue.CreatePercentArray(new float[] { 10 })).UseAllAvailableWidth();
            for (int i = 0; i < subtitles.Length; i++)
            {
                tbl.AddCell(new Cell()
                    .Add(new Paragraph(subtitles[i]).AddStyle(_NormalFontStyle))
                    .SetBorder(Border.NO_BORDER)
                    .SetVerticalAlignment(VerticalAlignment.MIDDLE));
            }
            return tbl;
        }

        public Table AddSubTitle(string[] subtitles, Style fontStyle)
        {
            _NormalFontStyle = fontStyle;
            return this.AddSubTitle(subtitles);
        }


        public Table AddTable(string[] cols, string[,] data, float[] _percentsCols, Color bg)
        {
            _bgColor = bg;
            return this.AddTable(cols, data, _percentsCols);
        }

        public Table AddTable(string[] cols, string[,] data, float[] _percentsCols)
        {
            Table tbl = new Table(UnitValue.CreatePercentArray(_percentsCols)).UseAllAvailableWidth();
            for (int i = 0; i < cols.Length; i++)
            {
                Paragraph p = new Paragraph(cols[i]);
                p.AddStyle(_BoldFontStyle);
                Cell cellHeader = new Cell()
                    .Add(p)
                    .SetBackgroundColor(_bgColor)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetVerticalAlignment(VerticalAlignment.MIDDLE);
                tbl.AddHeaderCell(cellHeader);
            }

            for (int row = 0; row < data.GetLength(0); row++)
            {
                for (int cell = 0; cell < data.GetLength(1); cell++)
                {
                    Paragraph p = new Paragraph(data[row, cell]).AddStyle(_NormalFontStyle);
                    Cell cellData = new Cell()
                        .Add(p)
                        .SetVerticalAlignment(VerticalAlignment.MIDDLE)
                        .SetTextAlignment(TextAlignment.LEFT);
                    tbl.AddCell(cellData);
                }
            }
            return tbl;
        }

    }
    public class CortePdf : PdfController
    {
        Singleton _singleton;

        ReportTurnoViewModel Corte;

        public CortePdf(string ruta, ReportTurnoViewModel corte, string logo) 
        : base(ruta)
        {
            _singleton = Singleton.GetInstance();
            Corte = corte;
            _Logo = new Image(ImageDataFactory.Create(logo));
            PdfDoc.AddEventHandler(PdfDocumentEvent.START_PAGE, new HeaderEventHandler(_Logo, new string[]
            {
                _singleton._NameEnterprise
            }, new string[] {
                _singleton._AddressEnterprise,
                _singleton._PhoneEnterprise,
                DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString ()
            }));
        }

        public void CreatePDF()
        {
            Doc.Add(AddTitle(new string[]{ $"CORTE DE CAJA",
                $"USUARIO: {_singleton._UserName}"}));

            Table tbl = AddTable(new string[]
            {
                "CONCEPTO", "IMPORTE"
            }, new string[5, 2] 
            {
                {"VENTAS POR COPIAS", String.Format("{0:0,0.00}", Corte.TotalCopias)},
                {"VENTAS POR IMPRESIONES", String.Format("{0:0,0.00}", Corte.TotalImpresiones)},
                {"VENTAS NETAS", String.Format("{0:0,0.00}", Corte.TotalVentas)},
                {"CAJA INICIAL", String.Format("{0:0,0.00}", Corte.Inicio) },
                {"EFECTIVO TOTAL", String.Format("{0:0,0.00}", Corte.Total)}
            }, new float [] { 50, 50 });
            Doc.Add(tbl);
            Doc.Close();
        }
    }
    public class ReportPDF : PdfController 
    {
        private Singleton _singleton;
        private ReportsViewModel _report;
        public ReportPDF (string ruta, ReportsViewModel report, string logo) :base (ruta)
        {
            _singleton = Singleton.GetInstance();
            this._report = report;
            _Logo = new Image(ImageDataFactory.Create(logo));
            PdfDoc.AddEventHandler(PdfDocumentEvent.START_PAGE, new HeaderEventHandler(_Logo, new string[]
            {
                _singleton._NameEnterprise
            }, new string[] {
                _singleton._AddressEnterprise,
                _singleton._PhoneEnterprise,
                DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString()
            }));
        }
        public void CreatePDF()
        {
            Doc.Add(AddTitle(new string[]{ $"REPORTE DE VENTAS",
                $"USUARIO: {_singleton._UserName}",
                $"PERIODO: {_report.InitDate.ToLongDateString()} a {_report.EndDate.ToLongDateString()} ",
                $"TOTAL VENDIDO: {_report.TotalAcumlado}",
                }
            ));
            if (_report.concepto == "COPIADO")
                Doc.Add(AddTitle(new string[] { $"VENTAS POR {_report.concepto.ToUpper()}: $ {string.Format("{0:00,0.00}", _report.TotalCopias)}" }));
            if (_report.concepto == "IMPRESIONES")
                Doc.Add(AddTitle(new string[] { $"VENTAS POR {_report.concepto.ToUpper()}: $ {string.Format("{0:00,0.00}", _report.TotalImpresiones)}" }));

            

            string[,] data = new string[_report.ventas.Count, 4];
            int i = 0;
            foreach (var v in _report.ventas)
            {
                data[i, 0] = v.Fecha.ToLongDateString();
                data[i, 1] = v.Usuario;
                data[i, 2] = v.Concepto;
                data[i, 3] = string.Format("{0:0,0.00}", v.Costo);
                i++;
            }

            Table tbl = AddTable(new string[]
            {
                "FECHA", "USUARIO", "CONCEPTO", "IMPORTE"
            }, data, new float[] { 30, 30, 20, 20 });

            Doc.Add(tbl);
            Doc.Close();
        }
    }
    
}
