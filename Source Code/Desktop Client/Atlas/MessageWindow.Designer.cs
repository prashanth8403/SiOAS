namespace Atlas
{
    partial class MessageWindow
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
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WindowHeader = new System.Windows.Forms.Label();
            this.MessageCloseButton = new System.Windows.Forms.Button();
            this.BodyPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BodyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BodyPanel.Controls.Add(this.button1);
            this.BodyPanel.Controls.Add(this.MessageLabel);
            this.BodyPanel.Controls.Add(this.panel1);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(500, 250);
            this.BodyPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(371, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.Color.White;
            this.MessageLabel.Location = new System.Drawing.Point(28, 89);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(135, 27);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = "Message Text";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.WindowHeader);
            this.panel1.Controls.Add(this.MessageCloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 50);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MessageWindow_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MessageWindow_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MessageWindow_MouseUp);
            // 
            // WindowHeader
            // 
            this.WindowHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WindowHeader.AutoSize = true;
            this.WindowHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowHeader.ForeColor = System.Drawing.Color.Silver;
            this.WindowHeader.Location = new System.Drawing.Point(2, 7);
            this.WindowHeader.Name = "WindowHeader";
            this.WindowHeader.Padding = new System.Windows.Forms.Padding(12);
            this.WindowHeader.Size = new System.Drawing.Size(98, 43);
            this.WindowHeader.TabIndex = 2;
            this.WindowHeader.Text = "SILICON";
            // 
            // MessageCloseButton
            // 
            this.MessageCloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MessageCloseButton.FlatAppearance.BorderSize = 0;
            this.MessageCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.MessageCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessageCloseButton.Font = new System.Drawing.Font("Marlett", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MessageCloseButton.ForeColor = System.Drawing.Color.White;
            this.MessageCloseButton.Location = new System.Drawing.Point(448, 0);
            this.MessageCloseButton.Name = "MessageCloseButton";
            this.MessageCloseButton.Size = new System.Drawing.Size(50, 50);
            this.MessageCloseButton.TabIndex = 0;
            this.MessageCloseButton.Text = "r";
            this.MessageCloseButton.UseVisualStyleBackColor = true;
            this.MessageCloseButton.Click += new System.EventHandler(this.MessageCloseButton_Click);
            // 
            // MessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.BodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageWindow";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MessageWindow_Load);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BodyPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MessageCloseButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label WindowHeader;
        private System.Windows.Forms.Button button1;
    }
}