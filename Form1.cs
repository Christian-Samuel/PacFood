using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacFood
{
    public partial class Form1 : Form
    {
        public Label[,] Blocos = new Label[20, 9];//Todos os blocos gerados no Controle
        public Label[] BlocosPInimigos = new Label[180];//Todos os blocos gerados menos os inimigos

        public fisica[][] ObjetosInimigos = new fisica[30][];//Matriz com 2 dimensões, cada dimensão guarda uma lista de objetos que colidem com os inimigos
        
        public fisica[] BlocosFis = new fisica[180];
        public fisica[] Objetos = new fisica[180];//Vetor que armazena uma lista de objetos que colide com o persongem principal
        public fisica Personagem;//Instacia o Personagem principal
        
        public Player PersonagemP;//Controle do Personagem Principal

        public int[] QntInimigos = new int[30];//A posicao de cada inimigo em relação ao BlocosFis[]
        int y = 0;
        


        public Form1()
        {
            InitializeComponent();
            int z = 0;
            int x = 0;
            
            Blocos = Controle.instaciarCenario();

            for (int a = 0; a < 20; a++)
            {
                for (int b = 0; b < 9; b++)
                {
                    //Adicionando a parte fisica no bloco gerado
                    BlocosFis[x] = new fisica(Blocos[a, b], Jogador, 2);

                    //Manda para o vetor que salva os blocos que colidem
                    Objetos[x] = BlocosFis[x];

                    //Grava a posição em que o Inimigo esta salvo no BlocosFix
                    if (Blocos[a, b].BackColor == Color.Yellow)
                    {
                        QntInimigos[z] = x;
                        z++;
                    }
                    /*else
                    {
                        BlocosPInimigos[y] = Blocos[a, b];//Armazena os blocos que colidirão com os inimigos
                        y++;
                    }*/

                    BlocosPInimigos[y] = Blocos[a, b];//Armazena os blocos que colidirão com os inimigos
                    y++;

                    x++;
                    this.Controls.Add(Blocos[a, b]);
                }
            }
            z = 0;
            x = 0;

            fisica Parede1 = new fisica(parede1, Jogador, 1);
            fisica Parede2 = new fisica(parede2, Jogador, 1);
            fisica Parede3 = new fisica(parede3, Jogador, 1);
            fisica Parede4 = new fisica(parede4, Jogador, 1);

            fisica food = new fisica(comida, Jogador, 3);
            Objetos[0] = food;
            Personagem = new fisica(Jogador);
            PersonagemP = new Player(Jogador, pontoLabel, vidaLabel, frcTxt);
            Personagem.colidir(Objetos);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 0;
            int z = 0;
            //Ele recebe o script de fisica do inimigo para poder acessar o .colisão()
            Inimigo[] Inimigos = new Inimigo[Controle.InimigosNumero];//Script que controla os inimigos
            
            for (int a = 0; a < 20; a++)
            {
                for (int b = 0; b < 9; b++)
                {
                    if (Blocos[a, b].BackColor == Color.Yellow)//Todos os inimigos
                    {
                        Inimigos[x] = new Inimigo(Blocos[a, b], BlocosFis[QntInimigos[x]],this);//Cria um novo script para controlar o inimigo 

                        ObjetosInimigos[z] = new fisica[180];//Inicializa a matriz

                        /*
                        for (int c = 0; c < Objetos.Length - Controle.InimigosNumero; c++)//Percorre todos os objetos que podem colidir com o inimigo
                        {
                            ObjetosInimigos[z][c] = new fisica(BlocosPInimigos[c], Blocos[a, b], 1);//Cria um objeto de fisica para esse bloco e armazena na matriz
                        }*/

                       for (int c = 0; c < BlocosPInimigos.Length; c++)//Percorre todos os objetos que podem colidir com o inimigo
                       {
                            if (BlocosPInimigos[c].Tag != Blocos[a,b].Tag)
                            {
                                ObjetosInimigos[z][c] = new fisica(BlocosPInimigos[c], Blocos[a, b], 1);//Cria um objeto de fisica para esse bloco e armazena na matriz
                            }
                            else
                            {
                                ObjetosInimigos[z][c] = new fisica(parede4, parede2, 1);//Cria um objeto de fisica para esse bloco e armazena na matriz
                            }
                       }


                        BlocosFis[QntInimigos[x]].colidir(ObjetosInimigos[z]);//O Inimigo recebe a lista de script dos blocos com colisão
                        x++;
                        z++;
                    }
                }
            }

            for (int a = 0; a < Inimigos.Length; a++)
            {
                Inimigos[a].movimento();
            }
            Player.atualizar();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
                Personagem.mover(e.KeyValue);
                Jogador.Text = e.KeyValue.ToString();
        }

        public void ovo(Control pai)
        {
            Label peca = new Label();
            peca.Text = "";
            peca.Tag = Controle.idName;
            peca.Size = new System.Drawing.Size(15, 15);
            peca.BorderStyle = BorderStyle.FixedSingle;
            peca.BackColor = Color.Green;
            peca.Location = pai.Location;
            this.Controls.Add(peca);
        }
    }
}
