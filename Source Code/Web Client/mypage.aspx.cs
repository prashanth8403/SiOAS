using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Web.UI.WebControls;

namespace SiOAS
{
    public partial class mypage : System.Web.UI.Page
    {
        public static MySqlConnection connect = new MySqlConnection("Server=localhost; DATABASE=sioas_bmsit; UID=root;PASSWORD=silicon;");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["Success"] != null)
                {
                    Session.Clear();
                    Response.Redirect("Login");
                }
                if (Session["Usn"] != null && Session["Code"] != null)
                {
                    try
                    {
                        connect.Open();
                        string MiscQuery = "SELECT Subject,Time FROM quiz_record where code=" + Convert.ToString(Session["Code"]);
                        MySqlCommand SqlProcess0 = new MySqlCommand(MiscQuery, connect);
                        MySqlDataReader Reader = SqlProcess0.ExecuteReader();
                        Reader.Read();
                        int time = Convert.ToInt32(Reader["Time"]);
                        SubjectLabel.Text = Convert.ToString(Reader["Subject"]);
                        NameLabel.Text = (String)Session["Usn"];
                        SubjectCode.Text = (String)Session["Code"];
                        Reader.Close();
                        string QuestionQuery = "SELECT * FROM question_data where code=" + Convert.ToString(Session["Code"]) + " ORDER BY RAND() ";
                        MySqlCommand SqlProcess1 = new MySqlCommand(QuestionQuery, connect);
                        QuestionLoader.DataSource = SqlProcess1.ExecuteReader();
                        QuestionLoader.DataBind();
                        connect.Close();
                    }
                    catch (MySqlException MysqlError)
                    {
                        if (connect.State == System.Data.ConnectionState.Open)
                        {
                            connect.Close();
                        }
                    }
                    catch (Exception SysError)
                    {
                        if (connect.State == System.Data.ConnectionState.Open)
                        {
                            connect.Close();
                        }
                    }

                }
                else
                {
                    Response.Redirect("Login");
                }
            }
            else
            {
                QuestionPanel.Visible = false;
                SuccessPanel.Visible = true;
            }
        }

        public static string _hasher(string text)
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

        protected void BtnNext_Click(object sender, EventArgs e)
        {
            submit();
        }

        public void submit()
        {
            int Marks = 0;
            int Count = 0;
            foreach (RepeaterItem Question in QuestionLoader.Items)
            {
                Count++;
                RadioButton Option1 = (RadioButton)Question.FindControl("Option1");
                RadioButton Option2 = (RadioButton)Question.FindControl("Option2");
                RadioButton Option3 = (RadioButton)Question.FindControl("Option3");
                RadioButton Option4 = (RadioButton)Question.FindControl("Option4");
                Label Answer = (Label)Question.FindControl("QueryA2");
                Answer.Visible = true;
                if (Option1.Checked == true && Answer.Text == _hasher("1"))
                    Marks++;
                else if (Option2.Checked == true && Answer.Text == _hasher("2"))
                    Marks++;
                else if (Option3.Checked == true && Answer.Text == _hasher("3"))
                    Marks++;
                else if (Option4.Checked == true && Answer.Text == _hasher("4"))
                    Marks++;
            }
            try
            {
                connect.Open();
                string MiscQuery = "SELECT name,semester,branch,section FROM user_record WHERE USN='" + NameLabel.Text + "';";
                MySqlCommand SqlProcess0 = new MySqlCommand(MiscQuery, connect);
                MySqlDataReader Reader = SqlProcess0.ExecuteReader();
                Reader.Read();
                string NAME = Convert.ToString(Reader[0]);
                string SEMESTER = Convert.ToString(Reader[1]);
                string BRANCH = Convert.ToString(Reader[2]);
                string SECTION = Convert.ToString(Reader[3]);
                Reader.Close();
                string MiscQuery1 = "SELECT password FROM quiz_record WHERE Code=" + SubjectCode.Text + ";";
                MySqlCommand SqlProcess1 = new MySqlCommand(MiscQuery1, connect);
                MySqlDataReader Reader1 = SqlProcess1.ExecuteReader();
                Reader1.Read();
                string PASSWORD = Convert.ToString(Reader1[0]);
                Reader1.Close();
                string InsertQuery = "INSERT INTO user_response (USN,Code,Time,Marks) values ('" + NameLabel.Text + "'," + SubjectCode.Text + ",'" + System.DateTime.Now.ToString() + "'," + Marks.ToString() + ");";
                MySqlCommand InsertProcess = new MySqlCommand(InsertQuery, connect);
                InsertProcess.ExecuteNonQuery();
                connect.Close();
                Session["Success"] = true;
                GenerateDocument(PASSWORD, NameLabel.Text, NAME, SEMESTER, BRANCH, SECTION, Marks, Count, SubjectLabel.Text);
            }
            catch (MySqlException MysqlError)
            {
                if(connect.State == System.Data.ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            catch (Exception SysError)
            {
                if (connect.State == System.Data.ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        protected void GenerateDocument(string password, string USN, string Name, string Semester, string Branch, string Section, int marks, int Count, string Title)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html>");
            sb.Append("<body>");
            sb.Append("<br/>");
            sb.Append("<br/>");
            sb.Append("<br/>");
            sb.Append("<br/>");
            sb.Append("    <div>");
            sb.Append("        <div >");
            sb.Append("            <img id=\"logoid\" src=" + Server.MapPath("/Document/img1.png") + " height =\"90\" />");
            sb.Append("        </div>");
            sb.Append("    </div>");
            sb.Append("    <div >");
            sb.Append("    <div>");
            sb.Append("    <br/>");
            sb.Append("    <br/>");
            sb.Append("    <br/>");
            sb.Append("    <br/>");
            sb.Append("    <br/>");
            sb.Append("    <div>");
            sb.Append("         <div style=\"text-align:center;font-weight:600; font-family:Arial;font-size:20px;\">");
            sb.Append(Title);
            sb.Append("         </div>");
            sb.Append("    </div >");
            sb.Append("    <br/>");
            sb.Append("    <br/>");
            sb.Append("    <br/>");
            sb.Append("    <br/>");
            sb.Append("    <br/>");
            sb.Append("    <br/>");
            sb.Append("    <br/>");
            sb.Append("    <br/>");
            sb.Append("    <div>");
            sb.Append("    <div style=\"text-align:left;padding-left:50px; font-family: 'Times New Roman', Arial;font-size:18px;\">");
            sb.Append("     Submitted by:<br/>");
            sb.Append("    <br/>");
            sb.Append(Name);
            sb.Append("    <br/>");
            sb.Append(USN);
            sb.Append("    <br/>");
            sb.Append(Semester + "&nbsp;&nbsp;" + "'" + Section + "'");
            sb.Append("&nbsp;&nbsp;" + Branch + "E");
            sb.Append("    <br/>");
            sb.Append("Submitted at&nbsp;" + DateTime.Now.ToString());
            sb.Append("     </div>");
            sb.Append("    </div >");
            sb.Append("    <br/>");
            sb.Append("    <br/>");
            sb.Append("    <div>");
            sb.Append("         <div style=\"text-align:center;font-weight:600; font-family:Arial;font-size:18px;\">");
            sb.Append("    Marks Obtained:");
            sb.Append("    <br/>");
            sb.Append(marks.ToString() + "/" + Count.ToString());
            sb.Append("    <br/>");
            sb.Append("         </div>");
            sb.Append("    </div >");
            sb.Append("    <br/>");
            sb.Append("    <div style=\"text-align:center;\">");
            sb.Append("            <img id=\"logoid\"  src=" + Server.MapPath("/Document/rook.png") + " height =\"160\" />");
            sb.Append("    </div>");
            sb.Append("    <br/>");
            sb.Append("    <br/>");
            sb.Append("    <br/>");
            sb.Append("    <br/>");
            sb.Append("    <br/>");
            sb.Append("    <br/>");
            int QuestionNo = 0;
            foreach (RepeaterItem Question in QuestionLoader.Items)
            {
                QuestionNo++;
                RadioButton Option1 = (RadioButton)Question.FindControl("Option1");
                RadioButton Option2 = (RadioButton)Question.FindControl("Option2");
                RadioButton Option3 = (RadioButton)Question.FindControl("Option3");
                RadioButton Option4 = (RadioButton)Question.FindControl("Option4");
                System.Web.UI.WebControls.Image QuestionImage = (System.Web.UI.WebControls.Image)Question.FindControl("QuestionImage");
                Label Answer = (Label)Question.FindControl("QueryA2");
                Label Questionll = (Label)Question.FindControl("QuestionLabel");
                Answer.Visible = true;
                sb.Append("    <br/>");
                sb.Append("    <div>");
                sb.Append("    <div style=\"text-align:left;padding-left:50px;margin-right:50px;font-family:'Robotoasd';font-size:15px;\">");
                sb.Append(QuestionNo.ToString() + ".&nbsp;" + Questionll.Text);
                sb.Append("    <br/>");
                if ("focalimages\\0.JPG" != QuestionImage.ImageUrl)
                {
                    sb.Append("    <br/>");
                    sb.Append(" <img class=\"imagebox\" src=\"" + Server.MapPath("/" + QuestionImage.ImageUrl) + "\" height =\"180\" style=\"position: center;margin-left:auto;margin-right:auto;\"/>");
                    sb.Append("    <br/>");
                }
                sb.Append("    <br/>");
                sb.Append("&nbsp;a.&nbsp;" + Option1.Text);
                sb.Append("    <br/>");
                sb.Append("&nbsp;b.&nbsp;" + Option2.Text);
                sb.Append("    <br/>");
                sb.Append("&nbsp;c.&nbsp;" + Option3.Text);
                sb.Append("    <br/>");
                sb.Append("&nbsp;d.&nbsp;" + Option4.Text);
                sb.Append("    <br/>");
                sb.Append("    <br/>");
                if (Option1.Checked == true)
                    sb.Append("Answered:&nbsp;" + Option1.Text);
                else if (Option2.Checked == true)
                    sb.Append("Answered:&nbsp;" + Option2.Text);
                else if (Option3.Checked == true)
                    sb.Append("Answered:&nbsp;" + Option3.Text);
                else if (Option4.Checked == true)
                    sb.Append("Answered:&nbsp;" + Option4.Text);
                else
                {
                    sb.Append("Not Answered");
                }
                sb.Append("    <br/>");
                sb.Append("    <br/>");
                sb.Append("     </div>");
                sb.Append("    </div >");
                sb.Append("    <br/>");
            }
            sb.Append("</body>");
            sb.Append("</html>");
            Session["SubjectCode"] = SubjectCode.Text;
            Session["Usn"] = NameLabel.Text;
            Session["Password"] = password;
            Session["HTMLDoc"] = sb.ToString();
            File.WriteAllText(Server.MapPath("USERDATA/" + USN + SubjectCode.Text+".html"), sb.ToString());
            Response.Redirect("Final");
        }
    }
}