using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProjeOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string kAd;
        public string aboneNo;
        private void button1_Click(object sender, EventArgs e)
        {

            Form2 frm2 = new Form2();
            Form7 frm7 = new Form7();
            

            SqlConnection sc = new SqlConnection("Data Source=DESKTOP-A46PBGT;Initial Catalog=mobilsirket;Integrated Security=True");

            sc.Open();
            SqlCommand q1 = new SqlCommand("Select KULLANICIADI,SIFRE,ABONENO,ADMIN From MUSTERILER WHERE KULLANICIADI = '"+kullaniciAdi.Text+ "' AND SIFRE = '" + sifre.Text + "' ", sc);

            
            
            
            
            SqlDataReader read = q1.ExecuteReader();
            
            if (read.HasRows)
            {
                if (read.Read())
                {
                    if (read.GetInt32(3) == 0)
                    {
                        kAd = read.GetString(0);
                        frm2.setKullaniciAdi(kAd);
                        aboneNo = read.GetInt32(2).ToString();
                        frm2.setAbone(aboneNo);
                        this.Hide();
                        frm2.Show();
                    }
                    else
                    {
                        this.Hide();
                        frm7.Show();
                    }
                }
            }

            else
            {
                MessageBox.Show("Kullanici Adi veya Sifre Yanlis");
            }

            sc.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void unut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }
    }
}
