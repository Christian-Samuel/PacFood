using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;

namespace PacFood
{
    public class Player
    {
        Control Jogador;
        public static Label pt;
        public static Label life;
        public static Label frc;
        static public float forca = 100;
        static public int vida=100;
        public static int pontos=0;

        //Construtores
        public Player(Control jog, Label pts, Label vida, Label forca)
        {
            frc = forca;
            life = vida;
            pt = pts;
            this.Jogador = jog;

        }

        public static void atualizar()
        {
            frc.Text = "Força: " + ((int)forca).ToString();
            life.Text ="Vida: "+ vida.ToString();
            pt.Text ="Pontos: "+ pontos.ToString();
            //if (vida <= 0)
               // Application.Restart();
        }
    }
}
