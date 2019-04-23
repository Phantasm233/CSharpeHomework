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
    public partial class Form1 : Form
    {
        public static OrderService os = new OrderService();
        BindingList <Order> bs1;
        public Form1()
        {
            InitializeComponent();
            try
            {
                Customer jack = new Customer(1, "Jack");
                Customer bill = new Customer(2, "Bill");

                Goods pen = new Goods(1, "Pen", 150);
                Goods pencil = new Goods(2, "Pencil", 5.99);
                Goods notebook = new Goods(3, "Notebook", 15.59);

                OrderDetails orderDetails1 = new OrderDetails(1, pen, 15);
                OrderDetails orderDetails2 = new OrderDetails(2, pencil, 60);
                OrderDetails orderDetails3 = new OrderDetails(3, notebook, 50);

                Order order1 = new Order(1, jack);
                Order order2 = new Order(2, bill);
                Order order3 = new Order(3, bill);
                Order order4 = new Order(4, jack);
                order1.AddDetails(orderDetails1);
                order1.AddDetails(orderDetails2);
                order1.AddDetails(orderDetails3);
                //order1.AddOrderDetails(orderDetails3);
                order2.AddDetails(orderDetails2);
                order2.AddDetails(orderDetails3);
                order3.AddDetails(orderDetails3);
                order4.AddDetails(orderDetails1);
                order4.AddDetails(orderDetails3);

                os.Insert(order4);
                os.Insert(order1);
                os.Insert(order2);
                os.Insert(order3);

                bs1 = new BindingList<Order>(os.orderList);
            }
            catch(Exception e)
            {
                DialogResult result = MessageBox.Show("程序出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                dataGridView1.DataSource = bs1;
            }
            else
            {
                int Id = int.Parse(textBox1.Text);
                Order od = os.GetById(Id);
                if(od!=null)
                    dataGridView1.DataSource = od;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order obj = this.dataGridView1.CurrentRow.DataBoundItem as Order;
            os.Remove(obj.orderId);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
