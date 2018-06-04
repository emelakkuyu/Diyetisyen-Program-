using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;

namespace VeriTabaniTasarimi
{
    public partial class KullaniciSayfasi : Form
    {
        string item;
        public KullaniciSayfasi()
        {
            InitializeComponent();
           // this.item = item;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void button6_Click(object sender, EventArgs e)
        {
            diyetisyen d = new diyetisyen();
            d.Show();
        }

        private void KullaniciSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void bilgilerimiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciGuncelle k = new KullaniciGuncelle();
            k.Show();
            this.Hide();
        }
    }
}
