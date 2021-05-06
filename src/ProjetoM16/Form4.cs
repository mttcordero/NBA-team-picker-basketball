using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != null)
            {
                equipas fequipas5 = new equipas();
                this.Hide();
                fequipas5.ShowDialog();
            }

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != null)
            {
                equipas fequipas5 = new equipas();
                fequipas5.NomeEquipa = comboBox1.Text.ToLowerInvariant();
                fequipas5.Configurar();
                this.Hide();
                fequipas5.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text != null)
            {
                equipas fequipas5 = new equipas();
                this.Hide();
                fequipas5.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text != null)
            {
                equipas fequipas5 = new equipas();
                this.Hide();
                fequipas5.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text != null)
            {
                equipas fequipas5 = new equipas();
                this.Hide();
                fequipas5.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text != null)
            {
                equipas fequipas5 = new equipas();
                this.Hide();
                fequipas5.ShowDialog();
            }
        }


      
    }
}

