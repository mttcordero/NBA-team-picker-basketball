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
          if(NomeEquipa.Contains("76"))
          

        }

        public void Configurar()
        {

            if (NomeEquipa.Contains("76"))
                BackgroundImage = Resources._76ers;

            if (NomeEquipa.Contains("atlanta"))
                BackgroundImage = Resources.atlanta_hawks;

            if (NomeEquipa.Contains("bobcats"))
                BackgroundImage = Resources.bobcats;

            if (NomeEquipa.Contains("boston"))
                BackgroundImage = Resources.boston_celtics;

            if (NomeEquipa.Contains("bucks"))
                BackgroundImage = Resources.bucks;

            if (NomeEquipa.Contains("cavaliers"))
                BackgroundImage = Resources.cavaliers;

            if (NomeEquipa.Contains("chicago"))
                BackgroundImage = Resources.chicago_bulls;

            if (NomeEquipa.Contains("clippers"))
                BackgroundImage = Resources.clippers;

            if (NomeEquipa.Contains("golden"))
                BackgroundImage = Resources.golden_state_warriors;

            if (NomeEquipa.Contains("hornets"))
                BackgroundImage = Resources.hornets;

            if (NomeEquipa.Contains("rockets"))
                BackgroundImage = Resources.houston_rockets;

            if (NomeEquipa.Contains("jazz"))
                BackgroundImage = Resources.jazz;

            if (NomeEquipa.Contains("kings"))
                BackgroundImage = Resources.kings;

            if (NomeEquipa.Contains("knicks"))
                BackgroundImage = Resources.knicks;

            if (NomeEquipa.Contains("lakers"))
                BackgroundImage = Resources.lakers;

            if (NomeEquipa.Contains("magic"))
                BackgroundImage = Resources.magic;

            if (NomeEquipa.Contains("mavericks"))
                BackgroundImage = Resources.mavericks;

            if (NomeEquipa.Contains("memphis"))
                BackgroundImage = Resources.memphis;

            if (NomeEquipa.Contains("miami"))
                BackgroundImage = Resources.miamiheat;

            if (NomeEquipa.Contains("nets"))
                BackgroundImage = Resources.nets;

            if (NomeEquipa.Contains("nuggets"))
                BackgroundImage = Resources.nuggets;

            if (NomeEquipa.Contains("pacers"))
                BackgroundImage = Resources.pacers;

            if (NomeEquipa.Contains("wizards"))
                BackgroundImage = Resources.wizards;
            
            if (NomeEquipa.Contains("phoenix"))
                BackgroundImage = Resources.phoenix_suns;

            if (NomeEquipa.Contains("pistons"))
                BackgroundImage = Resources.pistons;

            if (NomeEquipa.Contains("raptors"))
                BackgroundImage = Resources.raptors;

            if (NomeEquipa.Contains("spurs"))
                BackgroundImage = Resources.spurs;

            if (NomeEquipa.Contains("thunder"))
                BackgroundImage = Resources.thunder;

            if (NomeEquipa.Contains("timberwolves"))
                BackgroundImage = Resources.timberwolves;


            // ligar à bd
            // consultar jogadores da equipa
            // por cada jogador, adicionar à combox ou fazer o databind da combobox aos resultados da consulta à bd.

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
