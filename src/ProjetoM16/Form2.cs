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
    public partial class Form2 : Form
    {
        public static int ID { get; set ;}

        SqlConnection conn = new SqlConnection(@"Data Source=devlabpm.westeurope.cloudapp.azure.com;Initial Catalog=PSIM1619I_MatteoCordero_2219132;Persist Security Info=True;User ID=PSIM1619I_MatteoCordero_2219132;Password=7bJ12028");
        public Form2()
        {
            InitializeComponent();
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
                    string query = "Select * from Utilizadores WHERE nomeUser ='" + textBox1.Text.Trim() + "'and password='" + textBox2.Text.Trim() + "'";
                    SqlDataAdapter ss = new SqlDataAdapter(query, conn1);
                    DataTable dd = new DataTable();
                    ss.Fill(dd);
                    if (dd.Rows.Count == 1)
                    {
                        Form2.ID = Convert.ToInt32(dd.Rows[0]["id"]);
                        Main main = new Main();
                        this.Hide();
                        main.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("POR FAVOR VERIFICE A SUA PASSWORD E USERNAME");
                    }
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

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
        }
    }


 }
