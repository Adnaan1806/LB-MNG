
namespace Library_System
{
    partial class ViewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMember));
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_Id = new System.Windows.Forms.TextBox();
            this.TXT_name = new System.Windows.Forms.TextBox();
            this.TXT_Email = new System.Windows.Forms.TextBox();
            this.TXT_contact = new System.Windows.Forms.TextBox();
            this.BTN_update = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightYellow;
            this.label1.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member ID";
            // 
            // TXT_Search
            // 
            this.TXT_Search.Location = new System.Drawing.Point(484, 162);
            this.TXT_Search.Name = "TXT_Search";
            this.TXT_Search.Size = new System.Drawing.Size(215, 22);
            this.TXT_Search.TabIndex = 2;
            this.TXT_Search.TextChanged += new System.EventHandler(this.TXT_Search_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightYellow;
            this.button1.Location = new System.Drawing.Point(749, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 347);
            this.dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Member ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Member Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // TXT_Id
            // 
            this.TXT_Id.Location = new System.Drawing.Point(328, 81);
            this.TXT_Id.Name = "TXT_Id";
            this.TXT_Id.Size = new System.Drawing.Size(250, 22);
            this.TXT_Id.TabIndex = 9;
            // 
            // TXT_name
            // 
            this.TXT_name.Location = new System.Drawing.Point(329, 126);
            this.TXT_name.Name = "TXT_name";
            this.TXT_name.Size = new System.Drawing.Size(250, 22);
            this.TXT_name.TabIndex = 10;
            // 
            // TXT_Email
            // 
            this.TXT_Email.Location = new System.Drawing.Point(328, 225);
            this.TXT_Email.Name = "TXT_Email";
            this.TXT_Email.Size = new System.Drawing.Size(250, 22);
            this.TXT_Email.TabIndex = 11;
            // 
            // TXT_contact
            // 
            this.TXT_contact.Location = new System.Drawing.Point(329, 175);
            this.TXT_contact.Name = "TXT_contact";
            this.TXT_contact.Size = new System.Drawing.Size(250, 22);
            this.TXT_contact.TabIndex = 12;
            // 
            // BTN_update
            // 
            this.BTN_update.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_update.FlatAppearance.BorderSize = 0;
            this.BTN_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_update.ForeColor = System.Drawing.Color.White;
            this.BTN_update.Location = new System.Drawing.Point(114, 295);
            this.BTN_update.Name = "BTN_update";
            this.BTN_update.Size = new System.Drawing.Size(103, 36);
            this.BTN_update.TabIndex = 13;
            this.BTN_update.Text = "Update";
            this.BTN_update.UseVisualStyleBackColor = false;
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_Delete.FlatAppearance.BorderSize = 0;
            this.BTN_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Delete.ForeColor = System.Drawing.Color.White;
            this.BTN_Delete.Location = new System.Drawing.Point(272, 295);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(103, 36);
            this.BTN_Delete.TabIndex = 14;
            this.BTN_Delete.Text = "Delete";
            this.BTN_Delete.UseVisualStyleBackColor = false;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_Cancel.FlatAppearance.BorderSize = 0;
            this.BTN_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cancel.ForeColor = System.Drawing.Color.White;
            this.BTN_Cancel.Location = new System.Drawing.Point(423, 295);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(103, 36);
            this.BTN_Cancel.TabIndex = 15;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(281, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 105);
            this.panel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(420, 68);
            this.label6.TabIndex = 0;
            this.label6.Text = "View Members";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BTN_Cancel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BTN_Delete);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.BTN_update);
            this.panel2.Controls.Add(this.TXT_Id);
            this.panel2.Controls.Add(this.TXT_contact);
            this.panel2.Controls.Add(this.TXT_name);
            this.panel2.Controls.Add(this.TXT_Email);
            this.panel2.Location = new System.Drawing.Point(20, 543);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 370);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Location = new System.Drawing.Point(330, 247);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(248, 1);
            this.panel6.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Location = new System.Drawing.Point(330, 197);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 1);
            this.panel5.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Location = new System.Drawing.Point(331, 148);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 1);
            this.panel4.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(329, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 1);
            this.panel3.TabIndex = 18;
            // 
            // ViewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1118, 933);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXT_Search);
            this.Controls.Add(this.label1);
            this.Name = "ViewMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewMember";
            this.Load += new System.EventHandler(this.ViewMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_Id;
        private System.Windows.Forms.TextBox TXT_name;
        private System.Windows.Forms.TextBox TXT_Email;
        private System.Windows.Forms.TextBox TXT_contact;
        private System.Windows.Forms.Button BTN_update;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}