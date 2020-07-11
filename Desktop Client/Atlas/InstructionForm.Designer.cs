namespace Atlas
{
    partial class InstructionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionForm));
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AcceptCheck = new System.Windows.Forms.CheckBox();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WindowHeader = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.MessageCloseButton = new System.Windows.Forms.Button();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.White;
            this.BodyPanel.Controls.Add(this.label3);
            this.BodyPanel.Controls.Add(this.label2);
            this.BodyPanel.Controls.Add(this.label1);
            this.BodyPanel.Controls.Add(this.pictureBox1);
            this.BodyPanel.Controls.Add(this.AcceptCheck);
            this.BodyPanel.Controls.Add(this.ButtonNext);
            this.BodyPanel.Controls.Add(this.panel1);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(559, 800);
            this.BodyPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 180);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "1. Test consists of 40 Questions and to be \r\n    answered in 60 min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(193, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "INSTRUCTIONS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AcceptCheck
            // 
            this.AcceptCheck.AutoSize = true;
            this.AcceptCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptCheck.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AcceptCheck.Location = new System.Drawing.Point(27, 434);
            this.AcceptCheck.Name = "AcceptCheck";
            this.AcceptCheck.Size = new System.Drawing.Size(508, 33);
            this.AcceptCheck.TabIndex = 1;
            this.AcceptCheck.Text = "I Agree and accept all the terms and conditions.";
            this.AcceptCheck.UseVisualStyleBackColor = true;
            this.AcceptCheck.CheckedChanged += new System.EventHandler(this.AcceptCheck_CheckedChanged);
            // 
            // ButtonNext
            // 
            this.ButtonNext.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNext.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext.ForeColor = System.Drawing.Color.White;
            this.ButtonNext.Location = new System.Drawing.Point(221, 488);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(143, 45);
            this.ButtonNext.TabIndex = 2;
            this.ButtonNext.Text = "Continue >>";
            this.ButtonNext.UseVisualStyleBackColor = false;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.WindowHeader);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.MessageCloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 50);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Instruction_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Instruction_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Instruction_MouseUp);
            // 
            // WindowHeader
            // 
            this.WindowHeader.AutoSize = true;
            this.WindowHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.WindowHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowHeader.ForeColor = System.Drawing.Color.White;
            this.WindowHeader.Location = new System.Drawing.Point(0, 0);
            this.WindowHeader.Name = "WindowHeader";
            this.WindowHeader.Padding = new System.Windows.Forms.Padding(12);
            this.WindowHeader.Size = new System.Drawing.Size(113, 48);
            this.WindowHeader.TabIndex = 2;
            this.WindowHeader.Text = "SILICON";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Marlett", 13.8F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(459, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // MessageCloseButton
            // 
            this.MessageCloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MessageCloseButton.FlatAppearance.BorderSize = 0;
            this.MessageCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.MessageCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessageCloseButton.Font = new System.Drawing.Font("Marlett", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MessageCloseButton.ForeColor = System.Drawing.Color.White;
            this.MessageCloseButton.Location = new System.Drawing.Point(509, 0);
            this.MessageCloseButton.Name = "MessageCloseButton";
            this.MessageCloseButton.Size = new System.Drawing.Size(50, 50);
            this.MessageCloseButton.TabIndex = 4;
            this.MessageCloseButton.Text = "r";
            this.MessageCloseButton.UseVisualStyleBackColor = true;
            this.MessageCloseButton.Click += new System.EventHandler(this.MessageCloseButton_Click);
            // 
            // InstructionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 800);
            this.Controls.Add(this.BodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstructionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instruction";
            this.Load += new System.EventHandler(this.InstructionForm_Load);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WindowHeader;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button MessageCloseButton;
        private System.Windows.Forms.CheckBox AcceptCheck;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}