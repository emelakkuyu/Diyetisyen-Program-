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
    public partial class kontrol : Form
    {
        public kontrol()
        {
            InitializeComponent();
        }
       
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=diyetisyenprogram;Integrated Security=True");
        private void kontrol_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from Kullanici where k_tc='"+ Hastalarim.tc.ToString()+"' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {


                textBox1.Text = dr["k_tc"].ToString();
                textBox2.Text=(dr["Ad"].ToString()).Trim()+" "+( dr["Soyad"].ToString()).Trim();
          
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Secim s = new Secim();
            s.Show();
            this.Hide();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into KontrolBilgileri(TC,KontrolTarihi,Boy,Kilo,Yag,Kas,Su) values ('" + textBox1.Text + "','" + dateTimePicker1.Value.ToString("yyy-MM-dd") + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text +  "')", con);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("insert into SaglikBilgileri(KontolTarihi,Tc,B_Tansiyon,K_tansiyon,Nabiz,Seker,LDL) values ('" + dateTimePicker1.Value.ToString("yyy - MM - dd") + "','" + textBox1.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "')", con);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Kayıt Yapıldı");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
            
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double boy = Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox3.Text);
            int kilo = Convert.ToInt32(textBox4.Text);
            int oran = Convert.ToInt32(kilo / boy);
            label16.Text = Convert.ToString(oran);


        }
        
        
    }
}
