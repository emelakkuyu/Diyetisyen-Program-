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
    public partial class kullanıcıUye : Form
    {
        public kullanıcıUye()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=diyetisyenprogram;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            diyetisyen anasayfa = new diyetisyen();
            anasayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (hata == 0)
            {
                control();
            }
            else if(hata==1)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Kullanici(k_tc,Ad,Soyad,Sifre,Cinsiyet,DogumTarihi,Telefon,Adres,e_mail) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox5.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" Kayıt Yapıldı");
                giris giris = new giris();
                giris.Show();
                this.Hide();
            }
        }
            int hata = 0;

        private void control()
        {

            if (textBox1.Text == string.Empty)

                hata = 1;

            if (textBox2.Text == string.Empty)

                hata = 1;

            if (textBox4.Text == string.Empty)

                hata = 1;

            if (textBox3.Text == string.Empty)

                hata = 1;
            //if (comboBox1.SelectedIndex == 0)
            //{
            //    hata = 1;
            //}
            if (hata == 1)

            {

                MessageBox.Show("Zorunlu Alanları Doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
