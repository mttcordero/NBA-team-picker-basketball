﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoM16
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form4 fnumero4 = new Form4();
                fnumero4.ShowDialog();
            }
            else
            {
                MessageBox.Show("pass ou login invalidos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fnumero3 = new Form3();
            fnumero3.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
