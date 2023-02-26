
namespace Library_System
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_bookName = new System.Windows.Forms.TextBox();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXT_name = new System.Windows.Forms.TextBox();
            this.TXT_publ = new System.Windows.Forms.TextBox();
            this.TXT_author = new System.Windows.Forms.TextBox();
            this.TXT_date = new System.Windows.Forms.TextBox();
            this.TXT_qty = new System.Windows.Forms.TextBox();
            this.TXT_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BTN_update = new System.Windows.Forms.Button();
            this.BTN_delete = new System.Windows.Forms.Button();
            this.BTN_cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // TXT_bookName
            // 
            this.TXT_bookName.Location = new System.Drawing.Point(399, 182);
            this.TXT_bookName.Name = "TXT_bookName";
            this.TXT_bookName.Size = new System.Drawing.Size(233, 22);
            this.TXT_bookName.TabIndex = 1;
            this.TXT_bookName.TextChanged += new System.EventHandler(this.TXT_bookName_TextChanged);
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.Location = new System.Drawing.Point(646, 175);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(91, 37);
            this.BTN_Refresh.TabIndex = 2;
            this.BTN_Refresh.Text = "Refresh";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 111);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(969, 308);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.BTN_cancel);
            this.panel2.Controls.Add(this.BTN_delete);
            this.panel2.Controls.Add(this.BTN_update);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TXT_price);
            this.panel2.Controls.Add(this.TXT_qty);
            this.panel2.Controls.Add(this.TXT_date);
            this.panel2.Controls.Add(this.TXT_author);
            this.panel2.Controls.Add(this.TXT_publ);
            this.panel2.Controls.Add(this.TXT_name);
            this.panel2.Location = new System.Drawing.Point(34, 522);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 335);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "View Book";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(395, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TXT_name
            // 
            this.TXT_name.Location = new System.Drawing.Point(241, 45);
            this.TXT_name.Name = "TXT_name";
            this.TXT_name.Size = new System.Drawing.Size(215, 22);
            this.TXT_name.TabIndex = 0;
            // 
            // TXT_publ
            // 
            this.TXT_publ.Location = new System.Drawing.Point(241, 176);
            this.TXT_publ.Name = "TXT_publ";
            this.TXT_publ.Size = new System.Drawing.Size(215, 22);
            this.TXT_publ.TabIndex = 1;
            // 
            // TXT_author
            // 
            this.TXT_author.Location = new System.Drawing.Point(241, 113);
            this.TXT_author.Name = "TXT_author";
            this.TXT_author.Size = new System.Drawing.Size(215, 22);
            this.TXT_author.TabIndex = 2;
            // 
            // TXT_date
            // 
            this.TXT_date.Location = new System.Drawing.Point(699, 53);
            this.TXT_date.Name = "TXT_date";
            this.TXT_date.Size = new System.Drawing.Size(215, 22);
            this.TXT_date.TabIndex = 3;
            // 
            // TXT_qty
            // 
            this.TXT_qty.Location = new System.Drawing.Point(699, 116);
            this.TXT_qty.Name = "TXT_qty";
            this.TXT_qty.Size = new System.Drawing.Size(215, 22);
            this.TXT_qty.TabIndex = 4;
            // 
            // TXT_price
            // 
            this.TXT_price.Location = new System.Drawing.Point(699, 179);
            this.TXT_price.Name = "TXT_price";
            this.TXT_price.Size = new System.Drawing.Size(215, 22);
            this.TXT_price.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(47, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Book Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(506, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Purchase Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(505, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(47, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Book Publication";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(47, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Book Author";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(505, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Price";
            // 
            // BTN_update
            // 
            this.BTN_update.Location = new System.Drawing.Point(316, 237);
            this.BTN_update.Name = "BTN_update";
            this.BTN_update.Size = new System.Drawing.Size(116, 48);
            this.BTN_update.TabIndex = 12;
            this.BTN_update.Text = "Update";
            this.BTN_update.UseVisualStyleBackColor = true;
            this.BTN_update.Click += new System.EventHandler(this.BTN_update_Click);
            // 
            // BTN_delete
            // 
            this.BTN_delete.Location = new System.Drawing.Point(454, 237);
            this.BTN_delete.Name = "BTN_delete";
            this.BTN_delete.Size = new System.Drawing.Size(113, 48);
            this.BTN_delete.TabIndex = 13;
            this.BTN_delete.Text = "Delete";
            this.BTN_delete.UseVisualStyleBackColor = true;
            this.BTN_delete.Click += new System.EventHandler(this.BTN_delete_Click);
            // 
            // BTN_cancel
            // 
            this.BTN_cancel.Location = new System.Drawing.Point(587, 238);
            this.BTN_cancel.Name = "BTN_cancel";
            this.BTN_cancel.Size = new System.Drawing.Size(116, 47);
            this.BTN_cancel.TabIndex = 14;
            this.BTN_cancel.Text = "Cancel";
            this.BTN_cancel.UseVisualStyleBackColor = true;
            this.BTN_cancel.Click += new System.EventHandler(this.BTN_cancel_Click);
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(1038, 923);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_Refresh);
            this.Controls.Add(this.TXT_bookName);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ViewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBook";
            this.Load += new System.EventHandler(this.ViewBook_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_bookName;
        private System.Windows.Forms.Button BTN_Refresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN_cancel;
        private System.Windows.Forms.Button BTN_delete;
        private System.Windows.Forms.Button BTN_update;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_price;
        private System.Windows.Forms.TextBox TXT_qty;
        private System.Windows.Forms.TextBox TXT_date;
        private System.Windows.Forms.TextBox TXT_author;
        private System.Windows.Forms.TextBox TXT_publ;
        private System.Windows.Forms.TextBox TXT_name;
    }
}