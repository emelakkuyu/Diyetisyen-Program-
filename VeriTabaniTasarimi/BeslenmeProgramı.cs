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
using word = Microsoft.Office.Interop.Word;
using System.Reflection;
namespace VeriTabaniTasarimi
{
    public partial class BeslenmeProgramı : Form
    {
        string item;
        public BeslenmeProgramı(string item)
        {
            InitializeComponent();
            this.item = item;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=diyetisyenprogram;Integrated Security=True");
        private void BeslenmeProgramı_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from Diyet where Hastalik='" + item + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                textBox1.Text = dr["Sabah"].ToString();
                textBox2.Text = dr["Ara_s"].ToString();
                textBox3.Text = dr["Ogle"].ToString();
                textBox4.Text = dr["Ara_o"].ToString();
                textBox5.Text = dr["Aksam"].ToString();
                textBox6.Text = dr["Ara_a"].ToString();

            }
            con.Close();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select *from Kullanici where k_tc='" + Hastalarim.tc.ToString() + "' ", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {


                textBox7.Text = dr1["k_tc"].ToString();
                textBox8.Text = (dr1["Ad"].ToString()).Trim() + " " + (dr1["Soyad"].ToString()).Trim();

            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            object x = System.Reflection.Missing.Value;
            object dokumansonu = "\\endofdoc";
            word.Application olustur;
            word.Document icerik;
            olustur = new word.Application();
            olustur.Visible = true;
            icerik = olustur.Documents.Add(ref x);
            word.Paragraph giris;
            giris = icerik.Content.Paragraphs.Add(ref x);
            giris.Range.Text = textBox8.Text + " beslenme Programı";
            giris.Alignment = word.WdParagraphAlignment.wdAlignParagraphCenter;
            giris.Range.Font.Bold = 5;
            giris.Format.SpaceAfter = 50;
            giris.Range.InsertParagraphAfter();

            word.Table olusturtablo;
            word.Range y = icerik.Bookmarks.get_Item(ref dokumansonu).Range;
            olusturtablo = icerik.Tables.Add(y, 6, 2, ref x, ref x);
            olusturtablo.Range.ParagraphFormat.SpaceAfter = 5;
            olusturtablo.Cell(1, 1).Range.Text = "Sabah :" + " " + comboBox1.Text;
            olusturtablo.Cell(2, 1).Range.Text = "Ara Öğün :" + " " + comboBox2.Text;
            olusturtablo.Cell(3, 1).Range.Text = "Öğle :" + " " + comboBox3.Text;
            olusturtablo.Cell(4, 1).Range.Text = "Ara Öğün :" + " " + comboBox4.Text;
            olusturtablo.Cell(5, 1).Range.Text = "Akşam :" + " " + comboBox5.Text;
            olusturtablo.Cell(6, 1).Range.Text = "Ara Öğün:" + " " + comboBox6.Text;

            olusturtablo.Cell(1, 2).Range.Text = textBox1.Text;
            olusturtablo.Cell(2, 2).Range.Text = textBox2.Text;
            olusturtablo.Cell(3, 2).Range.Text = textBox3.Text;
            olusturtablo.Cell(4, 2).Range.Text = textBox4.Text;
            olusturtablo.Cell(5, 2).Range.Text = textBox5.Text;
            olusturtablo.Cell(6, 2).Range.Text = textBox6.Text;

        }
    }
}
