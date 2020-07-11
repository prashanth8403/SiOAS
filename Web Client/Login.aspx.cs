using System;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Text;

namespace SiOAS
{
    public partial class Register : System.Web.UI.Page
    {
        public static MySqlConnection connect = new MySqlConnection("Server=localhost; DATABASE=sioas_bmsit; UID=root;PASSWORD=silicon;");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MessagePanel.Visible = false;
                // Response.Redirect("#" + _hasher("1234"));
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            int ID = 0;
            try
            {
                string Query = "SELECT COUNT(*) FROM user_record WHERE USN='" + StudentUsn.Text + "' AND PASSWORDHASH='" + _hasher(Password.Text) + "';";
                connect.Open();
                MySqlCommand LoginProcess = new MySqlCommand(Query, connect);
                ID = Convert.ToInt32(LoginProcess.ExecuteScalar());
                connect.Close();
                if (ID == 1)
                {
                    connect.Open();
                    string Query0 = "SELECT COUNT(*) FROM quiz_record WHERE CODE=" + Code.Text;
                    MySqlCommand CodeProcess = new MySqlCommand(Query0, connect);
                    int CODEID = Convert.ToInt32(CodeProcess.ExecuteScalar());
                    connect.Close();
                    if (CODEID == 1)
                    {
                        connect.Open();
                        string QueryR = "SELECT COUNT(*) FROM user_response WHERE USN='"+StudentUsn.Text+"'AND  CODE=" + Code.Text;
                        MySqlCommand CodeProcessR = new MySqlCommand(QueryR, connect);
                        int RESPONSE = Convert.ToInt32(CodeProcessR.ExecuteScalar());
                        connect.Close();
                        if(RESPONSE != 1)
                        {
                            string Query1 = "SELECT ELECTIVE,BRANC,BRANCH,SEM,SEMESTER,TIME FROM user_record,quiz_record WHERE user_record.USN='" + StudentUsn.Text+"' and quiz_record.code=" + Convert.ToInt32(Code.Text);
                            connect.Open();
                            MySqlCommand UserProcess = new MySqlCommand(Query1, connect);
                            MySqlDataReader Reader = UserProcess.ExecuteReader();
                            Reader.Read();
                            if ((Convert.ToString(Reader[0]) == "1") && (Convert.ToString(Reader[3]) == Convert.ToString(Reader[4])))
                            {
                                Session["Usn"] = StudentUsn.Text.ToUpper();
                                Session["Code"] = Code.Text;
                                Session["Time"] = Convert.ToString(Reader[5]);
                                Reader.Close();
                                connect.Close();
                                Response.Redirect("Instruction?Security=" + _hasher(StudentUsn.Text) + "?Def=_INITIAL");
                            }

                            else if ((Convert.ToString(Reader[1]) == Convert.ToString(Reader[2])) && (Convert.ToString(Reader[3]) == Convert.ToString(Reader[4])))
                            {
                                Session["Usn"] = StudentUsn.Text.ToUpper();
                                Session["Code"] = Code.Text;
                                Session["Time"] = Convert.ToString(Reader[5]);
                                Reader.Close();
                                connect.Close();
                                Response.Redirect("Instruction?Security=" + _hasher(StudentUsn.Text) + "?Def=_INITIAL");
                            }
                            else
                            {
                                MessageHandler("Opps!", "Enterd passcode is not applicable to you!");
                            }
                        }
                        else
                        {
                            MessageHandler("Opps!", "You have already attempted this Quiz!");
                        }
                    }
                    else
                    {
                        MessageHandler("Opps!", "Invalid Passcode!");
                    }
                }
                else
                {
                    MessageHandler("Opps!", "Incorrect Password!");
                }
            }
            catch (MySqlException er)
            {
                if(connect.State == System.Data.ConnectionState.Open)
                {
                    connect.Close();
                }
                MessageHandler("Error", er.Message);
            }
            catch (Exception err)
            {
                if (connect.State == System.Data.ConnectionState.Open)
                {
                    connect.Close();
                }
                MessageHandler("Error", err.Message);
            }
        }

        protected void MessageHandler(string Header, string Message)
        {
            MessageHeader.Text = Header;
            MessagePanel.Visible = true;
            MessageLabel.Text = Message;
        }

        protected void _messagebutton_Click(object sender, EventArgs e)
        {
            MessagePanel.Visible = false;
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
    }
}