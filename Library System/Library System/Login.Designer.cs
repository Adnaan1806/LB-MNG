
namespace Library_System
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
            this.TXT_password = new System.Windows.Forms.TextBox();
            this.TXT_username = new System.Windows.Forms.TextBox();
            this.BTN_login = new System.Windows.Forms.Button();
            this.BTN_signup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TXT_password
            // 
            this.TXT_password.Location = new System.Drawing.Point(294, 252);
            this.TXT_password.Name = "TXT_password";
            this.TXT_password.Size = new System.Drawing.Size(213, 22);
            this.TXT_password.TabIndex = 0;
            this.TXT_password.UseSystemPasswordChar = true;
            // 
            // TXT_username
            // 
            this.TXT_username.Location = new System.Drawing.Point(294, 196);
            this.TXT_username.Name = "TXT_username";
            this.TXT_username.Size = new System.Drawing.Size(213, 22);
            this.TXT_username.TabIndex = 1;
            // 
            // BTN_login
            // 
            this.BTN_login.Location = new System.Drawing.Point(294, 351);
            this.BTN_login.Name = "BTN_login";
            this.BTN_login.Size = new System.Drawing.Size(84, 32);
            this.BTN_login.TabIndex = 2;
            this.BTN_login.Text = "Login";
            this.BTN_login.UseVisualStyleBackColor = true;
            this.BTN_login.Click += new System.EventHandler(this.BTN_login_Click);
            // 
            // BTN_signup
            // 
            this.BTN_signup.Location = new System.Drawing.Point(419, 351);
            this.BTN_signup.Name = "BTN_signup";
            this.BTN_signup.Size = new System.Drawing.Size(88, 32);
            this.BTN_signup.TabIndex = 3;
            this.BTN_signup.Text = "Sign Up";
            this.BTN_signup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(195, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(195, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(342, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOGIN";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Khaki;
            this.checkBox1.Location = new System.Drawing.Point(294, 281);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_signup);
            this.Controls.Add(this.BTN_login);
            this.Controls.Add(this.TXT_username);
            this.Controls.Add(this.TXT_password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_password;
        private System.Windows.Forms.TextBox TXT_username;
        private System.Windows.Forms.Button BTN_login;
        private System.Windows.Forms.Button BTN_signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

