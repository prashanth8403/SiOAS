using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlas
{
    public partial class PostViewForm : Form
    {
        static int i;
        private bool _dragging;
        private Point _offset;

        public string UserEmail { get; set; }
        public string Ledger { get; set; }

       
            private void PostView_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point
                    (currentScreenPos.X - _offset.X,
                     currentScreenPos.Y - _offset.Y);
            }
        }

        private void PostView_MouseDown(object sender, MouseEventArgs e)
        {
            _offset.X = e.X;
            _offset.Y = e.Y;
            _dragging = true;

        }

        private void PostView_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        public PostViewForm()
        {
            InitializeComponent();
        }

        private void MessageCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PostViewForm_Load(object sender, EventArgs e)
        {
                EmailLabel.Text = EmailLabel.Text + UserEmail;
                ResponseHash.Text = Ledger;
        }
    }
}
