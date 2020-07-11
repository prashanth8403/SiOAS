using System;
using System.Text;
using System.Security.Cryptography;


namespace SiOAS
{
    public partial class Information : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Code"] == null)
            {
                Response.Redirect("Login");
            }
        }

        protected void InstrBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mypage?Security=" + hasher((string)Session["Usn"]) + "&Code=" + Session["Code"] + "&buffer=" + Convert.ToString(Session["Time"]) + "&Def=_INITAL_SNAP-TRACE-ALL");
        }

        public static string hasher(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
    }
}