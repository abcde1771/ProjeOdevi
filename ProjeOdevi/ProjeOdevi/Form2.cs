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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        Form1 frm1 = new Form1();
        public static string kullaniciadi;
        public static string abone;
        public static int musno;
        private void Form2_Load(object sender, EventArgs e)
        {

            SqlConnection sc = new SqlConnection("Data Source=DESKTOP-A46PBGT;Initial Catalog=mobilsirket;Integrated Security=True");
            sc.Open();
            SqlCommand q1 = new SqlCommand("Select (AD+' '+SOYAD) TAMAD From MUSTERILER WHERE KULLANICIADI = '" +kullaniciadi+"' ",sc);
            SqlCommand q2 = new SqlCommand("Select PAKETADI from MUSTERILER  INNER JOIN ABONELIK   on MUSTERILER.ABONENO = ABONELIK.ABONENO Where MUSTERILER.ABONENO = '" +abone+ "' ", sc);
            SqlCommand q3 = new SqlCommand("Select ABONETARIHI From MUSTERILER Where  KULLANICIADI = '" +kullaniciadi+ "'  ", sc);
            SqlCommand q4 = new SqlCommand("Select MUSNO from MUSTERILER WHERE KULLANICIADI = '" + kullaniciadi + "'", sc);

            DateTime adate;
            string formattedDate;


            SqlDataReader read = q1.ExecuteReader();
            if(read.Read())
                lblisim.Text = read.GetString(0);
            read.Close();

            read = q2.ExecuteReader();
            if (read.Read())
                lbltarife.Text = read.GetString(0);
            read.Close();

            read = q3.ExecuteReader();
            if (read.Read()) {
                adate = read.GetDateTime(0);
                formattedDate = adate.ToString("yyyy-MM-dd");
                lbltarih.Text = formattedDate;
            }
            read.Close();
            read = q4.ExecuteReader();
            if (read.Read())
                musno = read.GetInt32(0);
            read.Close();
            lblaboneNo.Text = abone;

            
            sc.Close();

        }

        public int getMusno()
        {
            return musno;
        }

        public string getAbone()
        {
            return abone;
        }

        public void setAbone(string v)
        {
            abone = v;
        }

        public void setKullaniciAdi(string v)
        {
            kullaniciadi = v;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            this.Hide();
            frm4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }
    }
}
