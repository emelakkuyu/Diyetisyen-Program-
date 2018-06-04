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
    public partial class BMIHesapla : Form
    {
        public BMIHesapla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            double kilo = Convert.ToDouble(textBox2.Text);
            double oran = kilo / boy;
            string sonuc = oran.ToString("0.###");
            label4.Text = Convert.ToString("Beden Kütle İndeksiniz (BMI) : " + sonuc);
            if (oran < 18.5)
            {
                label5.Text = "Zayıf";
            }
            else if (oran < 25)
            {
                label5.Text = "Sağlıklı";
            }
            else if (oran < 30)
            {
                label5.Text = "Kilolu";
            }
            else if (oran < 40)
            {
                label5.Text = "Şişman";
            }
            else
            {
                label5.Text = "Aşırı Şişman";
            }
        }



        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
