using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiOAS
{
    public partial class Success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Success"] == null)
                {
                    Response.Redirect("Login");
                }
                else
                {

                }
            }
        }

        protected void PrintDocument()
        {
            try
            {
                string Data = (string)Session["HTMLDoc"];
                string Usn = (string)Session["Usn"];
                string Code = (string)Session["SubjectCode"];
                string password = (string)Session["Password"];
                Session.Clear();
                Document pdfDoc = new Document(PageSize.A4, 30f, 30f, 30f, 30f);
                HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                StringReader sr = new StringReader(Data);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    PdfWriter.GetInstance(pdfDoc, memoryStream);
                    pdfDoc.Open();
                    htmlparser.Parse(sr);
                    pdfDoc.Close();
                    byte[] bytes = memoryStream.ToArray();
                    memoryStream.Close();
                    using (MemoryStream input = new MemoryStream(bytes))
                    {
                        using (MemoryStream output = new MemoryStream())
                        {
                            PdfReader reader = new PdfReader(input);
                            PdfEncryptor.Encrypt(reader, output, true, password, password, PdfWriter.ALLOW_SCREENREADERS);
                            bytes = output.ToArray();
                            Response.ContentType = "application/pdf";
                            Response.AddHeader("content-disposition", "attachment;filename=ROOKLABS_SiOAS_" + Usn + "-" + "SU" + Code + ".pdf");
                            Response.Cache.SetCacheability(HttpCacheability.NoCache);
                            Response.BinaryWrite(bytes);
                            Response.Flush();
                            Response.End();
                        }
                    }
                }
            }
            catch (Exception err)
            {
                //Response.Redirect("Login");
                Response.Redirect("#" + err.Message);
            }
        }

        protected void Download_Click(object sender, EventArgs e)
        {
            PrintDocument();
        }
    }
}