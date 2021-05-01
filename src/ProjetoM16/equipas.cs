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

namespace ProjetoM16
{
    public partial class equipas : Form
    {

        public string NomeEquipa { get; set; }

        public string NomeJogador { get; set; }
        public equipas()
        {
            InitializeComponent();
        }

       public void DefenirJogador()
        {
            if (NomeEquipa.Contains("celtics"))
            {
               comboBox1.Text = ("JAYLEN BROWN");
            }


        }
        public void Configurar()
        {
            if (NomeEquipa.Contains("miami"))
                BackgroundImage = Resources.miamiheat;
            // funciona falta por nome dos jogadores   comboBox1.Text = "jjjjjjj";

            if (NomeEquipa.Contains("houston"))
                BackgroundImage = Resources.houston_rockets;

            if (NomeEquipa.Contains("celtics"))
                BackgroundImage = Resources.boston_celtics;

            if (NomeEquipa.Contains("houston"))
                BackgroundImage = Resources.houston_rockets;

            if (NomeEquipa.Contains("houston"))
                BackgroundImage = Resources.houston_rockets;

            if (NomeEquipa.Contains("houston"))
                BackgroundImage = Resources.houston_rockets;

        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
