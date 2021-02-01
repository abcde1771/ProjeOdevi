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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void onay_Click(object sender, EventArgs e)
        {
            string kullaniciadi;
            SqlConnection sc = new SqlConnection("Data Source=DESKTOP-A46PBGT;Initial Catalog=mobilsirket;Integrated Security=True");
            sc.Open();
            SqlCommand q1 = new SqlCommand(" Select Sifre From MUSTERILER  WHERE ABONENO = '"+txtKullanici.Text+"'  ", sc);
            SqlCommand q2;
            SqlDataReader read = q1.ExecuteReader();
            if(txtSifre1.Text == txtSifre2.Text)
            {
                if (read.Read())
                {
                    read.Close();

                    q2 = new SqlCommand(" Update MUSTERILER SET SIFRE = '" + txtSifre1.Text + "' Where ABONENO = '" + txtKullanici.Text + "'", sc);
                    q2.ExecuteNonQuery();
                    MessageBox.Show("Sifre Basariyla Degisti.");
                    this.Close();
                }


                else MessageBox.Show("Gecersiz Kullanici Adi.");
                
            }

            else MessageBox.Show("Tekrar girilen sifre uyusmamaktadir.");
            sc.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
