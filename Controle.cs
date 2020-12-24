﻿using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PacFood
{

    public class Controle
    {
        public static int idName=1;
        public static string txtName = "peca";
        public static int z = 0;
        public static int y = 0;
        public static int InimigosNumero = 0;//Variavel utilizada em outros scripts para saber a quantidade de inimigos gerados

        public static Label[,] blocos = new Label[20, 12];

        

        //Gera um novo bloco
        public static Label gerar()
        {
            Label peca = new Label();
            peca.Name = txtName + idName.ToString();
            peca.Text = "";
            peca.Tag = idName;
            peca.Size = new System.Drawing.Size(40, 40);
            peca.BorderStyle = BorderStyle.FixedSingle;
            peca.BackColor = Color.Peru;

            idName++;
            return peca;
        }


        //Cria uma matriz com os blocos gerados
        public static Label[,] instaciarCenario()
        {
            Random random = new Random();

            for(int a=0; a<20; a++)
            {
                for(int b=0; b<9; b++)
                {
                    blocos[a, b] = gerar();
                    blocos[a, b].Location = new System.Drawing.Point(z+40, y+30);
                    
                    if (random.Next(1, 4) != 1)//Gera um cenario com espaços em branco
                    {
                        blocos[a, b].Visible = false;
                        blocos[a, b].Enabled = false;
                        blocos[a, b].Location = new System.Drawing.Point(0, 0);
                        blocos[a, b].Size = new Size(0, 0);
                    }
                    else
                    {
                        if(random.Next(1,8)==5)//1 a cada 10 blocos serão inimigos
                        {
                            blocos[a, b].BackColor = Color.Yellow;
                            blocos[a, b].Size = new Size(30, 30);
                            InimigosNumero++;
                        }
                    }
                    y += 50;
                }
                y = 0;
                z += 50;
            }
            return blocos;//Retorna uma matriz para quem a chamou
        }

        public static void colorir(Label pecas, int numero)//Sorteia uma cor para o bloco que foi passado como parametro
        {
            switch (numero)
            {
                case 1:
                    pecas.BackColor = System.Drawing.Color.Orange;
                    break;
                case 2:
                    pecas.BackColor = System.Drawing.Color.Blue;
                    break;
                case 3:
                    pecas.BackColor = System.Drawing.Color.Green;
                    break;
                case 4:
                    pecas.BackColor = System.Drawing.Color.Red;
                    break;
                case 5:
                    pecas.BackColor = System.Drawing.Color.Yellow;
                    break;
            }
        }

        
    }
}
