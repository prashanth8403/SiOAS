using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiOAS
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessagePanel.Visible = false;
            SucessPanel.Visible = false;
            UserSelection.Visible = false;
            UserAuthentication.Visible = false;
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        protected void BackButton_Click(object sender, EventArgs e)
        {

        }

        protected void _messagebutton_Click(object sender, EventArgs e)
        {

        }

        protected void SucessBtn_Click(object sender, EventArgs e)
        {

        }
    }
}