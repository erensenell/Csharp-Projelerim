using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{    
    public partial class Form1 : Form
         {
        int a = 0;  //değişkenlerimizi tanımlayalım
        int b = 6;  //a ve b değişkenini sınırlandırdık.


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int gs = Convert.ToInt16(label1.Text);//Labelları sayıya çevirme
            int ts = Convert.ToInt16(label3.Text);//Labelları yazıya çevirme
            ts++;
            label3.Text = Convert.ToString(ts); //Labelları sayıya çevirme
            if (ts == 59)
            {
                label3.Text = "0";
                gs ++;
                label1.Text = Convert.ToString(gs);//Labelları yazıya çevirme
                if (gs  == 59)
                {
                    label1.Text = "0";
                    int blk = Convert.ToInt16(label4.Text); //Labelları sayıya çevirme
                    blk++;
                    label4.Text = Convert.ToString(blk); //Labelları yazıya çevirme
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); //timer1'ri çalıştırıyoruz
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop(); //Timer1'ri durduruyoruz.
            listBox1.Items.Add(label4.Text + ":" + label1.Text + ":" + label3.Text); // aralarına iki nokta üst üste koyuyoruz.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0"; //öncelikle süreyi 0'a eşitliyoruz
            label3.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            a++;
            if (a == 1)
            {
                label1.ForeColor = Color.Yellow; //Süre Labellarını renklendirme
            }
            else if (a == 2)
            {
                label1.ForeColor = Color.Blue;
                label2.ForeColor = Color.Yellow; //Süre Labellarını renklendirme
            }
            else if (a == 3)
            {
                label1.ForeColor = Color.Blue;
                label2.ForeColor = Color.Blue; //Süre Labellarını renklendirme
                label3.ForeColor = Color.Yellow;
            }
            else if (a == 4)
            {
                label1.ForeColor = Color.Blue;
                label2.ForeColor = Color.Blue; //Süre Labellarını renklendirme
                label3.ForeColor = Color.Blue;
                label4.ForeColor = Color.Yellow;
            }
            else if (a == 5)
            {
                label1.ForeColor = Color.Blue;
                label2.ForeColor = Color.Blue;
                label3.ForeColor = Color.Blue; //Süre Labellarını renklendirme
                label4.ForeColor = Color.Blue;
                label5.ForeColor = Color.Yellow;
                b = 6;
                timer2.Stop();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Start(); //süreyi başlatma

        }



        private void timer3_Tick(object sender, EventArgs e)
        {
            b--;
            if (b == 5)
            {
                label5.ForeColor = Color.Yellow; //Süre Labellarını renklendirme 
            }
            else if (b == 4)
            {
                label5.ForeColor = Color.Blue; //Süre Labellarını renklendirme 
                label4.ForeColor = Color.Yellow;
            }
            else if (b == 3)
            {
                label5.ForeColor = Color.Blue;
                label4.ForeColor = Color.Blue; //Süre Labellarını renklendirme 
                label3.ForeColor = Color.Yellow;
            }
            else if (b == 2)
            {
                label5.ForeColor = Color.Blue;
                label4.ForeColor = Color.Blue;
                label3.ForeColor = Color.Blue; //Süre Labellarını renklendirme 
                label2.ForeColor = Color.Yellow;
            }
            else if (b == 1)
            {
                label5.ForeColor = Color.Blue;
                label4.ForeColor = Color.Blue; //Süre Labellarını renklendirme
                label3.ForeColor = Color.Blue;
                label2.ForeColor = Color.Blue;
                label1.ForeColor = Color.Yellow;
                a = 0;
                timer2.Stop(); //Süreyi durduruyoruz
            }
        }

        private void Form1_Loagösteid(object sender, EventArgs e)
        {

        }
    }
}
