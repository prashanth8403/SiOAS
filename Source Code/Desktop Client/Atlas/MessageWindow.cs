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
    public partial class MessageWindow : Form
    {
        public string MessageData { get; set; }
        private bool _dragging;
        private Point _offset;
        private void MessageWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point
                    (currentScreenPos.X - _offset.X,
                     currentScreenPos.Y - _offset.Y);
            }
        }

        private void MessageWindow_MouseDown(object sender, MouseEventArgs e)
        {
            _offset.X = e.X;
            _offset.Y = e.Y;
            _dragging = true;

        }

        private void MessageWindow_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = MessageData;
        }

        private void MessageWindow_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        public MessageWindow()
        {
            InitializeComponent();
        }

        private void MessageCloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
