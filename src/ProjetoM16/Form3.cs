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
    public partial class Form3 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=devlabpm.westeurope.cloudapp.azure.com;Initial Catalog=PSIM1619I_MatteoCordero_2219132;Persist Security Info=True;User ID=PSIM1619I_MatteoCordero_2219132;Password=7bJ12028");
        public Form3()
        {
            InitializeComponent();
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
                    if (textBox5.Text == textBox8.Text)
                    {
                    SqlCommand sqlcomm = conn1.CreateCommand();
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.CommandText = "insert into novos_utilizadores values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                  

                    SqlCommand sqlcomm2 = conn1.CreateCommand();
                    sqlcomm2.CommandType = CommandType.Text;
                    sqlcomm2.CommandText = "insert into Utilizadores values('" + textBox5.Text + "','" + textBox4.Text + "')";
                    sqlcomm.ExecuteNonQuery();
                    sqlcomm2.ExecuteNonQuery();

                    MessageBox.Show("insert sucesso!");

                    Main main = new Main();
                    this.Hide();
                    main.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("as passwords tem de ser identicas");
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
    }
}
