using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace SiOAS.Dashboard
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           /* DataTable dt = (DataTable)ViewState["AcademicGrid"];
            dt.Rows.Add(ClassAcademic.Text.Trim(), SchoolNameAcademic.Text.Trim(), JoiningYearAcademic.Text, PassingYearAcademic.Text);
            ViewState["AcademicGrid"] = dt;
            this.BindGrid();*/
        }

        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            /**/
            /**/
            int index = Convert.ToInt32(e.RowIndex);
            DataTable dt = ViewState["AcademicGrid"] as DataTable;
            dt.Rows[index].Delete();
            ViewState["AcademicGrid"] = dt;
        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string item = e.Row.Cells[0].Text;
                foreach (Button button in e.Row.Cells[2].Controls.OfType<Button>())
                {
                    if (button.CommandName == "Delete")
                    {
                        button.Attributes["onclick"] = "if(!confirm('Do you want to delete " + item + "?')){ return false; };";
                    }
                }
            }
        }


    }
}