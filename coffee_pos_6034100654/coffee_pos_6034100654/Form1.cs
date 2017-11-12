using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace coffee_pos_6034100654
{
    public partial class Form1 : Form
    {
        string file = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }

        private void menu_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            hot_btn();
            frappe_btn();
            ice_btn();
            show_menu();
        }

        private void Click(object sender, EventArgs e)
        {
          
        }

        private void status_list_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }
    


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void hot_Click(object sender, EventArgs e)
        {
            int price;
            if (menu_list.Text == "Espresso") { price = 35;price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Americano") { price = 35; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Latte") { price = 35; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Mocha") { price = 35; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Cappuccino") { price = 35; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Green Tea") { price = 20; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Cocoa") { price = 20; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Milk") { price = 20; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Milo") { price = 20; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Nescafe") { price = 20; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "NestcaTea") { price = 20; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Thai Tea") { price = 20; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "") { this.hot.Enabled = false; }

        }
        private void hot_btn()
        {
            string k;
            if (menu_list.Text == "Milk Tea") { k = "Milk Tea"; total_tb.Text = k.ToString(); hot.Enabled = false; }
            else if (menu_list.Text == "Lemon Tea") { k = "Lemon Tea"; total_tb.Text = k.ToString(); hot.Enabled = false; }
            else if (menu_list.Text == "Italian Soda") { k = "Italian Soda"; total_tb.Text = k.ToString(); hot.Enabled = false; }
            else if (menu_list.Text == "Red lime Soda") { k = "Red lime Soda"; total_tb.Text = k.ToString(); hot.Enabled = false; }
            else if (menu_list.Text == "Honey lime Soda") { k = "Honey lime Soda"; total_tb.Text = k.ToString(); hot.Enabled = false; }
            else hot.Enabled = true;
        }
        private void frappe_btn()
        {
            string k;
            if (menu_list.Text == "Americano") { k = "Americano"; total_tb.Text = k.ToString(); frappe.Enabled = false; }
            else if (menu_list.Text == "Italian Soda") { k = "Italian Soda"; total_tb.Text = k.ToString(); frappe.Enabled = false; }
            else if (menu_list.Text == "Red lime Soda") { k = "Red lime Soda"; total_tb.Text = k.ToString(); frappe.Enabled = false; }
            else if (menu_list.Text == "Honey lime Soda") { k = "Honey lime Soda"; total_tb.Text = k.ToString(); frappe.Enabled = false; }
            else frappe.Enabled = true;
        }
        private void ice_btn()
        {
            ice.Enabled = true;
        }
        private void show_menu()
        {
            string k;
            if (menu_list.Text == "Espresso") { k = "Espresso"; total_tb.Text = k.ToString(); }
            else if (menu_list.Text == "Americano") { k = "Americano"; total_tb.Text = k.ToString(); }
            else if (menu_list.Text == "Latte") { k = "Latte"; total_tb.Text = k.ToString(); }
            else if (menu_list.Text == "Mocha") { k = "Mocha"; total_tb.Text = k.ToString(); }
            else if (menu_list.Text == "Cappuccino") { k = "Cappuccino"; total_tb.Text = k.ToString(); }
            else if (menu_list.Text == "Green Tea") { k = "Green Tea"; total_tb.Text = k.ToString(); }
            else if (menu_list.Text == "Cocoa") { k = "Cocoa"; total_tb.Text = k.ToString(); }
            else if (menu_list.Text == "Milk") { k = "Milk"; total_tb.Text = k.ToString(); }
            else if (menu_list.Text == "Milo") { k = "Milo"; total_tb.Text = k.ToString(); }
            else if (menu_list.Text == "Nescafe") { k = "Nescafe"; total_tb.Text = k.ToString(); }
            else if (menu_list.Text == "NestcaTea") { k = "NestcaTea"; total_tb.Text = k.ToString(); }
        }
        private void total_tb_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void ice_Click(object sender, EventArgs e)
        {
            int price;
            if (menu_list.Text == "Espresso") { price = 45; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Americano") { price = 45; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Latte") { price = 45; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Mocha") { price = 45; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Cappuccino") { price = 45; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Green Tea") { price = 25; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Cocoa") { price = 25; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Milk") { price = 25; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Milo") { price = 25; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Nescafe") { price = 25; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "NestcaTea") { price = 25; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Italian Soda") { price = 25; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Red lime Soda") { price = 25; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Honey lime Soda") { price = 25; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Milk Tea") { price = 25; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Lemon Tea") { price = 25; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Thai Tea") { price = 25; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "") { this.ice.Enabled = false; }
        }

        private void frappe_Click(object sender, EventArgs e)
        {
            int price;
            if (menu_list.Text == "Espresso") { price = 50; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Latte") { price = 50; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Mocha") { price = 50; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Cappuccino") { price = 50; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Green Tea") { price = 30; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Thai Tea") { price = 30; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Cocoa") { price = 30; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Milk") { price = 30; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Milo") { price = 30; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Nescafe") { price = 30; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "NestcaTea") { price = 30; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Latte") { price = 30; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Lemon Tea") { price = 30; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "Milk Tea") { price = 30; price_tb.Text = price.ToString(); }
            else if (menu_list.Text == "") { this.frappe.Enabled = false; }
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            string product, price;
            product = menu_list.Text;
            price = price_tb.Text;
            string[] K = { product, price };
            ListViewItem item = new ListViewItem(K);
            listView1.Items.Add(item);
            total_tb.Clear();
            SumOfTotalPrice();
            price_tb.Clear();
            price_tb.Focus();
            if (price_tb.Text == "") { enter_btn.Enabled = false; }
            
        }
        private void SumOfTotalPrice()
        {
            int num1, num2, sum;
            num1 = int.Parse(price_tb.Text);
            num2 = int.Parse(sum_total.Text);
            sum = num1 + num2;
            sum_total.Text = sum.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            menu_list.Text = "";
        }
        float price;
        public string[] bill()
        {
            price = 0;
            string[] Jr = new string[listView1.Items.Count];
            int item = listView1.Items.Count;
            for (int i = 0; i < item; i++)
            {
                price += float.Parse(listView1.Items[i].SubItems[1].Text);
                Jr[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            sum_total.Text = price.ToString();
            return Jr;
        }
        public void save_bill()
        {
            string[] t1 = bill();
            string[] t2 = bill();
            string file_time = "Saved" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string file_bill = " Saved";
            file_bill += "\r\n";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                file_bill += t1[i] + new string(' ', 20) + t2[i]  + "\r\n";

            }
            file_bill += "\r\n";
            file_bill += "Total Price :" + sum_total.Text;
            File.WriteAllText(file + @"\" + file_time + ".txt", file_bill);
            sum_total.Text += file_bill + "\r\n" + "\r\n" + "\r\n" + "File Saved at" + t1 + @"\" + file + ".txt";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bill_tb_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void price_tb_TextChanged(object sender, EventArgs e)
        {
            enter_btn.Enabled = true;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            save_bill();
        }
    }
}
