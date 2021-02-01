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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=DESKTOP-A46PBGT;Initial Catalog=mobilsirket;Integrated Security=True");

            SqlCommand q1;
            SqlDataReader read;
            string type = "Undecided";
            

            sc.Open();
            q1 = new SqlCommand(" Select TUR,MIKTAR,TARIH From KULLANIM k, MUSTERILER m WHERE m.MUSNO = k.MUSNO  ", sc);
            read = q1.ExecuteReader();
            
            if (read.HasRows)
            {
                while (read.Read()) 
                {
                    switch (Convert.ToInt32(read[0]))
                    {
                        case 0:
                            type = "Internet";
                            break;
                        case 1:
                            type = "Dakika";
                            break;
                        case 2:
                            type = "SMS";
                            break;
                    }
                    

                    txtData.AppendText("\r\n Veri: " + type + " Miktar: " + read[1].ToString() + " Kullanilan Tarih: " + read[2]);  
                }

            }
            read.Close();
            sc.Close();
            
            
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
        }
    }
}
