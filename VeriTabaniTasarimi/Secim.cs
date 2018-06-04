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
    public partial class Secim : Form
    {
        public Secim()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=diyetisyenprogram;Integrated Security=True");
        private void Secim_Load(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select Hastalik from Diyet ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["Hastalik"].ToString());
            }
            con.Close();

        }

   

        private void button1_Click_1(object sender, EventArgs e)
        {
            BeslenmeProgramı bp = new BeslenmeProgramı(listBox1.SelectedItem.ToString());
            bp.Show();
            this.Hide();

        }
    }
}
