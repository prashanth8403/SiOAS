using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Atlas
{
    public partial class Dashboard : Form
    {
        public MySqlConnection connect = new MySqlConnection("Server=34.66.24.15; DATABASE=quiz; UID=prashanth.kumar;PASSWORD=Hunter21#$%;");
        AnswerSet[] AnswerEntity;
        static int tx = 0, ResponseIndex = 0, QIndex = 0, QuestionIndex = 1, QuestionSerial = 1, QuestionValue = 0, GeneratorIndex = 0, SequenceIndex = 0;
        private int counter = 0, DurationLimit;
        public int passcode { get; set; }
        static int Duration = 0, QuestionCode;
        Random IndexGenerator = new Random();
        static int[] IndexSequence;
        static string Subject;
        static int finalswitchtemp = 1;
        static string UserNameString;
        static string UserEmailString;
        static int closure = 0;
        string test = "";

        /* System Control */
        public string UniversitySeatNumber { get; set; }
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        /**/
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int Reserved);
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            DashPanelLeft.Hide();
            DashPanelRight.Hide();
            DashPanelTop.Hide();
            DashPanelBottom.Hide();
            MainPanel.Hide();
            LoadPanel.Hide();
            
            try
            {
                LoadingForm _loadingform = new LoadingForm();
                _loadingform.Visible = true;
                connect.Open();
                string QuizQuery2 = "select * from data_misc where Passcode=" + passcode.ToString() + ";";
                MySqlCommand NewProcess2 = new MySqlCommand(QuizQuery2, connect);
                using (MySqlDataReader Reader = NewProcess2.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Duration = (int)Reader[2];
                        Subject = (string)Reader[1];
                        QuestionCode = (int)Reader[4];
                        DurationLimit = (int)Reader[5];
                        MessageWindow _message = new MessageWindow();
                        TimeSpan time = TimeSpan.FromSeconds(Duration);
                        _message.MessageData = "Subject : " + Subject + "\r\nDuration : " + time.ToString(@"hh\:mm\:ss") + " Hrs";
                        _message.Show();
                        //MessageBox.Show(Duration.ToString() + " " + Subject.ToString() + " " + QuestionCode.ToString() + " " + DurationLimit.ToString());
                    }
                }
                counter = Duration;
                //System.Threading.Thread.Sleep(4000);
                string QuestionValueQuery = "SELECT COUNT(*) FROM question_data where Code=" + QuestionCode.ToString() + ";";
                MySqlCommand process1 = new MySqlCommand(QuestionValueQuery, connect);
                QuestionValue = Convert.ToInt32(process1.ExecuteScalar());
                AnswerEntity = InitializeArray<AnswerSet>(QuestionValue);
                string query = "SELECT * FROM question_data where Code=" + QuestionCode.ToString() + ";";
                string q = "", O1 = "", O2 = "", O3 = "", O4 = "";
                int Anx = 0;
                //ResponseLabel.Text = QuestionIndex.ToString() + "/" + Convert.ToString(QuestionValue);
                MySqlCommand process = new MySqlCommand(query, connect);
                using (MySqlDataReader Reader = process.ExecuteReader())
                {
                    for (int x = 0; x < QuestionValue; x++)
                    {
                        if (Reader.HasRows)
                        {
                            Reader.Read();
                            q = Convert.ToString(Reader[2]);
                            O1 = Convert.ToString(Reader[3]);
                            O2 = Convert.ToString(Reader[4]);
                            O3 = Convert.ToString(Reader[5]);
                            O4 = Convert.ToString(Reader[6]);
                            Anx = Convert.ToInt32(Reader[7]);
                            AnswerEntity[x].AnswerLoad(q, O1, O2, O3, O4, Anx);
                        }
                    }
                }

                if (UniversitySeatNumber != "")
                {
                    string Details = "SELECT * FROM user_profile WHERE USN='" + UniversitySeatNumber + "'";
                    MySqlCommand DetailsProcess = new MySqlCommand(Details, connect);
                    using (MySqlDataReader Reader = DetailsProcess.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            Reader.Read();
                            UserNameString = (string)Reader["Name"];
                            UserEmailString = (string)Reader["Email"];
                        }
                    }
                }
                IndexSequence = new int[QuestionValue];
                /**/
                while (GeneratorIndex < QuestionValue)
                {
                    QIndex = IndexGenerator.Next(0, QuestionValue);
                    IndexSequence[GeneratorIndex] = QIndex;
                    if (AnswerEntity[QIndex].GeneratorQuery())
                    {
                        AnswerEntity[QIndex].GeneratorRegister();
                        GeneratorIndex++;
                    }
                }
                for (int i = 0; i < QuestionValue; i++)
                {
                    test += i + ">" + IndexSequence[i].ToString() + "\r\n";
                }
                //MessageBox.Show(test);
                /**/
                _loadingform.Hide();
                DashPanelLeft.Visible = true;
                DashPanelRight.Visible = true;
                DashPanelTop.Visible = true;
                DashPanelBottom.Visible = true;
                MainPanel.Visible = true;
                DashPanelLeft.Width = Convert.ToInt32(this.Width * 0.25);
                DashPanelRight.Width = Convert.ToInt32(this.Width * 0.15);
                DashPanelTop.Height = Convert.ToInt32(this.Height * 0.20);
                DashPanelBottom.Width = Convert.ToInt32(this.Width * 0.1);
                ResponseLabel.Text = QuestionSerial + "/" + QuestionValue.ToString();
                UserUsn.Text = UniversitySeatNumber.ToUpper();
                UserName.Text = UserNameString;
                DashboardTimer.Start();
                InternetTimer.Interval = 1000;
                DownTimer.Interval = 1000;
                DownTimer.Start();
                InternetTimer.Start();
                Timer.Text = counter.ToString();
            }
            catch (MySqlException MyEX)
            {
                MessageWindow messageWindow = new MessageWindow();
                messageWindow.MessageData = "System Error: Occured, Please Restart the Quiz";
                messageWindow.Show();
                System.Threading.Thread.Sleep(3000);
                Application.Exit();
            }
            connect.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (closure == 0)
            {
                switch (e.CloseReason)
                {
                    case CloseReason.UserClosing:
                        e.Cancel = true;
                        break;
                }
                MessageWindow message = new MessageWindow();
                message.MessageData = "ALT+F4, has been disabled.";
                message.Show();
                base.OnFormClosing(e);
            }
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

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

        private void InternetTimer_Tick(object sender, EventArgs e)
        {
            int Temp;
            if (InternetGetConnectedState(out Temp, 0))
            {
                ConnectionLabel.ForeColor = Color.ForestGreen;
                ConnectionLabel.Text = "OK";
            }
            else
            {
                ConnectionLabel.ForeColor = Color.Red;
                ConnectionLabel.Text = "ERROR";
            }
        }

        T[] InitializeArray<T>(int length) where T : new()
        {
            T[] array = new T[length];
            for (int i = 0; i < length; ++i)
            {
                array[i] = new T();
            }
            return array;
        }

        void AnswerInterfaceLoad(int i)
        {
            QuestionBox.Text = (QuestionSerial).ToString() + " ) " + AnswerEntity[i].QuestionQuery();
            Option1.Text = AnswerEntity[i].OptionQuery1();
            Option2.Text = AnswerEntity[i].OptionQuery2();
            Option3.Text = AnswerEntity[i].OptionQuery3();
            Option4.Text = AnswerEntity[i].OptionQuery4();
            if (AnswerEntity[i].ResponseQuery() != 0)
            {
                if (AnswerEntity[i].ResponseQuery() == 1)
                    Option1.Checked = true;
                else if (AnswerEntity[i].ResponseQuery() == 2)
                    Option2.Checked = true;
                else if (AnswerEntity[i].ResponseQuery() == 3)
                    Option3.Checked = true;
                else if (AnswerEntity[i].ResponseQuery() == 4)
                    Option4.Checked = true;
            }
            DashboardTimer.Stop();
        }

        private void DashboardTimer_Tick(object sender, EventArgs e)
        {
            if (SequenceIndex < QuestionValue)
                QIndex = IndexSequence[SequenceIndex];
            while (QuestionIndex <= QuestionValue)
            {
                if (QuestionSerial == 1)
                {
                    AnswerPreviousButton.Enabled = false;
                    AnswerPreviousButton.ForeColor = Color.Black;
                    AnswerPreviousButton.Cursor = Cursors.No;
                }
                else
                {
                    AnswerPreviousButton.Enabled = true;
                    AnswerPreviousButton.ForeColor = AnswerSubmitButton.ForeColor;
                    AnswerPreviousButton.Cursor = Cursors.Hand;
                }
                if (QuestionIndex == QuestionValue)
                {
                    AnswerSubmitButton.Text = "FINAL Submit";
                    AnswerSubmitButton.Width = 200;

                }
                else
                {
                    AnswerSubmitButton.Text = "Next";
                    AnswerSubmitButton.Width = 150;
                }
                AnswerInterfaceLoad(QIndex);
                AnswerEntity[QIndex].GeneratorRegister();
                break;
            }
            if (finalswitchtemp == 0)
            {
                AnswerSubmitButton.Enabled = false;
            }
            else
            {
                AnswerSubmitButton.Enabled = true;
            }
            if (tx == 1)
            {
                DashboardTimer.Stop();
            }
        }

        private void AnswerSubmitButton_Click(object sender, EventArgs e)
        {
            SequenceIndex++;

            if (QuestionIndex >= 1)
            {
                if (QuestionIndex <= QuestionValue)
                {
                    if (Option1.Checked)
                    {
                        AnswerEntity[QIndex].ResponseRegister(1);
                    }
                    else if (Option2.Checked)
                    {
                        AnswerEntity[QIndex].ResponseRegister(2);
                    }
                    else if (Option3.Checked)
                    {
                        AnswerEntity[QIndex].ResponseRegister(3);
                    }
                    else
                    {
                        if (Option4.Checked)
                        {
                            AnswerEntity[QIndex].ResponseRegister(4);
                        }
                    }
                }
            }
            if (QuestionIndex <= QuestionValue)
            {
                
                ResponseIndex++;
                QuestionSerial++;
                QuestionIndex++;
                if (QuestionSerial <= QuestionValue)
                    ResponseLabel.Text = QuestionSerial + "/" + QuestionValue.ToString();
            }
            if (QuestionIndex == QuestionValue + 1)
            {
                if ((Duration-counter) >= DurationLimit)
                {
                    ResponseSend();
                }
                else
                {
                    finalswitchtemp = 1;
                    DashboardTimer.Start();
                    if (QuestionSerial > 1)
                    {
                        SequenceIndex--;
                        QuestionSerial--;
                        QuestionIndex--;
                    }
                    MessageWindow _message = new MessageWindow();
                    TimeSpan time = TimeSpan.FromSeconds(DurationLimit);
                    TimeSpan time2 = TimeSpan.FromSeconds(DurationLimit-(Duration-counter));
                    _message.MessageData = "Cannot submit before " + time.ToString(@"hh\:mm\:ss") + " Min(s),\r\ntry after " + time2.ToString(@"hh\:mm\:ss") + " Min(s)";
                    _message.Show();
                }
            }
            Option1.Checked = false;
            Option2.Checked = false;
            Option3.Checked = false;
            Option4.Checked = false;
            DashboardTimer.Start();
        }

        public void ResponseSend()
        {
            tx = 0;
            DownTimer.Stop();
            try
            {
                int Marks = 0;
                string second, minute;
                string ResponseDataString = "[PUBLIC ACCESSOR]\r\n";
                int total = Duration - counter;
                int minutes = total / 60;
                int seconds = total % 60;
                int hours = minutes / 60;
                minutes = minutes % 60;
                second = seconds.ToString();
                minute = minutes.ToString();
                if (seconds < 10)
                {
                    second = "0" + second;
                }
                if (minutes < 10)
                {
                    minute = "0" + minute;
                }

                string ElapsedTimeString = Convert.ToString("0" + hours) + ":" + minute + ":" + second;
                string HtmlString = "<style>body{font-family:consolas;} a{font-size:15px; font-weight:500;}</style>";
                ResponseDataString += "[";
                ResponseDataString += "\"Elapsed Time\" : " + "\"" + ElapsedTimeString + "\"]\r\n[";
                for (int i = 0; i < QuestionValue; i++)
                {
                    HtmlString += "<h3>" +(i + 1).ToString() +" " +AnswerEntity[i].QuestionQuery()+"<h3>";
                    HtmlString += "<a>a) " +AnswerEntity[i].OptionQuery1() + "<a><br>";
                    HtmlString += "<a>b) " + AnswerEntity[i].OptionQuery2() + "<a><br>";
                    HtmlString += "<a>c) " + AnswerEntity[i].OptionQuery3() + "<a><br>";
                    HtmlString += "<a>d) " + AnswerEntity[i].OptionQuery4() + "<a><br>";
                    HtmlString += "<a> Response : option " + AnswerEntity[i].ResponseQuery() + "<a><br>";
                    HtmlString += "<a> Answer   : option " + AnswerEntity[i].AnswerQuery() + "<a><br>";
                    
                    ResponseDataString += "{" + "\r\n"
                        + "\"Question\":" + "\"" + Hashing(AnswerEntity[i].QuestionQuery()) + "\"" + ",\r\n"
                        + "\"Answer\":" + "\"" + Hashing(Convert.ToString(AnswerEntity[i].AnswerQuery())) + "\"" + ",\r\n"
                        + "\"Response\":" + "\"" + Hashing(Convert.ToString(AnswerEntity[i].ResponseQuery())) + "\"" + ",\r\n"
                        + "\"Valid\":";
                    if (AnswerEntity[i].Validation())
                    {
                        ResponseDataString += "\"" + Hashing("true" + i.ToString()) + "\"" + "\r\n";
                    }
                    else
                    {
                        ResponseDataString += "\"" + Hashing("false" + i.ToString()) + "\"" + "\r\n";
                    }
                    ResponseDataString += "}";
                    if (i != QuestionValue - 1)
                        ResponseDataString += ",";
                    if (AnswerEntity[i].Validation())
                    {
                        Marks++;
                    }
                }
                if (connect.State != ConnectionState.Open)
                    connect.Open();
                string InsertQuery = "INSERT INTO quiz.response_data (USN,Marks,Time,Hash,Email) VALUES ('" + UniversitySeatNumber + "'," + Marks + ",'" + ElapsedTimeString + "','" + Hashing(UniversitySeatNumber + Convert.ToString(Marks)) + "',1);" + "UPDATE quiz.user_misc SET Quiz = 0 where USN = '" + UniversitySeatNumber + "'; ";
                MySqlCommand FinalInsert = new MySqlCommand(InsertQuery, connect);
                FinalInsert.ExecuteNonQuery();
                /*
                string temp = "<style>h3{padding-top:350px;	font-family:Arial; font-size:28px;	text-align:center;} p{ font-family:Arial;font-size:25px; font-weight:600; float:left; padding-top:350px;} .marks {" +
               "float:right;" +
               "font-size:30px;" +
               "padding-top:350px;" +
               "}" +
               ".markstext{" +
               "font-size:50px;" +
               "}</style>" +
               "<h3>" + Subject + "</h3>";
                temp += "<p>" + UserNameString +
                    "<br>" + UserUsn.Text +
                    "<br>VTH SEMESTER" +
                    "<br><br>2019-20</p>";

                temp += "<table class=\"marks\">" +
                    "<tr><th>" +
                    "Marks Obtained" +
                    "</th></tr>" +
                    "<tr><th class=\"markstext\">" +
                    Marks.ToString() + "/" + QuestionValue.ToString() +
                    "</th></tr>" +
                    "</table>";
                var Renderer = new HtmlToPdf();
                var Renderer2 = new HtmlToPdf();
                var PDF1 = Renderer2.RenderHtmlAsPdf(temp);
                PDF1.AddBackgroundPdf(@"Data/foxy.pdf");
                PDF1.SaveAs("coverpage.pdf");
                Renderer.PrintOptions.FirstPageNumber = 1;
                Renderer.PrintOptions.Header.DrawDividerLine = true;
                Renderer.PrintOptions.Header.FontSize = 10;
                Renderer.PrintOptions.Header.FontFamily = "Helvetica,Arial";
                Renderer.PrintOptions.Header.RightText = "ROOK LABS";
                Renderer.PrintOptions.Header.LeftText = UserUsn.Text;
                Renderer.PrintOptions.Header.CenterText = Marks.ToString() + "/" + QuestionValue.ToString();
                Renderer.PrintOptions.Footer.DrawDividerLine = true;
                Renderer.PrintOptions.Footer.FontFamily = "Arial";
                Renderer.PrintOptions.Footer.FontSize = 10;
                Renderer.PrintOptions.Footer.LeftText = "{date} {time}";
                Renderer.PrintOptions.Footer.RightText = "{page} of {total-pages}";
                var PDF = Renderer.RenderHtmlAsPdf(HtmlString);

                PDF.SaveAs("RookLabs-27000156135-" + UserNameString + ".pdf");
                PdfDocument P4 = PdfDocument.FromFile("RookLabs-27000156135-" + UserNameString + ".pdf");
                
                var Pdfs = new List<PdfDocument>();
                Pdfs.Add(PdfDocument.FromFile("coverpage.pdf"));
                Pdfs.Add(PdfDocument.FromFile("RookLabs-27000156135-" + UserNameString + ".pdf"));
                PdfDocument Pdf = PdfDocument.Merge(Pdfs);

                Pdf.MetaData.Keywords = "Rook SiOAS";
                Pdf.MetaData.ModifiedDate = DateTime.Now;
                Pdf.Password = Hashing(passcode.ToString());
                //Pdf.Password = Hashing(Subject);
                Pdf.SaveAs("RookLabs-27000156135-" + UserNameString + ".pdf");
                */
                ResponseDataString += "]";
                System.IO.File.WriteAllText(@"Response.SU", "[" + Hashing(UniversitySeatNumber + Convert.ToString(Marks)) + "]\r\n" + "[" + Hashing(ResponseDataString) + "]" + "\r\n" + ResponseDataString);
  
                connect.Close();
                File.Delete(@"cover.pdf");
                PostViewForm _postview = new PostViewForm();
                _postview.Ledger = Hashing(UniversitySeatNumber + Convert.ToString(Marks));
                _postview.UserEmail = " " + UserEmailString;
                _postview.Show();
                closure = 1;
                this.Hide();
            }
            catch(MySqlException e)
            {
                MessageWindow _message = new MessageWindow();
                _message.MessageData = "Unexpected connectivity error.[" + e.Message + "]";
                _message.Show();
            }
            catch(Exception e)
            {
                MessageWindow _message = new MessageWindow();
                MessageBox.Show(e.Message);
                _message.MessageData = "Unexpected system error. ["+e.Message+"]";
                _message.Show();
            }
        }

        private void AnswerPreviousButton_Click(object sender, EventArgs e)
        {
            finalswitchtemp = 1;
            DashboardTimer.Start();
            if (QuestionSerial > 1)
            {
                SequenceIndex--;
                QuestionSerial--;
                QuestionIndex--;
            }
            if (QuestionSerial <= QuestionValue)
                ResponseLabel.Text = QuestionSerial + "/" + QuestionValue.ToString();
        }

        private void DownTimer_Tick(object sender, EventArgs e)
        {
            counter--;
            counterlabel.Text = counter.ToString();
            durationlab.Text = DurationLimit.ToString();
            if (counter == 0)
            {
                ResponseSend();
            }
            TimeSpan time = TimeSpan.FromSeconds(counter);
            Timer.Text = time.ToString(@"hh\:mm\:ss");
        }

        public static string Encryption(string strText)
        {
            var publicKey = "<RSAKeyValue><Modulus>21wEnTU+mcD2w0Lfo1Gv4rtcSWsQJQTNa6gio05AOkV/Er9w3Y13Ddo5wGtjJ19402S71HUeN0vbKILLJdRSES5MHSdJPSVrOqdrll/vLXxDxWs/U0UT1c8u6k/Ogx9hTtZxYwoeYqdhDblof3E75d9n2F0Zvf6iTb4cI7j6fMs=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

            var testData = Encoding.UTF8.GetBytes(strText);

            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    rsa.FromXmlString(publicKey.ToString());

                    var encryptedData = rsa.Encrypt(testData, true);

                    var base64Encrypted = Convert.ToBase64String(encryptedData);

                    return base64Encrypted;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        public static string Decryption(string strText)
        {
            var privateKey = "<RSAKeyValue><Modulus>21wEnTU+mcD2w0Lfo1Gv4rtcSWsQJQTNa6gio05AOkV/Er9w3Y13Ddo5wGtjJ19402S71HUeN0vbKILLJdRSES5MHSdJPSVrOqdrll/vLXxDxWs/U0UT1c8u6k/Ogx9hTtZxYwoeYqdhDblof3E75d9n2F0Zvf6iTb4cI7j6fMs=</Modulus><Exponent>AQAB</Exponent><P>/aULPE6jd5IkwtWXmReyMUhmI/nfwfkQSyl7tsg2PKdpcxk4mpPZUdEQhHQLvE84w2DhTyYkPHCtq/mMKE3MHw==</P><Q>3WV46X9Arg2l9cxb67KVlNVXyCqc/w+LWt/tbhLJvV2xCF/0rWKPsBJ9MC6cquaqNPxWWEav8RAVbmmGrJt51Q==</Q><DP>8TuZFgBMpBoQcGUoS2goB4st6aVq1FcG0hVgHhUI0GMAfYFNPmbDV3cY2IBt8Oj/uYJYhyhlaj5YTqmGTYbATQ==</DP><DQ>FIoVbZQgrAUYIHWVEYi/187zFd7eMct/Yi7kGBImJStMATrluDAspGkStCWe4zwDDmdam1XzfKnBUzz3AYxrAQ==</DQ><InverseQ>QPU3Tmt8nznSgYZ+5jUo9E0SfjiTu435ihANiHqqjasaUNvOHKumqzuBZ8NRtkUhS6dsOEb8A2ODvy7KswUxyA==</InverseQ><D>cgoRoAUpSVfHMdYXW9nA3dfX75dIamZnwPtFHq80ttagbIe4ToYYCcyUz5NElhiNQSESgS5uCgNWqWXt5PnPu4XmCXx6utco1UVH8HGLahzbAnSy6Cj3iUIQ7Gj+9gQ7PkC434HTtHazmxVgIR5l56ZjoQ8yGNCPZnsdYEmhJWk=</D></RSAKeyValue>";

            var testData = Encoding.UTF8.GetBytes(strText);

            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    var base64Encrypted = strText;

                    rsa.FromXmlString(privateKey);

                    var resultBytes = Convert.FromBase64String(base64Encrypted);
                    var decryptedBytes = rsa.Decrypt(resultBytes, true);
                    var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                    return decryptedData.ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }


    }
}