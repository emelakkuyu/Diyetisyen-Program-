﻿using System;
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
    public partial class Parola : Form
    {
        public Parola()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3TVI1GN\SQLEXPRESS;Initial Catalog=diyetisyenprogram;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            giris giris = new giris();
            giris.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Diyetisyen where Sifre=(" + textBox2.Text + ")", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
            }
            con.Close();
        }
    }
 }

