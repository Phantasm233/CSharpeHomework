using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS5;

namespace CS8
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(int.Parse(textBox2.Text), textBox3.Text);
            Goods goods = new Goods(int.Parse(textBox5.Text), textBox6.Text, double.Parse(textBox7.Text));
            OrderDetails detail = new OrderDetails(int.Parse(textBox4.Text), goods, int.Parse(textBox8.Text));
            Order od = new Order(int.Parse(textBox1.Text), customer);
            od.AddDetails(detail);
            Form1.os.Modify(int.Parse(textBox1.Text), od);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
    }
}
