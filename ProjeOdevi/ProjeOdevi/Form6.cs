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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        Form2 frm2 = new Form2();
        private void btnInternet_Click(object sender, EventArgs e)
        {
            int data = Convert.ToInt32(txtData.Text);
            DateTime now = DateTime.Now;
            SqlConnection sc = new SqlConnection("Data Source=DESKTOP-FD8GEC9\\SQLEXPRESS;Initial Catalog=mobilsirket;Integrated Security=True");
            sc.Open();

            SqlCommand q1 = new SqlCommand("UPDATE ABONELIK SET DATA = DATA - "+data+" WHERE ABONENO = '"+frm2.getAbone()+"' ", sc);
            q1.ExecuteNonQuery();
            //2 query calistirilamiyor

            SqlCommand q2 = new SqlCommand("INSERT INTO KULLANIM(TUR,MIKTAR,MUSNO, TARIH) VALUES (0, " + data + ", " + frm2.getMusno() + ", '"+now+"')", sc); 
            q2.ExecuteNonQuery();

            sc.Close();

        }

        private void btnDakika_Click(object sender, EventArgs e)
        {
            int dakika = Convert.ToInt32(txtDakika.Text);
            DateTime now = DateTime.Now;
            SqlConnection sc = new SqlConnection("Data Source=DESKTOP-A46PBGT;Initial Catalog=mobilsirket;Integrated Security=True");
            sc.Open();
            SqlCommand q2 = new SqlCommand("INSERT INTO KULLANIM(TUR,MIKTAR,MUSNO, TARIH) VALUES (1, " + dakika + ", " + frm2.getMusno() + ", '" + now + "')", sc);
            q2.ExecuteNonQuery();

            sc.Close();
        }

        private void btnSMS_Click(object sender, EventArgs e)
        {
            int sms = Convert.ToInt32(txtSMS.Text);
            DateTime now = DateTime.Now;
            SqlConnection sc = new SqlConnection("Data Source=DESKTOP-A46PBGT;Initial Catalog=mobilsirket;Integrated Security=True");
            sc.Open();
            SqlCommand q2 = new SqlCommand("INSERT INTO KULLANIM(TUR,MIKTAR,MUSNO, TARIH) VALUES (1, " + sms + ", " + frm2.getMusno() + ", '" + now + "')", sc);
            q2.ExecuteNonQuery();

            sc.Close();
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
