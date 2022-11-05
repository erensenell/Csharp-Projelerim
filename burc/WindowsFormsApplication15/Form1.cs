using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string burc; //hangi değişkenleri kullancaksak onları tanıtıyoz 
            int gun, ay;

            gun = int.Parse (textBox1.Text);  //text kutularını gün ve ay olarak tanıtıyoz
            ay = int.Parse (textBox2.Text);
            burc = label4.Text;

            if (gun >= 20 && gun <= 30 && ay == 1) // gün ve ay textlerine girilen tarihlere göre Burcları yazdırıyor.
                                                   //diğer komutlar içinde geçerli.
            
                    label4.Text = "Kova";
            else if (gun >= 1 && gun <= 20 && ay == 2)
            
                    label4.Text = "Kova";
             

            if (gun >= 19 && gun <= 29 && ay == 2)

                label4.Text = "Balık";
            else if (gun >= 1 && gun <= 21 && ay == 3)

                label4.Text = "Balık";


            if (gun >= 22 && gun <= 31 && ay == 3)

                label4.Text = "Koç";
            else if (gun >= 1 && gun <= 21 && ay == 4)

                label4.Text = "Koç";



            if (gun >= 22 && gun <= 30 && ay == 4)

                label4.Text = "Boğa";
            else if (gun >= 1 && gun <= 21 && ay == 5)

                label4.Text = "Boğa";


            if (gun >= 22 && gun <= 31 && ay == 5)

                label4.Text = "İkizler";
            else if (gun >= 1 && gun <= 22 && ay == 6)

                label4.Text = "İkizler";


            if (gun >= 23 && gun <= 30 && ay == 6)

                label4.Text = "Yengeç";
            else if (gun >= 1 && gun <= 25 && ay == 7)

                label4.Text = "Yengeç";


            if (gun >= 26 && gun <= 31 && ay == 7)

                label4.Text = "Başak";
            else if (gun >= 1 && gun <= 24 && ay == 8)

                label4.Text = "Başak";


            if (gun >= 25 && gun <= 31 && ay == 8)

                label4.Text = "Terazi";
            else if (gun >= 1 && gun <= 24 && ay == 9)

                label4.Text = "Terazi";



            if (gun >= 25 && gun <= 31 && ay == 9)

                label4.Text = "Akrep";
            else if (gun >= 1 && gun <= 23 && ay == 10)

                label4.Text = "Akrep";


            if (gun >= 24 && gun <= 30 && ay == 10)

                label4.Text = "Yay";
            else if (gun >= 1 && gun <= 22 && ay == 11)

                label4.Text = "Yay";


            if (gun >= 23 && gun <= 31 && ay == 11)

                label4.Text = "Oğlak";
            else if (gun >= 1 && gun <= 21 && ay == 12)

                label4.Text = "Oğlak";

            if (gun >= 22 && gun <= 31 && ay == 12)

                label4.Text = "Aslan";
            else if (gun >= 1 && gun <= 19 && ay == 1)

                label4.Text = "Aslan";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
