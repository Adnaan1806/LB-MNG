
namespace Library_System
{
    partial class Add_Member
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.TXT_id = new System.Windows.Forms.TextBox();
            this.TXT_Name = new System.Windows.Forms.TextBox();
            this.TXT_Contact = new System.Windows.Forms.TextBox();
            this.TXT_Email = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Location = new System.Drawing.Point(267, 357);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(98, 45);
            this.BTN_Clear.TabIndex = 4;
            this.BTN_Clear.Text = "Clear";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(381, 357);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(103, 45);
            this.BTN_Save.TabIndex = 5;
            this.BTN_Save.Text = "Save Details";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Location = new System.Drawing.Point(499, 357);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(94, 45);
            this.BTN_Exit.TabIndex = 6;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // TXT_id
            // 
            this.TXT_id.Location = new System.Drawing.Point(351, 65);
            this.TXT_id.Name = "TXT_id";
            this.TXT_id.Size = new System.Drawing.Size(189, 22);
            this.TXT_id.TabIndex = 7;
            // 
            // TXT_Name
            // 
            this.TXT_Name.Location = new System.Drawing.Point(351, 120);
            this.TXT_Name.Name = "TXT_Name";
            this.TXT_Name.Size = new System.Drawing.Size(189, 22);
            this.TXT_Name.TabIndex = 8;
            // 
            // TXT_Contact
            // 
            this.TXT_Contact.Location = new System.Drawing.Point(351, 177);
            this.TXT_Contact.Name = "TXT_Contact";
            this.TXT_Contact.Size = new System.Drawing.Size(189, 22);
            this.TXT_Contact.TabIndex = 9;
            // 
            // TXT_Email
            // 
            this.TXT_Email.Location = new System.Drawing.Point(351, 241);
            this.TXT_Email.Name = "TXT_Email";
            this.TXT_Email.Size = new System.Drawing.Size(189, 22);
            this.TXT_Email.TabIndex = 10;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Add_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXT_Email);
            this.Controls.Add(this.TXT_Contact);
            this.Controls.Add(this.TXT_Name);
            this.Controls.Add(this.TXT_id);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Member";
            this.Load += new System.EventHandler(this.Add_Member_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.TextBox TXT_id;
        private System.Windows.Forms.TextBox TXT_Name;
        private System.Windows.Forms.TextBox TXT_Contact;
        private System.Windows.Forms.TextBox TXT_Email;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}