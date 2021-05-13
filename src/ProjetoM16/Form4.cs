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
                fequipas5.NomeEquipa = comboBox2.Text.ToLowerInvariant();
                fequipas5.Configurar();
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
                fequipas5.NomeEquipa = comboBox3.Text.ToLowerInvariant();
                fequipas5.Configurar();
                this.Hide();
                fequipas5.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text != null)
            {
                equipas fequipas5 = new equipas();
                fequipas5.NomeEquipa = comboBox4.Text.ToLowerInvariant();
                fequipas5.Configurar();
                this.Hide();
                fequipas5.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text != null)
            {
                equipas fequipas5 = new equipas();
                fequipas5.NomeEquipa = comboBox5.Text.ToLowerInvariant();
                fequipas5.Configurar();
                this.Hide();
                fequipas5.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox6.Text != null)
            {
                equipas fequipas5 = new equipas();
                fequipas5.NomeEquipa = comboBox6.Text.ToLowerInvariant();
                fequipas5.Configurar();
                this.Hide();
                fequipas5.ShowDialog();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pSIM1619I_MatteoCordero_2219132DataSet.equipasSudoeste' table. You can move, or remove it, as needed.
            this.equipasSudoesteTableAdapter.Fill(this.pSIM1619I_MatteoCordero_2219132DataSet.equipasSudoeste);
            // TODO: This line of code loads data into the 'pSIM1619I_MatteoCordero_2219132DataSet.equipasPacifico' table. You can move, or remove it, as needed.
            this.equipasPacificoTableAdapter.Fill(this.pSIM1619I_MatteoCordero_2219132DataSet.equipasPacifico);
            // TODO: This line of code loads data into the 'pSIM1619I_MatteoCordero_2219132DataSet.equipasNoroeste' table. You can move, or remove it, as needed.
            this.equipasNoroesteTableAdapter.Fill(this.pSIM1619I_MatteoCordero_2219132DataSet.equipasNoroeste);
            // TODO: This line of code loads data into the 'pSIM1619I_MatteoCordero_2219132DataSet.equipasSudeste' table. You can move, or remove it, as needed.
            this.equipasSudesteTableAdapter.Fill(this.pSIM1619I_MatteoCordero_2219132DataSet.equipasSudeste);
            // TODO: This line of code loads data into the 'pSIM1619I_MatteoCordero_2219132DataSet.equipasCentral' table. You can move, or remove it, as needed.
            this.equipasCentralTableAdapter.Fill(this.pSIM1619I_MatteoCordero_2219132DataSet.equipasCentral);
            // TODO: This line of code loads data into the 'pSIM1619I_MatteoCordero_2219132DataSet.equipasAtlantico' table. You can move, or remove it, as needed.
            this.equipasAtlanticoTableAdapter.Fill(this.pSIM1619I_MatteoCordero_2219132DataSet.equipasAtlantico);
        }

      
    }
}

