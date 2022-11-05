using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication22
{
    public partial class Form1 : Form
    {
        double sayi1, sayi2, islem, deger, islemler, toplam;//"sayi1,sayi2,işlem,deger,islemler,toplam değerleri tanımladım"
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")//"sayı 0 ise"

         {
             textBox1.Text = "";//"textin içini boşaltım"    
            textBox1.Text = textBox1.Text + "1";//"textin içine 1 değerini atadım"

         }
        else
         {
                if (deger == 1)//" değer 1 ise "
                {
                    textBox1.Text = "";//"textin içi boşaltım"
                    textBox1.Text = textBox1.Text + "1";//""textin içine 1 değeri atadım"
                    deger = 0;//"değer 0"

                }
                else
                {
                    textBox1.Text = textBox1.Text + "1";//"textin içine 1 değerini atadım"
                }
         }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")//"sayı 0 ise"
            {
                textBox1.Text = "";//"textin içi boşaltım"
                textBox1.Text = textBox1.Text + "2";//"textin içine 2 değeri atadım"
            }
            else
            {
                if (deger == 1)//" değer 1 ise"
                {
                    textBox1.Text = "";//"textin içi boşaltım"
                    textBox1.Text = textBox1.Text + "2";//"textin içine 2 değerini atadım"
                    deger = 0;//"değer 0"
                }
                else
                {
                    textBox1.Text = textBox1.Text + "2";//"textin içine 2 değerini atadım"
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")//"sayı 0 ise"
                {
                    textBox1.Text = "";  //"textin içi boşaltım"
                    textBox1.Text = textBox1.Text + "3"; //"textin içine 3 değeri atadım"
                }
                else
                {
                    if (deger == 1)//" değer 1 ise"
                    {
                        textBox1.Text = ""; //"textin içi boşaltım"

                        textBox1.Text = textBox1.Text + "3";//"textin içine 3 değerini atadım"
                    
                        deger = 0;//"değer 0"
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "3";//"textin içine 3 değerni atadım"
                    }
                }
            }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")//"sayı 0 ise"
            {
                textBox1.Text = "";//"textin içi boşaltım"
                textBox1.Text = textBox1.Text + "4";//"textin içine 4 değerini atadım"
            }
            else
            {
                if (deger == 1)//" değer 1 ise"
                {
                    textBox1.Text = "";//"textin içi boşaltım"
                    textBox1.Text = textBox1.Text + "4";//"textin içine 4 değerini atadım"
                    deger = 0;//"değer 0"
                }
                else
                {
                    textBox1.Text = textBox1.Text + "4";//"textin içine 4 değerini atadım"
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")//"sayı 0 ise"
            {
                textBox1.Text = "";//"textin içi boşaltım"
                textBox1.Text = textBox1.Text + "5";//"textin içine 5 değeri atadım"
            }
            else
            {
                if (deger == 1)//" değer 1 ise "
                {
                    textBox1.Text = "";//"sayı 0 a eşitse"
                    textBox1.Text = textBox1.Text + "5";//"textin içine 5 değerini atadım"
                    deger = 0;//"değer 0"
                }
                else
                {
                    textBox1.Text = textBox1.Text + "5";//"textin içine 5 değerini atadım"
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")//"sayı 0 ise"
            {
                textBox1.Text = "";//"textin içi boşaltım"
                textBox1.Text = textBox1.Text + "6";//"textin içine 6 değerini atadım"
            }
            else
            {
                if (deger == 1)//" değer 1 ise"
                {
                    textBox1.Text = "";//"textin içi boşaltım"
                    textBox1.Text = textBox1.Text + "6";//"textin içine 6 değerini atadım"
                    deger = 0;//"değer 0"
                }
                else
                {
                    textBox1.Text = textBox1.Text + "6";//"textin içine 6 değerini atadım"
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
             if (textBox1.Text == "0")//"sayı 0 ise"
            {
                textBox1.Text = "";//"textin içi boşaltım"
                textBox1.Text = textBox1.Text + "8";//"textin içine 8 değerini atadım"
            }
            else
            {
                if (deger == 1)//" değer 1 ise"
                {
                    textBox1.Text = "";//"textin içi boşaltım"
                    textBox1.Text = textBox1.Text + "8";//"textin içine 8 değerini atadım"
                    deger = 0;//"değer 0"
                }
                else
                {
                    textBox1.Text = textBox1.Text + "8";//"textin içine 8 değerini atadım"
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")//"sayı 0 ise"
            {
                textBox1.Text = "";//"textin içi boşaltım"
                textBox1.Text = textBox1.Text + "7";//"textin içine 7 değeri atandı"
            }
            else
            {
                if (deger == 1)//" değer 1 ise"
                {
                    textBox1.Text = "";//"textin içi boşaltım"
                    textBox1.Text = textBox1.Text + "7";//"textin içine 7 değerini atadım"
                    deger = 0;//"değer 0"
                }
                else
                {
                    textBox1.Text = textBox1.Text + "7";//"textin içine 7 değerini atadım"
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")//"sayı 0 ise"
            {
                textBox1.Text = "";//"textin içi boşaltım"
                textBox1.Text = textBox1.Text + "9";//"textin içine 9 değerini atadım"
            }
            else
            {
                if (deger == 1)//" değer 1 ise"
                {
                    textBox1.Text = "";//"textin içi boşaltım"
                    textBox1.Text = textBox1.Text + "9";//"textin içine 9 değerini atadım"
                    deger = 0;//"değer 0"
                }
                else
                {
                    textBox1.Text = textBox1.Text + "9";//"textin içine 9 değerini atadım"
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")//"sayı 0 ise"
            {

            }
            else
            {
                if (deger == 1)//" değer 1 ise"
                {
                    textBox1.Text = "";//"textin içi boşaltım"
                    textBox1.Text = textBox1.Text + "0";//"textin içine 0 değerini atadım"
                    deger = 0;//"değer 0"
                }
                else
                {
                    textBox1.Text = textBox1.Text + "0";//"textin içine 0 değerini atadım"
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";//"form yüklendiğinde text içinde 0 olsun"
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double sayi, carpim;//"sayi,çarpım tanımladım"
            sayi = Convert.ToInt32(textBox1.Text);//"textte yazılanları sayıya çevirdim"
            carpim = sayi * -1;//"sayı -1 ile çarpıldı"
            textBox1.Text = carpim.ToString();//"yazılanı stringe çevirdim"
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";//"texte virgülü atadım"
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);//"sayı texte atandım"
            islem = 1;//"işleme 1 değeri atandı"
            deger = 1;//"değere 1 değeri atandı"
        }

        private void button17_Click(object sender, EventArgs e)
        {
               sayi2 = Convert.ToDouble(textBox1.Text);//"sayi2 textte atadım"
            if (islem == 1)//"işlem 1 ise"
            {
                islemler = sayi2 + sayi1;//"2 sayıyı topla"
            }

            if (islem == 2)//"işlem 2 ise"
            {
                islemler = sayi1 -sayi2;//"2 sayıyı çıkar"
            }

            if (islem == 3)//"işlem 3 ise"
            {
                islemler = sayi1 * sayi2;//"2 sayıyı çarp"
            }

            if (islem == 4)//"işlem 4 ise"
            {
                islemler = sayi1 / sayi2;//"2 sayıyı böl"
            }

            textBox1.Text = islemler.ToString();//"işlemleri stringe çevirdim"

        }

        private void button14_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);//"sayı texte atandı"
            islem = 2;//"işleme 2 değerini atadım"
            deger = 1;//"degere 1 degerini atadım"
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);//"sayı texte atandı"
            islem = 3;//"işleme 3 değeri atandı"
            deger = 1;//"degere 1 degeri atandı"
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);//"sayyı texte atadım"
            islem = 4;//"işleme 4 değerini atadım"
            deger = 1;//"degere 1 degerini atadım"
        }

        private void button18_Click(object sender, EventArgs e)
        {
            sayi1 = 0;//"sayı1 0 a eşitledim"
            sayi2 = 0;//"sayı2 0 a eşitledim"
            textBox1.Text = "";//"textin içini boşaltdım"
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";//"textin içini boşaltdım"
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double a, b;//"a,b degerleri tanımladım"
            a = Convert.ToDouble(textBox1.Text);//"textin içindekini sayıya çevirdim"
            b = Math.Sin(a);//"b yi sin(a) eşitledim"
            textBox1.Text = b.ToString();// "textin içindekini sayıya çevirdim"
            button24.Text = "sin";//"sin i  textin içine attım"




        
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double a, b;//"a,b degerleri tanımladım"
            a = Convert.ToDouble(textBox1.Text);//"textin içindekini sayıya çevirdik"
            b = Math.Sqrt(a);//"b yi sqrt(a) eşitledim"
            textBox1.Text = b.ToString();// "textin içindekini sayıya çevirdim"
            button24.Text = "sqrt";//"sqrt i textin içine attım"
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double a, b;//"a,b degerleri tanımladım"
            a = Convert.ToDouble(textBox1.Text);//"textin içindekini sayıya çevirdim"
            b = Math.Cos(a);//"b yi cos(a) eşitledim"
            textBox1.Text = b.ToString();// "textin içindekini sayıya çevirdim"
            button24.Text = "cos";//"cos ü textin içine attım"
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);//"sayıyı tanımlayıp texte yazdırdım"
            int faktoriyel = 1;//"faktöriyeli 1'e eşitledik"
            for (int i = sayi; i > 1; i--)//"i 1 den büyük ise i yi 1 azaltım"
            {
                faktoriyel = faktoriyel * i;//"i yi faktöriyelle çarptım"
            }
           textBox1.Text =  faktoriyel.ToString();//"faktöriyeli stringe çevirip textte yazdırdım"

            
         
          
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double a, b;//"a,b degerlerini tanımladım"
            a = Convert.ToDouble(textBox1.Text);//"textin içindekini sayıyı çevirdim"
            b = Math.Tan(a);//"b yi tan(a) eşitledim"
            textBox1.Text = b.ToString();// "textin içindekini sayıyı çevirdim"
            button24.Text = "tan";//"tan ı textin içine attım"
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double a, b;//"a,b degerlerini tanımladım"
            a = Convert.ToDouble(textBox1.Text);//"textin içindekini sayıyı çevirdim"
            b = Math.Log10(a);//"b yi log10(a) eşitledim"
            textBox1.Text = b.ToString();// "textin içindekini sayıyı çevirdim"
            button23.Text = "Log10";//"log10 u textin içine attım"
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double a, b;//"a,b degerlerini tanımladım"
            a = Convert.ToDouble(textBox1.Text);//"textin içindekini sayıyı çevirdim"
            b = Math.Log(a);//"b yi log(a) eşitledim"
            textBox1.Text = b.ToString();// "textin içindekini sayıyı çevirdim"
            button22.Text = "log";//"log u textin içine attım"
        }

       
    
        }


}
        
      

       

        

            
            
            
    



    
    
    
    
    
    
    
  