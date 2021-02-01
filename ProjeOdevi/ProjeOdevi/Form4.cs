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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Form2 frm2 = new Form2();// Form2 line 38deki q4
        
        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection sc = new SqlConnection("Data Source=DESKTOP-A46PBGT;Initial Catalog=mobilsirket;Integrated Security=True");
            DateTime dt = DateTime.Now;
            sc.Open();

            SqlCommand q1 = new SqlCommand("Insert into SIKAYET(TARIHI, TEKST, MUSNO, TEMSILCINO) VALUES ('" + dt + "', '" + txtSikayet.Text + "', '"+ frm2.getMusno().ToString() + "',1)", sc);
            q1.ExecuteNonQuery();

            MessageBox.Show("Sikayet Kaydiniz Basariyla olsuturulmustur.");
            sc.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frm2.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
