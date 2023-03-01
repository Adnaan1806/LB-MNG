
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN_cancel = new System.Windows.Forms.Button();
            this.BTN_delete = new System.Windows.Forms.Button();
            this.BTN_update = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_price = new System.Windows.Forms.TextBox();
            this.TXT_qty = new System.Windows.Forms.TextBox();
            this.TXT_author = new System.Windows.Forms.TextBox();
            this.TXT_publ = new System.Windows.Forms.TextBox();
            this.TXT_name = new System.Windows.Forms.TextBox();
            this.TXT_date = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightYellow;
            this.label1.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // TXT_bookName
            // 
            this.TXT_bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_bookName.Location = new System.Drawing.Point(474, 174);
            this.TXT_bookName.Name = "TXT_bookName";
            this.TXT_bookName.Size = new System.Drawing.Size(233, 24);
            this.TXT_bookName.TabIndex = 1;
            this.TXT_bookName.TextChanged += new System.EventHandler(this.TXT_bookName_TextChanged);
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.BackColor = System.Drawing.Color.LightYellow;
            this.BTN_Refresh.FlatAppearance.BorderSize = 0;
            this.BTN_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Refresh.Location = new System.Drawing.Point(743, 170);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(91, 31);
            this.BTN_Refresh.TabIndex = 2;
            this.BTN_Refresh.Text = "Refresh";
            this.BTN_Refresh.UseVisualStyleBackColor = false;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 335);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.TXT_date);
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
            this.panel2.Controls.Add(this.TXT_author);
            this.panel2.Controls.Add(this.TXT_publ);
            this.panel2.Controls.Add(this.TXT_name);
            this.panel2.Location = new System.Drawing.Point(25, 550);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 356);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BTN_cancel
            // 
            this.BTN_cancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_cancel.FlatAppearance.BorderSize = 0;
            this.BTN_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_cancel.Location = new System.Drawing.Point(932, 289);
            this.BTN_cancel.Name = "BTN_cancel";
            this.BTN_cancel.Size = new System.Drawing.Size(108, 36);
            this.BTN_cancel.TabIndex = 14;
            this.BTN_cancel.Text = "Cancel";
            this.BTN_cancel.UseVisualStyleBackColor = false;
            this.BTN_cancel.Click += new System.EventHandler(this.BTN_cancel_Click);
            // 
            // BTN_delete
            // 
            this.BTN_delete.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_delete.FlatAppearance.BorderSize = 0;
            this.BTN_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_delete.Location = new System.Drawing.Point(792, 289);
            this.BTN_delete.Name = "BTN_delete";
            this.BTN_delete.Size = new System.Drawing.Size(108, 36);
            this.BTN_delete.TabIndex = 13;
            this.BTN_delete.Text = "Delete";
            this.BTN_delete.UseVisualStyleBackColor = false;
            this.BTN_delete.Click += new System.EventHandler(this.BTN_delete_Click);
            // 
            // BTN_update
            // 
            this.BTN_update.BackColor = System.Drawing.Color.DodgerBlue;
            this.BTN_update.FlatAppearance.BorderSize = 0;
            this.BTN_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_update.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_update.Location = new System.Drawing.Point(630, 289);
            this.BTN_update.Name = "BTN_update";
            this.BTN_update.Size = new System.Drawing.Size(116, 36);
            this.BTN_update.TabIndex = 12;
            this.BTN_update.Text = "Update";
            this.BTN_update.UseVisualStyleBackColor = false;
            this.BTN_update.Click += new System.EventHandler(this.BTN_update_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(615, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 28);
            this.label8.TabIndex = 11;
            this.label8.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(47, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Book Author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(46, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Book Publication";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(615, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(615, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Purchase Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(46, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Book Name";
            // 
            // TXT_price
            // 
            this.TXT_price.Location = new System.Drawing.Point(841, 204);
            this.TXT_price.Name = "TXT_price";
            this.TXT_price.Size = new System.Drawing.Size(215, 22);
            this.TXT_price.TabIndex = 5;
            // 
            // TXT_qty
            // 
            this.TXT_qty.Location = new System.Drawing.Point(841, 128);
            this.TXT_qty.Name = "TXT_qty";
            this.TXT_qty.Size = new System.Drawing.Size(215, 22);
            this.TXT_qty.TabIndex = 4;
            // 
            // TXT_author
            // 
            this.TXT_author.Location = new System.Drawing.Point(290, 127);
            this.TXT_author.Name = "TXT_author";
            this.TXT_author.Size = new System.Drawing.Size(215, 22);
            this.TXT_author.TabIndex = 2;
            // 
            // TXT_publ
            // 
            this.TXT_publ.Location = new System.Drawing.Point(290, 203);
            this.TXT_publ.Name = "TXT_publ";
            this.TXT_publ.Size = new System.Drawing.Size(215, 22);
            this.TXT_publ.TabIndex = 1;
            // 
            // TXT_name
            // 
            this.TXT_name.Location = new System.Drawing.Point(289, 46);
            this.TXT_name.Name = "TXT_name";
            this.TXT_name.Size = new System.Drawing.Size(215, 22);
            this.TXT_name.TabIndex = 0;
            // 
            // TXT_date
            // 
            this.TXT_date.Location = new System.Drawing.Point(841, 47);
            this.TXT_date.Name = "TXT_date";
            this.TXT_date.Size = new System.Drawing.Size(215, 22);
            this.TXT_date.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(288, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 1);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Location = new System.Drawing.Point(289, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 1);
            this.panel4.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Location = new System.Drawing.Point(290, 225);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(215, 1);
            this.panel5.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Location = new System.Drawing.Point(841, 69);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(215, 1);
            this.panel6.TabIndex = 19;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel7.Location = new System.Drawing.Point(840, 150);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(215, 1);
            this.panel7.TabIndex = 20;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel8.Location = new System.Drawing.Point(842, 226);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(215, 1);
            this.panel8.TabIndex = 21;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Yellow;
            this.panel9.Location = new System.Drawing.Point(474, 200);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(232, 1);
            this.panel9.TabIndex = 17;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.HotPink;
            this.panel10.Controls.Add(this.label2);
            this.panel10.Location = new System.Drawing.Point(398, 25);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(373, 93);
            this.panel10.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "View Books";
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1136, 931);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTN_Refresh);
            this.Controls.Add(this.TXT_bookName);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBook";
            this.Load += new System.EventHandler(this.ViewBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_bookName;
        private System.Windows.Forms.Button BTN_Refresh;
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
        private System.Windows.Forms.TextBox TXT_author;
        private System.Windows.Forms.TextBox TXT_publ;
        private System.Windows.Forms.TextBox TXT_name;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker TXT_date;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label2;
    }
}