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
    public partial class doktorSayfasi : Form
    {
        public doktorSayfasi()
        {
            InitializeComponent();
        }
SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=diyetisyenprogram;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = @"C:\Users\ceng\Pictures\Saved Pictures";
            op.Multiselect = true;
            if (op.ShowDialog() == DialogResult.OK)
            {
               
                foreach (String dosyaadi in op.FileNames)
                {
                    PictureBox p = new PictureBox();
                    p.Size = new Size(150, 120);
                    p.Location = new Point(507,42);
                    p.Image = Image.FromFile(dosyaadi);
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.Controls.Add(p);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void diyetListesiOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hastalarim h = new Hastalarim();
            h.Show();
            this.Hide();
        }

        private void bilgileriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoktorGüncelle dg = new DoktorGüncelle();
            dg.Show();
        }
    }
}
