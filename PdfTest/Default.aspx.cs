using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedPort.Commons;

namespace PdfTest
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PdfUtility pdfUtility = new PdfUtility();
            string pdfName = Request.MapPath("./pdf/sample.pdf");

            pdfUtility.CreatePdf(pdfName);

            Response.WriteFile(Request.MapPath("./pdf/sample.pdf"));

            //StringBuilder script = new StringBuilder();
            //script.AppendFormat("<script language=\"javascript\">window.open('{0}');</script>", pdfName);
            //ClientScript.RegisterClientScriptBlock(this.GetType(), "openPdf", script.ToString());

        }
    }
}