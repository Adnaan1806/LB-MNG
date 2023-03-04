
namespace Library_System
{
    partial class IssueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBooks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mname = new System.Windows.Forms.TextBox();
            this.txt_MID = new System.Windows.Forms.TextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.comboBname = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_issue = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(34, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 442);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(70, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 28);
            this.textBox1.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(126, 285);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(162, 37);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search Member";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(47, 360);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(97, 37);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(258, 360);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(97, 37);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Member ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 140);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.Controls.Add(this.btn_issue);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.comboBname);
            this.panel2.Controls.Add(this.txt_email);
            this.panel2.Controls.Add(this.txt_num);
            this.panel2.Controls.Add(this.txt_MID);
            this.panel2.Controls.Add(this.txt_mname);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(453, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 442);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Member Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Member ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contact Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Book Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Book Issue Date";
            // 
            // txt_mname
            // 
            this.txt_mname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mname.Location = new System.Drawing.Point(266, 43);
            this.txt_mname.Name = "txt_mname";
            this.txt_mname.Size = new System.Drawing.Size(250, 24);
            this.txt_mname.TabIndex = 6;
            // 
            // txt_MID
            // 
            this.txt_MID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MID.Location = new System.Drawing.Point(266, 102);
            this.txt_MID.Name = "txt_MID";
            this.txt_MID.Size = new System.Drawing.Size(250, 24);
            this.txt_MID.TabIndex = 7;
            // 
            // txt_num
            // 
            this.txt_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num.Location = new System.Drawing.Point(266, 155);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(250, 24);
            this.txt_num.TabIndex = 8;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(266, 208);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(250, 24);
            this.txt_email.TabIndex = 9;
            // 
            // comboBname
            // 
            this.comboBname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBname.FormattingEnabled = true;
            this.comboBname.Location = new System.Drawing.Point(266, 263);
            this.comboBname.Name = "comboBname";
            this.comboBname.Size = new System.Drawing.Size(250, 26);
            this.comboBname.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(266, 320);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 24);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(392, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Maximum 3 books ";
            // 
            // btn_issue
            // 
            this.btn_issue.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_issue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_issue.Location = new System.Drawing.Point(389, 366);
            this.btn_issue.Name = "btn_issue";
            this.btn_issue.Size = new System.Drawing.Size(127, 31);
            this.btn_issue.TabIndex = 13;
            this.btn_issue.Text = "Issue Book";
            this.btn_issue.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightYellow;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(335, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 82);
            this.panel3.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(276, 54);
            this.label9.TabIndex = 0;
            this.label9.Text = "Issue Books";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // IssueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1049, 645);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IssueBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueBooks";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_issue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBname;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_MID;
        private System.Windows.Forms.TextBox txt_mname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
    }
}