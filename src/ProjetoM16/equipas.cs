using ProjetoM16.Properties;
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
    public partial class equipas : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=devlabpm.westeurope.cloudapp.azure.com;Initial Catalog=PSIM1619I_MatteoCordero_2219132;Persist Security Info=True;User ID=PSIM1619I_MatteoCordero_2219132;Password=7bJ12028");

        public string NomeEquipa { get; set; }

        public string NomeJogador { get; set; }

        public string nomeE { get; set; }
        public equipas()
        {
            InitializeComponent();
        }

        public void Configurar()
        {

            string nomeEquipa;

            if (NomeEquipa.Contains("76"))
            {
                nomeE = "4";
                BackgroundImage = Resources._76ers;
            }

            if (NomeEquipa.Contains("atlanta"))
            {
                nomeE = "11";
                BackgroundImage = Resources.atlanta_hawks;
            }

            if (NomeEquipa.Contains("pelicans"))
            {
                nomeE = "29";
                BackgroundImage = Resources.pelicans;
            }

            if (NomeEquipa.Contains("boston"))
            {
                nomeE = "1";
                BackgroundImage = Resources.boston_celtics;
            }

            if (NomeEquipa.Contains("bucks"))
            {
                nomeE = "10";
                BackgroundImage = Resources.bucks;
            }

            if (NomeEquipa.Contains("cavaliers"))
            {
                nomeE = "7";
                BackgroundImage = Resources.cavaliers;
            }

            if (NomeEquipa.Contains("kings"))
            {
                nomeE = "25";
                BackgroundImage = Resources.kings;
            }

            if (NomeEquipa.Contains("chicago"))
            {
                nomeE = "6";
                BackgroundImage = Resources.chicago_bulls;
            }

            if (NomeEquipa.Contains("clippers"))
            {
                nomeE = "22";
                BackgroundImage = Resources.clippers;
            }

            if (NomeEquipa.Contains("golden"))
            {
                nomeE = "21";
                BackgroundImage = Resources.golden_state_warriors;
            }

            if (NomeEquipa.Contains("hornets"))
            {
                nomeE = "12";
                BackgroundImage = Resources.hornets;
            }

            if (NomeEquipa.Contains("rockets"))
            {
                nomeE = "27";
                BackgroundImage = Resources.houston_rockets;
            }

            if (NomeEquipa.Contains("jazz"))
            {
                nomeE = "20";
                BackgroundImage = Resources.jazz;
            }

            if (NomeEquipa.Contains("knicks"))
            {
                nomeE = "3";
                BackgroundImage = Resources.knicks;
            }

            if (NomeEquipa.Contains("lakers"))
            {
                nomeE = "23";
                BackgroundImage = Resources.lakers;
            }

            if (NomeEquipa.Contains("magic"))
            {
                nomeE = "14";
                BackgroundImage = Resources.magic;
            }

            if (NomeEquipa.Contains("mavericks"))
            {
                nomeE = "26";
                BackgroundImage = Resources.mavericks;
            }

            if (NomeEquipa.Contains("memphis"))
            {
                nomeE = "28";
                BackgroundImage = Resources.memphis;
            }

            if (NomeEquipa.Contains("miami"))
            {
                nomeE = "13";
                BackgroundImage = Resources.miamiheat;
            }

            if (NomeEquipa.Contains("nets"))
            {
                nomeE = "2";
                BackgroundImage = Resources.nets;
            }

            if (NomeEquipa.Contains("nuggets"))
            {
                nomeE = "16";
                BackgroundImage = Resources.nuggets;
            }

            if (NomeEquipa.Contains("pacers"))
            {
                nomeE = "9";
                BackgroundImage = Resources.pacers;
            }

            if (NomeEquipa.Contains("wizards"))
            {
                nomeE = "15";
                BackgroundImage = Resources.wizards;
            }

            if (NomeEquipa.Contains("phoenix"))
            {
                nomeE = "24";
                BackgroundImage = Resources.phoenix_suns;
            }

            if (NomeEquipa.Contains("pistons"))
            {
                nomeE = "8";
                BackgroundImage = Resources.pistons;
            }

            if (NomeEquipa.Contains("raptors"))
            {
                nomeE = "5";
                BackgroundImage = Resources.raptors;
            }

            if (NomeEquipa.Contains("spurs"))
            {
                nomeE = "30";
                BackgroundImage = Resources.spurs;
            }

            if (NomeEquipa.Contains("thunder"))
            {
                nomeE = "18";
                BackgroundImage = Resources.thunder;
            }
            if (NomeEquipa.Contains("timberwolves"))
            {
                nomeE = "17";
                BackgroundImage = Resources.timberwolves;
            }

            if (NomeEquipa.Contains("trail"))
            {
                nomeE = "19";
                BackgroundImage = Resources.trail_blazzers;
            }

            Width = BackgroundImage.Width;
            Height = BackgroundImage.Height;

        }


        // ligar à bd
        // consultar jogadores da equipa
        // por cada jogador, adicionar à combox ou fazer o databind da combobox aos resultados da consulta à bd.





        private void equipas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pSIM1619I_MatteoCordero_2219132DataSet.Jogadores' table. You can move, or remove it, as needed.
            this.jogadoresTableAdapter.Fill(this.pSIM1619I_MatteoCordero_2219132DataSet.Jogadores);
            // TODO: This line of code loads data into the 'pSIM1619I_MatteoCordero_2219132DataSet.Equipas' table. You can move, or remove it, as needed.
            this.equipasTableAdapter.Fill(this.pSIM1619I_MatteoCordero_2219132DataSet.Equipas);
            // TODO: This line of code loads data into the 'pSIM1619I_MatteoCordero_2219132DataSet.Jogadores' table. You can move, or remove it, as needed.

            SqlConnection conn1 = new SqlConnection(conn.ConnectionString);
        }

        private void button1_Click(object sender, EventArgs e)
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


                    SqlCommand sqlcomm = conn1.CreateCommand();
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.CommandText = "insert into jogadores values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                    sqlcomm.ExecuteNonQuery();

                    MessageBox.Show("insert sucesso!");
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


        private void button2_Click(object sender, EventArgs e)
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


                        SqlCommand sqlcomm = conn1.CreateCommand();
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.CommandText = "delete from jogadores where nome = '" + textBox2.Text + "'";
                        sqlcomm.ExecuteNonQuery();

                        MessageBox.Show("delete sucesso!");
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

    
