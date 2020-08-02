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
    public partial class InstructionForm : Form
    {

        static int i;
        private bool _dragging;
        private Point _offset;

        private void Instruction_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point
                    (currentScreenPos.X - _offset.X,
                     currentScreenPos.Y - _offset.Y);
            }
        }

        private void Instruction_MouseDown(object sender, MouseEventArgs e)
        {
            _offset.X = e.X;
            _offset.Y = e.Y;
            _dragging = true;

        }

        private void Instruction_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        public InstructionForm()
        {
            InitializeComponent();
        }

        private void InstructionForm_Load(object sender, EventArgs e)
        {
            ButtonNext.ForeColor = Color.White;
            ButtonNext.Enabled = false;

        }

        private void MessageCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AcceptCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (AcceptCheck.Checked == true)
            {
                ButtonNext.Enabled = true;
            }
            else
            {
                ButtonNext.Enabled = false;
            }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            Login _login = new Login();
            _login.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
