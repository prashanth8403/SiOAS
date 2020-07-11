using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace Atlas
{
    public partial class Login : Form
    {
        public MySqlConnection connect = new MySqlConnection("Server=34.66.24.15; DATABASE=quiz; UID=prashanth.kumar;PASSWORD=Hunter21#$%;");
        static int UserActive = 0, PasswordActive = 0, ServerActive = 0;
        Boolean Initilization = false;
        static int access = 1;
        static int EntryValidation = 0;
        string MachineKeyReader = "initial";
        //public MySqlConnection connect = new MySqlConnection("Server=localhost; DATABASE=quiz; UID=root;PASSWORD=silicon;");

        static int i;
        private bool _dragging;
        private Point _offset;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point
                    (currentScreenPos.X - _offset.X,
                     currentScreenPos.Y - _offset.Y);
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            _offset.X = e.X;
            _offset.Y = e.Y;
            _dragging = true;

        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
       
        private void Login_Load(object sender, EventArgs e)
        {
            LoginPreviewPanel.BringToFront();
            ControlLoginPanel.SendToBack();
            ControlLoginPanel.Visible = false;
            Initilization = true;
            LoginTimer.Start();
            TextTimer.Start();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserNameText.Text == "" || PasswordText.Text == "")
            {
                MessageWindow messageWindow = new MessageWindow();
                messageWindow.MessageData = "Error: Invalid Username or Password";
                messageWindow.Show();
                UserNameText.Text = "";
                PasswordText.Text = "";
            }
            else
            {
                if (HostText.Text != "")
                {
                    string username, password, passcode;
                    username = UserNameText.Text;
                    password = PasswordText.Text;
                    int Quiz = 0;
                    passcode = HostText.Text;
                    if (username.Contains(';') || username.Contains("drop") || username.Contains("*"))
                    {
                        MessageWindow messageWindow = new MessageWindow();
                        messageWindow.MessageData = "Error: Invalid UserName or Password";
                        messageWindow.Show();
                    }
                    else
                    {
                        String LoginQuery = "select count(*) from user_profile where USN='" + (username).ToUpper() + "' and Password='" + Hashing(password) + "';";
                        MySqlCommand process = new MySqlCommand(LoginQuery, connect);
                        int Validation = Convert.ToInt32(process.ExecuteScalar());
                        String PasscodeQuery = "select count(*) from data_misc where Passcode=" + passcode + ";";
                        MySqlCommand process2 = new MySqlCommand(PasscodeQuery, connect);
                        int Validation2 = Convert.ToInt32(process2.ExecuteScalar());
                        if (Validation == 1)
                        {
                            
                            string UserUSN, UserName, MachineKey = "null";
                            string QuizQuery = "select * from user_misc where USN='" + (username).ToUpper() + "';";
                            MySqlCommand NewProcess = new MySqlCommand(QuizQuery, connect);
                            using (MySqlDataReader Reader = NewProcess.ExecuteReader())
                            {
                                while (Reader.Read())
                                {
                                    Quiz = (int)Reader[1];
                                }
                            }
                            if (Quiz == 1)
                            {
                                if (Validation2 != 0)
                                {
                                    int PassAccess = 0;
                                    string QuizQuery2 = "select * from data_misc where Passcode=" + passcode + ";";
                                    MySqlCommand NewProcess2 = new MySqlCommand(QuizQuery2, connect);
                                    using (MySqlDataReader Reader = NewProcess2.ExecuteReader())
                                    {
                                        while (Reader.Read())
                                        {
                                            PassAccess = (int)Reader[3];
                                            //MessageBox.Show(">>" + Convert.ToString((int)Reader[2])+" "+ Convert.ToString((string)Reader[1]));
                                        }
                                    }
                                    if (PassAccess == 1)
                                    {
                                        Dashboard dashboard = new Dashboard();
                                        dashboard.UniversitySeatNumber = UserNameText.Text;
                                        dashboard.passcode = Convert.ToInt32(passcode);
                                        dashboard.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageWindow messageWindow = new MessageWindow();
                                        messageWindow.MessageData = "Error: Quiz not allowed for current passcode";
                                        messageWindow.Show();
                                        UserNameText.Text = "";
                                        PasswordText.Text = "";
                                        username = "";
                                        password = "";
                                    }
                                }
                                else
                                {
                                    MessageWindow messageWindow = new MessageWindow();
                                    messageWindow.MessageData = "Error: Invalid Passcode";
                                    messageWindow.Show();
                                    UserNameText.Text = "";
                                    PasswordText.Text = "";
                                    username = "";
                                    password = "";
                                }
                            }
                            else if (Quiz == 0)
                            {
                                MessageWindow messageWindow = new MessageWindow();
                                messageWindow.MessageData = "Error: Quiz has been already conducted\r\nfor this user";
                                messageWindow.Show();
                                UserNameText.Text = "";
                                PasswordText.Text = "";
                                username = "";
                                password = "";
                            }
                            else if (Quiz == 2)
                            {
                                MessageWindow messageWindow = new MessageWindow();
                                messageWindow.MessageData = "Error: Access has been blocked\r\nfor this user";
                                messageWindow.Show();
                                UserNameText.Text = "";
                                PasswordText.Text = "";
                                username = "";
                                password = "";
                            }
                            else
                            {
                                MessageWindow messageWindow = new MessageWindow();
                                messageWindow.MessageData = "Error: Unexpected error occured\r\nCode: SA23";
                                messageWindow.Show();
                                UserNameText.Text = "";
                                PasswordText.Text = "";
                                username = "";
                                password = "";
                            }
                        }
                        else
                        {
                            MessageWindow messageWindow = new MessageWindow();
                            messageWindow.MessageData = "Error: Invalid Username or Password";
                            messageWindow.Show();
                            UserNameText.Text = "";
                            PasswordText.Text = "";
                            username = "";
                            password = "";
                        }
                    }
                }
            }
        }

        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            i++;
            if (Initilization == true)
            {
                if (i == 5)
                {
                    try
                    {
                        LoginMessageLabel.Text = "Connecting...";
                        connect.Open();
                    }
                    catch (MySqlException error)
                    {
                        access = 0;
                        LoginMessageLabel.Text = "Connection Error";
                    }
                }
                if (i == 10 && access == 1)
                {
                    LoginMessageLabel.Text = "Validating...";
                    String EntryQuery = "select count(*) from data_misc;";
                    MySqlCommand Entryprocess = new MySqlCommand(EntryQuery, connect);
                    EntryValidation = Convert.ToInt32(Entryprocess.ExecuteScalar());
                }
                if (i == 20 && access == 1)
                {
                    if (EntryValidation == 0)
                    {
                        LoginMessageLabel.Text = "Access Denied";
                        access = 0;
                    }
                    else
                    {
                        LoginMessageLabel.Text = "Access Granted";
                    }
                }
                if (i == 35 && access == 1)
                {
                    Initilization = false;
                    LoginPreviewPanel.SendToBack();
                    ControlLoginPanel.Visible = true;
                    ControlLoginPanel.BringToFront();
                    LoginTimer.Stop();
                }

                if (i == 35 && access == 0)
                {
                    LoginMessageLabel.Text = "Terminating Application...";
                }
                if (i == 50 && access == 0)
                {
                    Application.Exit();
                }
            }
        }
        public static string Hashing(string text)
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

        private void ControlLoginPanel_Click(object sender, EventArgs e)
        {
            if (PasswordText.Text == "" && PasswordActive != 0)
            {
                PasswordActive = 0;
                PasswordLabel.Location = new System.Drawing.Point(PasswordLabel.Location.X, PasswordLabel.Location.Y + PasswordText.Height + 8);
                PasswordLabel.ForeColor = Color.White;
                PasswordPanel.BackColor = Color.White;
            }
            if (UserNameText.Text == "" && UserActive != 0)
            {
                UserActive = 0;
                UserLabel.Location = new System.Drawing.Point(UserLabel.Location.X, UserLabel.Location.Y + UserNameText.Height + 8);
                UserLabel.ForeColor = Color.White;
                UserPanel.BackColor = Color.White;
            }
            if (HostText.Text == "" && ServerActive != 0)
            {
                ServerActive = 0;
                HostLabel.Location = new System.Drawing.Point(HostLabel.Location.X, HostLabel.Location.Y + HostText.Height + 8);
                HostLabel.ForeColor = Color.White;
                ServerPanel.BackColor = Color.White;
            }
        }

        private void UserLabel_Click(object sender, EventArgs e)
        {
            if (UserActive != 1)
            {
                UserLabel.Location = new System.Drawing.Point(UserLabel.Location.X, UserLabel.Location.Y - UserNameText.Height - 8);
                UserActive = 1;
                UserLabel.ForeColor = Color.DodgerBlue;
                UserPanel.BackColor = Color.DodgerBlue;
            }
            if (PasswordText.Text == "" && PasswordActive != 0)
            {
                PasswordActive = 0;
                PasswordLabel.Location = new System.Drawing.Point(PasswordLabel.Location.X, PasswordLabel.Location.Y + PasswordText.Height + 8);
                PasswordLabel.ForeColor = Color.White;
                PasswordPanel.BackColor = Color.White;
            }
            if (HostText.Text == "" && ServerActive != 0)
            {
                ServerActive = 0;
                HostLabel.Location = new System.Drawing.Point(HostLabel.Location.X, HostLabel.Location.Y + HostText.Height + 8);
                HostLabel.ForeColor = Color.White;
                ServerPanel.BackColor = Color.White;
            }
            this.UserNameText.Focus();
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {
            if (PasswordActive != 1)
            {
                PasswordLabel.Location = new System.Drawing.Point(PasswordLabel.Location.X, PasswordLabel.Location.Y - PasswordText.Height - 8);
                PasswordActive = 1;
                PasswordLabel.ForeColor = Color.DodgerBlue;
                PasswordPanel.BackColor = Color.DodgerBlue;
            }
            if (UserNameText.Text == "" && UserActive != 0)
            {
                UserActive = 0;
                UserLabel.Location = new System.Drawing.Point(UserLabel.Location.X, UserLabel.Location.Y + UserNameText.Height + 8);
                UserLabel.ForeColor = Color.White;
                UserPanel.BackColor = Color.White;
            }
            if (HostText.Text == "" && ServerActive != 0)
            {
                ServerActive = 0;
                HostLabel.Location = new System.Drawing.Point(HostLabel.Location.X, HostLabel.Location.Y + HostText.Height + 8);
                HostLabel.ForeColor = Color.White;
                ServerPanel.BackColor = Color.White;
            }
            this.PasswordText.Focus();
        }

        private void HostLabel_Click(object sender, EventArgs e)
        {
            if (ServerActive != 1)
            {
                HostLabel.Location = new System.Drawing.Point(HostLabel.Location.X, HostLabel.Location.Y - HostText.Height - 8);
                ServerActive = 1;
                HostLabel.ForeColor = Color.DodgerBlue;
                ServerPanel.BackColor = Color.DodgerBlue;
            }
            if (UserNameText.Text == "" && UserActive != 0)
            {
                UserActive = 0;
                UserLabel.Location = new System.Drawing.Point(UserLabel.Location.X, UserLabel.Location.Y + UserNameText.Height + 8);
                UserLabel.ForeColor = Color.White;
                UserPanel.BackColor = Color.White;
            }
            if (PasswordText.Text == "" && PasswordActive != 0)
            {
                PasswordActive = 0;
                PasswordLabel.Location = new System.Drawing.Point(PasswordLabel.Location.X, PasswordLabel.Location.Y + PasswordText.Height + 8);
                PasswordLabel.ForeColor = Color.White;
                PasswordPanel.BackColor = Color.White;
            }

            this.HostText.Focus();
        }

        private void UserNameText_Click(object sender, EventArgs e)
        {
            if (UserActive != 1)
            {
                UserLabel.Location = new System.Drawing.Point(UserLabel.Location.X, UserLabel.Location.Y - UserNameText.Height - 8);
                UserActive = 1;
                UserLabel.ForeColor = Color.DodgerBlue;
                UserPanel.BackColor = Color.DodgerBlue;
            }
            if (PasswordText.Text == "" && PasswordActive != 0)
            {
                PasswordActive = 0;
                PasswordLabel.Location = new System.Drawing.Point(PasswordLabel.Location.X, PasswordLabel.Location.Y + PasswordText.Height + 8);
                PasswordLabel.ForeColor = Color.White;
                PasswordPanel.BackColor = Color.White;
            }
            if (HostText.Text == "" && ServerActive != 0)
            {
                ServerActive = 0;
                HostLabel.Location = new System.Drawing.Point(HostLabel.Location.X, HostLabel.Location.Y + HostText.Height + 8);
                HostLabel.ForeColor = Color.White;
                ServerPanel.BackColor = Color.White;
            }
        }

        private void PasswordText_Click(object sender, EventArgs e)
        {
            if (PasswordActive != 1)
            {
                PasswordLabel.Location = new System.Drawing.Point(PasswordLabel.Location.X, PasswordLabel.Location.Y - PasswordText.Height - 8);
                PasswordActive = 1;
                PasswordLabel.ForeColor = Color.DodgerBlue;
                PasswordPanel.BackColor = Color.DodgerBlue;
            }
            if (UserNameText.Text == "" && UserActive != 0)
            {
                UserActive = 0;
                UserLabel.Location = new System.Drawing.Point(UserLabel.Location.X, UserLabel.Location.Y + UserNameText.Height + 8);
                UserLabel.ForeColor = Color.White;
                UserPanel.BackColor = Color.White;
            }
            if (HostText.Text == "" && ServerActive != 0)
            {
                ServerActive = 0;
                HostLabel.Location = new System.Drawing.Point(HostLabel.Location.X, HostLabel.Location.Y + HostText.Height + 8);
                HostLabel.ForeColor = Color.White;
                ServerPanel.BackColor = Color.White;
            }
        }

        private void HostText_Click(object sender, EventArgs e)
        {
            if (ServerActive != 1)
            {
                HostLabel.Location = new System.Drawing.Point(HostLabel.Location.X, HostLabel.Location.Y - HostText.Height - 8);
                ServerActive = 1;
                HostLabel.ForeColor = Color.DodgerBlue;
                ServerPanel.BackColor = Color.DodgerBlue;
            }
            if (UserNameText.Text == "" && UserActive != 0)
            {
                UserActive = 0;
                UserLabel.Location = new System.Drawing.Point(UserLabel.Location.X, UserLabel.Location.Y + UserNameText.Height + 8);
                UserLabel.ForeColor = Color.White;
                UserPanel.BackColor = Color.White;
            }
            if (PasswordText.Text == "" && PasswordActive != 0)
            {
                PasswordActive = 0;
                PasswordLabel.Location = new System.Drawing.Point(PasswordLabel.Location.X, PasswordLabel.Location.Y + PasswordText.Height + 8);
                PasswordLabel.ForeColor = Color.White;
                PasswordPanel.BackColor = Color.White;
            }
        }

        private void MessageCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextTimer_Tick(object sender, EventArgs e)
        {
            if (UserNameText.Text != "" && UserActive != 1)
            {
                UserLabel.Location = new System.Drawing.Point(UserLabel.Location.X, UserLabel.Location.Y - UserNameText.Height - 8);
                UserActive = 1;
                UserLabel.ForeColor = Color.DodgerBlue;
                UserPanel.BackColor = Color.DodgerBlue;
            }
            if (PasswordText.Text != "" && PasswordActive != 1)
            {
                PasswordLabel.Location = new System.Drawing.Point(PasswordLabel.Location.X, PasswordLabel.Location.Y - PasswordText.Height - 8);
                PasswordActive = 1;
                PasswordLabel.ForeColor = Color.DodgerBlue;
                PasswordPanel.BackColor = Color.DodgerBlue;
            }
            if (HostText.Text != "" && ServerActive != 1)
            {
                HostLabel.Location = new System.Drawing.Point(HostLabel.Location.X, HostLabel.Location.Y - HostText.Height - 8);
                ServerActive = 1;
                HostLabel.ForeColor = Color.DodgerBlue;
                ServerPanel.BackColor = Color.DodgerBlue;
            }
        }
    }
}