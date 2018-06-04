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
using System.Net.Mail;

namespace VeriTabaniTasarimi
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=diyetisyenprogram;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Parola sifre = new Parola();
            sifre.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from Diyetisyen where d_tc='"+textBox1.Text+ "' AND Sifre='"+textBox2.Text+"'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                doktorSayfasi ds = new doktorSayfasi();
                ds.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Yanlış");
            }
            con.Close();

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
           textBox1.Text = "";
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select *from Kullanici where k_tc='" + textBox1.Text + "' AND Sifre='" + textBox2.Text + "'", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                KullaniciSayfasi ds = new KullaniciSayfasi();
                ds.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Yanlış");
            }
            con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from Diyetisyen where d_tc='" + textBox1.Text + "' AND Sifre='" + textBox2.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                doktorSayfasi ds = new doktorSayfasi();
                ds.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Yanlış");
            }
            con.Close();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select *from Kullanici where k_tc='" + textBox1.Text + "' AND Sifre='" + textBox2.Text + "'", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                KullaniciSayfasi ds = new KullaniciSayfasi();
                ds.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Yanlış");
            }
            con.Close();

        }
    }
}
