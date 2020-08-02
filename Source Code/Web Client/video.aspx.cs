using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Net;
using System.IO;
using System.ComponentModel;
using System.Web.UI.WebControls;

namespace SiOAS
{
    public partial class video : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string fileNameWitPath = @"D:\mike.png";
            string data1 = photo1.Src;
            using (FileStream fs = new FileStream(fileNameWitPath, FileMode.Create))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    byte[] data = Convert.FromBase64String(data1);
                    bw.Write(data);
                    bw.Close();
                }
            }
            //client.DownloadFileAsync(new Uri(photo.ImageUrl.ToString()), @"D:\temp1\image35.png");
        }
    }
}