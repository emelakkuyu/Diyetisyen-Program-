using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabaniTasarimi
{
    public partial class diyetisyen : Form
    {
        public diyetisyen()
        {
            InitializeComponent();
        }

        private void doktorÜyeOlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doktorUye doktor = new doktorUye();
            doktor.Show();
            this.Hide();
        }

        private void kullanıcıÜyeOlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullanıcıUye kullanici = new kullanıcıUye();
            kullanici.Show();
            this.Hide();
        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            giris giris = new giris();
            giris.Show();
            this.Hide();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iletisim i = new iletisim();
            i.Show();
            this.Hide();
        }

        private void künyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kunye k = new Kunye();
            k.Show();
            
        }

        private void bMIHesaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BMIHesapla bh = new BMIHesapla();
            bh.Show();
            
        }

        private void beslenmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Beslenme b = new Beslenme();
            b.Show();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yardım y = new Yardım();
            y.Show();
            
        }
    }
}
