using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS7
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double th1;
        double th2;
        double per1;
        double per2;
        double k;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(10, 200, 310, 100, -Math.PI / 2);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            th1 = double.Parse(comboBox1.Text)*Math.PI/180;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            per1 = double.Parse(comboBox3.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            th2 = double.Parse(comboBox2.Text) * Math.PI / 180;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            per2 = double.Parse(comboBox4.Text);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            k = double.Parse(comboBox5.Text);
        }

        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double x2 = x0 + leng * k * Math.Cos(th);
            double y2 = y0 + leng * k * Math.Sin(th);

            try
            {
                drawLine(x0, y0, x1, y1);
                drawLine(x0, y0, x1, y1);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error occured!");
            }

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2);
        }

        void drawLine(double x0,double y0,double x,double y)
        {
            graphics.DrawLine(
                Pens.Blue,
                (int)x0, (int)y0, (int)x, (int)y);
        }
    }
}
