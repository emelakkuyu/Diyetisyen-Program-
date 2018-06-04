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
    public partial class KullaniciGuncelle : Form
    {
        public KullaniciGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=diyetisyenprogram;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            diyetisyen d = new diyetisyen();
            d.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from Kullanici where k_tc=" + Convert.ToInt32(textBox1.Text) + "", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                textBox2.Text = dr["Ad"].ToString();
                textBox4.Text = dr["Soyad"].ToString();
                textBox3.Text = dr["Sifre"].ToString();
                textBox7.Text = dr["DogumTarihi"].ToString();
                textBox6.Text = dr["Telefon"].ToString();
                textBox8.Text = dr["Adres"].ToString();
                textBox5.Text = dr["e_mail"].ToString();
                

            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Kullanici set Ad='" + textBox2.Text + "',Soyad='" + textBox4.Text + "',Sifre='" + textBox3.Text + "',DogumTarihi='" + textBox7.Text + "',Telefon='" + textBox6.Text + "',Adres='" + textBox8.Text + "',e_mail='" + textBox5.Text + "'where k_tc=" + textBox1.Text + "", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Güncelleme Başarı İle Tamamlandı.");

            con.Close();
        }


    }
}
