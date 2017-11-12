namespace coffee_pos_6034100654
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu_list = new System.Windows.Forms.ComboBox();
            this.hot = new System.Windows.Forms.Button();
            this.ice = new System.Windows.Forms.Button();
            this.frappe = new System.Windows.Forms.Button();
            this.enter_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.total_tb = new System.Windows.Forms.TextBox();
            this.price_tb = new System.Windows.Forms.TextBox();
            this.sum_total = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 241);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menu_list
            // 
            this.menu_list.BackColor = System.Drawing.Color.NavajoWhite;
            this.menu_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menu_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_list.FormattingEnabled = true;
            this.menu_list.Items.AddRange(new object[] {
            "Espresso",
            "Americano",
            "Latte",
            "Mocha",
            "Cappuccino",
            "Green Tea",
            "Cocoa",
            "Milk",
            "Milk Tea",
            "LemonTea",
            "Milo",
            "Nescafe",
            "NestcaTea",
            "Italian Soda",
            "Red lime Soda",
            "Honey lime Soda"});
            this.menu_list.Location = new System.Drawing.Point(12, 259);
            this.menu_list.Name = "menu_list";
            this.menu_list.Size = new System.Drawing.Size(167, 28);
            this.menu_list.TabIndex = 1;
            this.menu_list.SelectedIndexChanged += new System.EventHandler(this.menu_list_SelectedIndexChanged);
            // 
            // hot
            // 
            this.hot.BackColor = System.Drawing.Color.NavajoWhite;
            this.hot.Enabled = false;
            this.hot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hot.Location = new System.Drawing.Point(264, 262);
            this.hot.Name = "hot";
            this.hot.Size = new System.Drawing.Size(78, 28);
            this.hot.TabIndex = 3;
            this.hot.Text = "Hot";
            this.hot.UseVisualStyleBackColor = false;
            this.hot.Click += new System.EventHandler(this.hot_Click);
            // 
            // ice
            // 
            this.ice.BackColor = System.Drawing.Color.NavajoWhite;
            this.ice.Enabled = false;
            this.ice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ice.Location = new System.Drawing.Point(348, 262);
            this.ice.Name = "ice";
            this.ice.Size = new System.Drawing.Size(69, 28);
            this.ice.TabIndex = 5;
            this.ice.Text = "Ice";
            this.ice.UseVisualStyleBackColor = false;
            this.ice.Click += new System.EventHandler(this.ice_Click);
            // 
            // frappe
            // 
            this.frappe.BackColor = System.Drawing.Color.NavajoWhite;
            this.frappe.Enabled = false;
            this.frappe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frappe.Location = new System.Drawing.Point(423, 262);
            this.frappe.Name = "frappe";
            this.frappe.Size = new System.Drawing.Size(72, 28);
            this.frappe.TabIndex = 6;
            this.frappe.Text = "Frappe";
            this.frappe.UseVisualStyleBackColor = false;
            this.frappe.Click += new System.EventHandler(this.frappe_Click);
            // 
            // enter_btn
            // 
            this.enter_btn.BackColor = System.Drawing.Color.NavajoWhite;
            this.enter_btn.Enabled = false;
            this.enter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_btn.Location = new System.Drawing.Point(500, 261);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(72, 29);
            this.enter_btn.TabIndex = 7;
            this.enter_btn.Text = "ตกลง";
            this.enter_btn.UseVisualStyleBackColor = false;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.NavajoWhite;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(792, 293);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(72, 56);
            this.clear_btn.TabIndex = 8;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // total_tb
            // 
            this.total_tb.BackColor = System.Drawing.Color.NavajoWhite;
            this.total_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_tb.Location = new System.Drawing.Point(12, 438);
            this.total_tb.Multiline = true;
            this.total_tb.Name = "total_tb";
            this.total_tb.ReadOnly = true;
            this.total_tb.Size = new System.Drawing.Size(206, 31);
            this.total_tb.TabIndex = 9;
            this.total_tb.Visible = false;
            this.total_tb.TextChanged += new System.EventHandler(this.total_tb_TextChanged);
            // 
            // price_tb
            // 
            this.price_tb.BackColor = System.Drawing.Color.NavajoWhite;
            this.price_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_tb.Location = new System.Drawing.Point(185, 259);
            this.price_tb.Multiline = true;
            this.price_tb.Name = "price_tb";
            this.price_tb.ReadOnly = true;
            this.price_tb.Size = new System.Drawing.Size(73, 31);
            this.price_tb.TabIndex = 10;
            this.price_tb.TextChanged += new System.EventHandler(this.price_tb_TextChanged);
            // 
            // sum_total
            // 
            this.sum_total.BackColor = System.Drawing.Color.NavajoWhite;
            this.sum_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum_total.Location = new System.Drawing.Point(656, 318);
            this.sum_total.Multiline = true;
            this.sum_total.Name = "sum_total";
            this.sum_total.ReadOnly = true;
            this.sum_total.Size = new System.Drawing.Size(130, 31);
            this.sum_total.TabIndex = 11;
            this.sum_total.Text = "0";
            this.sum_total.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(578, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 56);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(578, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(286, 275);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product";
            this.columnHeader1.Width = 143;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 142;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(656, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sum_total);
            this.Controls.Add(this.price_tb);
            this.Controls.Add(this.total_tb);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.frappe);
            this.Controls.Add(this.ice);
            this.Controls.Add(this.hot);
            this.Controls.Add(this.menu_list);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox menu_list;
        private System.Windows.Forms.Button hot;
        private System.Windows.Forms.Button ice;
        private System.Windows.Forms.Button frappe;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.TextBox total_tb;
        private System.Windows.Forms.TextBox price_tb;
        private System.Windows.Forms.TextBox sum_total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
    }
}

