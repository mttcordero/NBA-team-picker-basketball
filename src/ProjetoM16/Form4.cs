using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoM16
{
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=devlabpm.westeurope.cloudapp.azure.com;Initial Catalog=PSIM1619I_MatteoCordero_2219132;Persist Security Info=True;User ID=PSIM1619I_MatteoCordero_2219132;Password=7bJ12028");
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
            SqlConnection conn1 = new SqlConnection(conn.ConnectionString);

            if (conn1.State == System.Data.ConnectionState.Closed)
            {
                conn1.Open();
            }

                try
                {
                    using (conn1)
                    {
                        string sqlquery = "select distinct NomeEquipa from Jogadores as J inner join EquipasJogadores as ej on ej.JogadorID = j.id inner join Equipas as e on e.id = ej.equipaid inner join divisoes as d on e.divisaoid = d.id where NomeDivisao = 'atlantico'";
                        SqlCommand sqlcomm = new SqlCommand(sqlquery, conn1);

                        SqlDataReader dr = sqlcomm.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);                       
                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "NomeEquipa";
                        comboBox1.ValueMember = "NomeEquipa";
                        
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Falha na Conecção à BD:\n{ex.Message}", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn1.Close();
                }


        }
    }
}

