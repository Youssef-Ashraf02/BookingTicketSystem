using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tickium
{
    public partial class booking : Form
    {
        private checkingout chout;////
        public booking()
        {
            InitializeComponent();
            comboBox1.Items.Add(new Item("category 1", 200m));
            comboBox1.Items.Add(new Item("category 2", 150m));
            comboBox1.Items.Add(new Item("category 3", 100m));
            ////
            comboBox2.Items.Add(new ticket(1));
            comboBox2.Items.Add(new ticket(2));
            comboBox2.Items.Add(new ticket(3));
            comboBox2.Items.Add(new ticket(4));
            comboBox2.Items.Add(new ticket(5));
            comboBox2.Items.Add(new ticket(6));
            comboBox2.Items.Add(new ticket(7));
            comboBox2.Items.Add(new ticket(8));
            comboBox2.Items.Add(new ticket(9));
            comboBox2.Items.Add(new ticket(10));

            chout = new checkingout();////
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item selectedItem = (Item)comboBox1.SelectedItem;
            MessageBox.Show($"Price of {selectedItem.Name}: {selectedItem.Price:C}");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string prices = comboBox1.Text;///
            string quantities = comboBox2.Text;///
            chout.Pric = prices.ToString();
            chout.Customtext = quantities.ToString();
            int total = chout.calculate();
            checkout co = new checkout(total);
            co.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            matches frm = new matches();
            frm.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ticket selectedquantity = (ticket)comboBox2.SelectedItem;
            MessageBox.Show($"you will get {selectedquantity.ticket_num} tickets");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}