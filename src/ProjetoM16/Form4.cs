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

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox7.Text == "Divisão Sudoeste")
            {
                textBox1.Text = ("Dallas Mavericks" +
                    " Houston Rocket" +
                    " Memphis Grizzlies" +
                    " New Orleans Pelicans" +
                    " San Antonio Spurs");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text == "Chicago Bulls")
            {
                MessageBox.Show("funcionou");
            }
        }
    }
}

