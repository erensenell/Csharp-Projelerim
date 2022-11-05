using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sinav_bildir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=data.mdb");
        OleDbCommand kmt = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet dtst = new DataSet();
        string[] dersadi = new string[10];
        string[] sinav_tarihi = new string[10];
        int r, g, b;
        Random rs = new Random();
        //Label[] labelDizi;
        public void sinavlar()
        {
            TimeSpan tfark;
            int i = 0;
            string gunfark;
            try
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "Select * from sinavbil";
                OleDbDataReader oku;
                oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    tfark = DateTime.Parse(DateTime.Now.ToLongDateString()) - DateTime.Parse(oku[1].ToString());
                    gunfark = tfark.TotalDays.ToString();
                    if (int.Parse(gunfark) == -1)
                    {

                        dersadi[i] = oku[0].ToString();
                        sinav_tarihi[i] = oku[1].ToString();
                        if (i == 0)
                        {
                            label3.Visible = true;
                            label3.Text = dersadi[i] + "      " + sinav_tarihi[i];

                        }
                        if (i == 1)
                        {
                            label4.Visible = true;
                            label4.Text = dersadi[i] + "      " + sinav_tarihi[i];
                        }
                        if (i == 2)
                        {
                            label5.Visible = true;
                            label5.Text = dersadi[i] + "      " + sinav_tarihi[i];
                        }
                        if (i == 3)
                        {
                            label6.Visible = true;
                            label6.Text = dersadi[i] + "      " + sinav_tarihi[i];
                        }

                        i++;
                    }
                }
                bag.Close();
                oku.Dispose();
            }
            catch
            {
                ;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            sinavlar();
            timer1.Enabled = true;
            timer1.Interval = 100;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "INSERT INTO sinavbil(DersAdi,SinavTarihi) VALUES ('" + textBox1.Text + "','" + dateTimePicker1.Text + "') ";
                    kmt.ExecuteNonQuery();
                    kmt.Dispose();
                    bag.Close();
                    textBox1.Clear();
                    sinavlar();
                    MessageBox.Show("Kayıt işlemi tamamlandı !");
                }
                else MessageBox.Show("Boş alanları doldurunuz !");
            }
            catch
            {
                ;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            r = rs.Next(256);
            g = rs.Next(256);
            b = rs.Next(256);
            label3.ForeColor = Color.FromArgb(r, g, b);
            label4.ForeColor = Color.FromArgb(r, g, b);
            label5.ForeColor = Color.FromArgb(r, g, b);
            label6.ForeColor = Color.FromArgb(r, g, b);
        }
    }
}
