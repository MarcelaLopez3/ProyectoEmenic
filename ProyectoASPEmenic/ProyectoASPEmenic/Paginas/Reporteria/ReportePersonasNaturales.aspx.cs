using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;

namespace ProyectoASPEmenic.Paginas.Reporteria
{
    public partial class ReportePersonasNaturales : System.Web.UI.Page
    {
        /*Instancias a otras clases */
        Conexion conexion = new Conexion();
        Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                PdfWriter.GetInstance(pdfDoc, System.Web.HttpContext.Current.Response.OutputStream);
                //abriendo documento
                pdfDoc.Open();
                string cadenaFinal = string.Empty;

                string strContent = cadenaFinal;

                var parameterElements = HTMLWorker.ParseToList(new StringReader(strContent), null);

                foreach (var htmlElement in parsedHtmlElements)
                    pdfDoc.Add(htmlElement as IElement);
            }
            catch
            {

            }
        }
    }
}