namespace Atlas
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginMessageLabel = new System.Windows.Forms.Label();
            this.ControlLoginPanel = new System.Windows.Forms.Panel();
            this.HostLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ServerPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.HostText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.MessageCloseButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginTimer = new System.Windows.Forms.Timer(this.components);
            this.LoginPreviewPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ControlLoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.LoginPreviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginMessageLabel
            // 
            this.LoginMessageLabel.AutoSize = true;
            this.LoginMessageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LoginMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginMessageLabel.ForeColor = System.Drawing.Color.White;
            this.LoginMessageLabel.Location = new System.Drawing.Point(9, 768);
            this.LoginMessageLabel.Name = "LoginMessageLabel";
            this.LoginMessageLabel.Size = new System.Drawing.Size(72, 18);
            this.LoginMessageLabel.TabIndex = 1;
            this.LoginMessageLabel.Text = "Loading...";
            // 
            // ControlLoginPanel
            // 
            this.ControlLoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ControlLoginPanel.Controls.Add(this.HostLabel);
            this.ControlLoginPanel.Controls.Add(this.PasswordLabel);
            this.ControlLoginPanel.Controls.Add(this.UserLabel);
            this.ControlLoginPanel.Controls.Add(this.pictureBox3);
            this.ControlLoginPanel.Controls.Add(this.ServerPanel);
            this.ControlLoginPanel.Controls.Add(this.pictureBox4);
            this.ControlLoginPanel.Controls.Add(this.PasswordPanel);
            this.ControlLoginPanel.Controls.Add(this.pictureBox5);
            this.ControlLoginPanel.Controls.Add(this.UserPanel);
            this.ControlLoginPanel.Controls.Add(this.HostText);
            this.ControlLoginPanel.Controls.Add(this.PasswordText);
            this.ControlLoginPanel.Controls.Add(this.UserNameText);
            this.ControlLoginPanel.Controls.Add(this.MessageCloseButton);
            this.ControlLoginPanel.Controls.Add(this.LoginButton);
            this.ControlLoginPanel.Controls.Add(this.pictureBox2);
            this.ControlLoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlLoginPanel.Name = "ControlLoginPanel";
            this.ControlLoginPanel.Size = new System.Drawing.Size(460, 800);
            this.ControlLoginPanel.TabIndex = 2;
            this.ControlLoginPanel.Click += new System.EventHandler(this.ControlLoginPanel_Click);
            this.ControlLoginPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.ControlLoginPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.ControlLoginPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            // 
            // HostLabel
            // 
            this.HostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HostLabel.AutoSize = true;
            this.HostLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HostLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostLabel.ForeColor = System.Drawing.Color.White;
            this.HostLabel.Location = new System.Drawing.Point(87, 585);
            this.HostLabel.Name = "HostLabel";
            this.HostLabel.Size = new System.Drawing.Size(102, 24);
            this.HostLabel.TabIndex = 24;
            this.HostLabel.Text = "Passcode";
            this.HostLabel.Click += new System.EventHandler(this.HostLabel_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(87, 492);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(103, 24);
            this.PasswordLabel.TabIndex = 23;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserLabel.AutoSize = true;
            this.UserLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(87, 391);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(105, 24);
            this.UserLabel.TabIndex = 22;
            this.UserLabel.Text = "Username";
            this.UserLabel.Click += new System.EventHandler(this.UserLabel_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(36, 569);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // ServerPanel
            // 
            this.ServerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerPanel.BackColor = System.Drawing.Color.White;
            this.ServerPanel.Location = new System.Drawing.Point(36, 621);
            this.ServerPanel.Name = "ServerPanel";
            this.ServerPanel.Size = new System.Drawing.Size(383, 1);
            this.ServerPanel.TabIndex = 20;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(36, 473);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordPanel.BackColor = System.Drawing.Color.White;
            this.PasswordPanel.Location = new System.Drawing.Point(36, 525);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(383, 1);
            this.PasswordPanel.TabIndex = 18;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(36, 373);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // UserPanel
            // 
            this.UserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserPanel.BackColor = System.Drawing.Color.White;
            this.UserPanel.Location = new System.Drawing.Point(36, 426);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(383, 1);
            this.UserPanel.TabIndex = 16;
            // 
            // HostText
            // 
            this.HostText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HostText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.HostText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HostText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HostText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostText.ForeColor = System.Drawing.Color.White;
            this.HostText.Location = new System.Drawing.Point(91, 585);
            this.HostText.Name = "HostText";
            this.HostText.Size = new System.Drawing.Size(328, 23);
            this.HostText.TabIndex = 15;
            this.HostText.Click += new System.EventHandler(this.HostText_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswordText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.ForeColor = System.Drawing.Color.White;
            this.PasswordText.Location = new System.Drawing.Point(91, 492);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(328, 23);
            this.PasswordText.TabIndex = 14;
            this.PasswordText.Click += new System.EventHandler(this.PasswordText_Click);
            // 
            // UserNameText
            // 
            this.UserNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.UserNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserNameText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameText.ForeColor = System.Drawing.Color.White;
            this.UserNameText.Location = new System.Drawing.Point(91, 391);
            this.UserNameText.MaxLength = 10;
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(328, 23);
            this.UserNameText.TabIndex = 13;
            this.UserNameText.Click += new System.EventHandler(this.UserNameText_Click);
            // 
            // MessageCloseButton
            // 
            this.MessageCloseButton.FlatAppearance.BorderSize = 0;
            this.MessageCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.MessageCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessageCloseButton.Font = new System.Drawing.Font("Marlett", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MessageCloseButton.ForeColor = System.Drawing.Color.White;
            this.MessageCloseButton.Location = new System.Drawing.Point(420, 0);
            this.MessageCloseButton.Name = "MessageCloseButton";
            this.MessageCloseButton.Size = new System.Drawing.Size(40, 39);
            this.MessageCloseButton.TabIndex = 6;
            this.MessageCloseButton.Text = "r";
            this.MessageCloseButton.UseVisualStyleBackColor = true;
            this.MessageCloseButton.Click += new System.EventHandler(this.MessageCloseButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(36, 677);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(383, 56);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginTimer
            // 
            this.LoginTimer.Tick += new System.EventHandler(this.LoginTimer_Tick);
            // 
            // LoginPreviewPanel
            // 
            this.LoginPreviewPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.LoginPreviewPanel.Controls.Add(this.ControlLoginPanel);
            this.LoginPreviewPanel.Controls.Add(this.label1);
            this.LoginPreviewPanel.Controls.Add(this.LoginMessageLabel);
            this.LoginPreviewPanel.Controls.Add(this.pictureBox1);
            this.LoginPreviewPanel.Controls.Add(this.label2);
            this.LoginPreviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPreviewPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPreviewPanel.Name = "LoginPreviewPanel";
            this.LoginPreviewPanel.Size = new System.Drawing.Size(460, 800);
            this.LoginPreviewPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(35, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "Silicon- OAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-166, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 586);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(366, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "V1.0";
            // 
            // TextTimer
            // 
            this.TextTimer.Tick += new System.EventHandler(this.TextTimer_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(460, 375);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(460, 800);
            this.Controls.Add(this.LoginPreviewPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            this.ControlLoginPanel.ResumeLayout(false);
            this.ControlLoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.LoginPreviewPanel.ResumeLayout(false);
            this.LoginPreviewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LoginMessageLabel;
        private System.Windows.Forms.Panel ControlLoginPanel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Timer LoginTimer;
        private System.Windows.Forms.Panel LoginPreviewPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MessageCloseButton;
        private System.Windows.Forms.Timer TextTimer;
        private System.Windows.Forms.Label HostLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel ServerPanel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.TextBox HostText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

