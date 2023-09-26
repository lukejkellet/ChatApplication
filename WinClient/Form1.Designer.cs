using System.Net.Sockets;

namespace WinClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNick = new TextBox();
            Nick = new Label();
            btnSignIn = new Button();
            txtMessageHistory = new TextBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // txtNick
            // 
            txtNick.Location = new Point(49, 12);
            txtNick.Name = "txtNick";
            txtNick.Size = new Size(107, 23);
            txtNick.TabIndex = 0;
            txtNick.TextChanged += textBox1_TextChanged;
            // 
            // Nick
            // 
            Nick.AutoSize = true;
            Nick.Location = new Point(12, 15);
            Nick.Name = "Nick";
            Nick.Size = new Size(31, 15);
            Nick.TabIndex = 1;
            Nick.Text = "Nick";
            Nick.Click += label1_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(162, 12);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(75, 23);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            // 
            // txtMessageHistory
            // 
            txtMessageHistory.Location = new Point(11, 41);
            txtMessageHistory.Multiline = true;
            txtMessageHistory.Name = "txtMessageHistory";
            txtMessageHistory.ReadOnly = true;
            txtMessageHistory.ScrollBars = ScrollBars.Vertical;
            txtMessageHistory.Size = new Size(226, 195);
            txtMessageHistory.TabIndex = 3;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(12, 242);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(160, 23);
            txtMessage.TabIndex = 4;
            // 
            // btnSend
            // 
            btnSend.Enabled = false;
            btnSend.Location = new Point(178, 242);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(61, 23);
            btnSend.TabIndex = 5;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 277);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(txtMessageHistory);
            Controls.Add(btnSignIn);
            Controls.Add(Nick);
            Controls.Add(txtNick);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);

        }

        #endregion

        private TextBox txtNick;
        private Label Nick;
        private Button btnSignIn;
        private TextBox txtMessageHistory;
        private TextBox txtMessage;
        private Button btnSend;
    }
}