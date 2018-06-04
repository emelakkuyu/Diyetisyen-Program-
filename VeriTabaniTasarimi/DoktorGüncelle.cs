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

namespace VeriTabaniTasarimi
{
    public partial class DoktorGüncelle : Form
    {
        public DoktorGüncelle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=diyetisyenprogram;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select *from Diyetisyen where d_tc=" +Convert.ToInt32( textBox1.Text) + "", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                textBox2.Text = dr["Ad"].ToString() ;
                textBox4.Text = dr["Soyad"].ToString();
                textBox3.Text = dr["Sifre"].ToString();
                textBox8.Text = dr["Unvan"].ToString();
                textBox7.Text = dr["Telefon"].ToString();
                textBox6.Text = dr["e_mail"].ToString();
                textBox9.Text = dr["UniversiteAdi"].ToString();
                textBox5.Text = dr["baslangictarihi"].ToString();
                textBox10.Text = dr["MezuniyetTarihi"].ToString();

            }
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Diyetisyen set Ad='" + textBox2.Text + "',Soyad='" + textBox4.Text + "',Sifre='" + textBox3.Text + "',Unvan='" + textBox8.Text + "',Telefon='" + textBox7.Text + "',e_mail='" + textBox6.Text + "',UniversiteAdi='" + textBox9.Text + "',baslangictarihi='" + textBox5.Text + "',MezuniyetTarihi='" + textBox10.Text + "'where d_tc=" + textBox1.Text + "", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Güncelleme Başarı İle Tamamlandı.");

            con.Close();
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doktorSayfasi dr = new doktorSayfasi();
            dr.Show();
           
        }

        private void DoktorGüncelle_Load(object sender, EventArgs e)
        {
           

        }
    }
}
