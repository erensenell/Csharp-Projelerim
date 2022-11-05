using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int sayı;
        int b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            timer3.Interval = 100;
            timer1.Interval = 100;
            timer1.Enabled = false;
            timer2.Interval = 1000;
            timer2.Enabled = false;
            label1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            button1.Enabled = false;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random a = new Random();
            sayı = a.Next(1,49);
            textBox1.Text = sayı.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            b++;
            label1.Text = b.ToString();
            if (b == 5)
                label3.Text =sayı.ToString();
            if (b == 10)
                label4.Text = sayı.ToString();
            if (b == 20)
                label5.Text = sayı.ToString();
            if (b == 30)
                label6.Text = sayı.ToString();
            if (b == 40)
                label7.Text = sayı.ToString();
            if (b == 50)
                label8.Text = sayı.ToString();
            if (b == 60)
                label9.Text = sayı.ToString();
            if (b == 60)
            {
                timer2.Enabled = false;
                timer1.Enabled = false;
                MessageBox.Show("sayısal loto çekilişimiz sona ermiştir kazanan nolar aşağıda belirtilmiştir");
                

            }   


            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label11.Text = label11.Text.Substring(1) + label11.Text.Substring(0, 1);
            
        }

       
    }
}
