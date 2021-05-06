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
        public equipas()
        {
            InitializeComponent();
        }

        public void Configurar()
        {
            if (NomeEquipa.Contains("76"))
                BackgroundImage = Resources.miamiheat;

            if (NomeEquipa.Contains("atlanta"))
                BackgroundImage = Resources.houston_rockets;

            if (NomeEquipa.Contains("bobcats"))
                BackgroundImage = Resources.boston_celtics;

            if (NomeEquipa.Contains("boston"))
                BackgroundImage = Resources.houston_rockets;

            if (NomeEquipa.Contains("bucks"))
                BackgroundImage = Resources.houston_rockets;

            if (NomeEquipa.Contains("cavaliers"))
                BackgroundImage = Resources.houston_rockets;

            if (NomeEquipa.Contains("chicago"))
                BackgroundImage = Resources.houston_rockets;

            if (NomeEquipa.Contains("clippers"))
                BackgroundImage = Resources.houston_rockets;

            if (NomeEquipa.Contains("golden"))
                BackgroundImage = Resources.houston_rockets;

            if (NomeEquipa.Contains("hornets"))
                BackgroundImage = Resources.houston_rockets;

            if (NomeEquipa.Contains("rockets"))
                BackgroundImage = Resources.houston_rockets;

            if (NomeEquipa.Contains("jazz"))
                BackgroundImage = Resources.houston_rockets;

            if (NomeEquipa.Contains("kings"))
                BackgroundImage = Resources.houston_rockets;

            if (NomeEquipa.Contains("knicks"))
                BackgroundImage = Resources.houston_rockets;

            if (NomeEquipa.Contains("lakers"))
                BackgroundImage = Resources.houston_rockets;

            if (NomeEquipa.Contains("magic"))
                BackgroundImage = Resources.houston_rockets;

            if (NomeEquipa.Contains("mavericks"))
                BackgroundImage = Resources.houston_rockets;

        }


    }
}
