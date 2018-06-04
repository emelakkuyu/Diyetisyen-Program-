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
    public partial class Hastalarim : Form
    {
        public Hastalarim()
        {
            InitializeComponent();
        }
        public static string tc;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=diyetisyenprogram;Integrated Security=True");
        private void VerilerGöster()
        {
            listView1.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Kullanici", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["k_tc"].ToString();
                ekle.SubItems.Add(dr["Ad"].ToString());
                ekle.SubItems.Add(dr["Soyad"].ToString());
                ekle.SubItems.Add(dr["Cinsiyet"].ToString());
                ekle.SubItems.Add(dr["DogumTarihi"].ToString());
                ekle.SubItems.Add(dr["Telefon"].ToString());
                ekle.SubItems.Add(dr["Adres"].ToString());
                ekle.SubItems.Add(dr["e_mail"].ToString());
                listView1.Items.Add(ekle);
            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (listView1.Items[0].Selected)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select *from Kullanici where k_tc=(" + Tc + ")", con);
                cmd.ExecuteNonQuery();
                con.Close();
                tc = listView1.SelectedItems[0].SubItems[0].Text;
                kontrol k = new kontrol();
                k.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("fdfssdgsd");
            }
            tc = listView1.SelectedItems[0].SubItems[0].Text;
            
           
        }

        private void Hastalarim_Load(object sender, EventArgs e)
        {
            VerilerGöster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Kullanici where k_tc=(" + Tc + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();
            VerilerGöster();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        int Tc = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Tc = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
         }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listView1.Items[0].Selected)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select *from Kullanici where k_tc=(" + Tc + ")", con);
                cmd.ExecuteNonQuery();
                con.Close();
                tc = listView1.SelectedItems[0].SubItems[0].Text;
                kontrol k = new kontrol();
                k.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("fdfssdgsd");
            }
            tc = listView1.SelectedItems[0].SubItems[0].Text;
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {
            Tc = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
        }
    }
}
