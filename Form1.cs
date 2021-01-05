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
        
        Estrutura[] Objetos = new Estrutura[100];//Vetor que armazena uma lista de objetos que colide com o persongem principal
        Estrutura celulas = new Estrutura();
        Estrutura comidas = new Estrutura();

        fisica[] celulasFisica = new fisica[100];
        public fisica Personagem;//Instacia o Personagem principal
        public fisica Personage2;

        int x = 2;
        int macho = 1;
        int femea = 1;
        public Form1()
        {
            InitializeComponent();
   

            Objetos[0] = new Estrutura();
            Objetos[1] = new Estrutura();
            Blocos = Controle.instaciarCenario();

            for (int a = 0; a < 20; a++)
            {
                for (int b = 0; b < 9; b++)
                {
                    //Adicionando a parte fisica no bloco gerado
                    Objetos[0].add(Blocos[a, b]);
                    Objetos[1].add(Blocos[a, b]);
                    Controls.Add(Blocos[a, b]);
                }
            }
        
            celulas.add(personagem2);
            celulas.add(Jogador);
            Objetos[0].add(personagem2);
            Objetos[1].add(Jogador);

            fisica Parede1 = new fisica(parede1, Jogador, 1);
            fisica Parede2 = new fisica(parede2, Jogador, 1);
            fisica Parede3 = new fisica(parede3, Jogador, 1);
            fisica Parede4 = new fisica(parede4, Jogador, 1);

            Personagem = new fisica(Jogador,personagem2,1);
            Personage2 = new fisica(personagem2,Jogador,1);

            celulasFisica[0] = Personagem;
            celulasFisica[1] = Personage2;

            Personagem.colidir(Objetos[0].getDados());
            Personage2.colidir(Objetos[1].getDados());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cells atores = new Cells(personagem2, Personage2, this);
            atores.movimento();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Personagem.mover(e.KeyValue);
        }

        public void atualizar(Control comidinha)
        {
            for (int z = 0; z < x; z++)
            {
                if (Objetos[z] != null)
                {
                    Objetos[z].add(comidinha);
                    celulasFisica[z].colidir(Objetos[z].getDados());
                }
            }
        }

        public void novaCelula(int eX, int eY)
        {
            Random random = new Random();
            Label newCell = new Label();

            newCell = Controle.gerarCelula();
            if(newCell.Text == "M")
            {
                macho++;
                machoLabel.Text = "Macho: " + macho; 
            }
            else
            {
                femea++;
                femeaLabel.Text = "Femea: " + femea;
            }
            newCell.Location = new Point(eX-26, eY-26);
            fisica newCellFisica = new fisica(newCell);
            celulasFisica[x] = newCellFisica;
            Objetos[x] = new Estrutura();

            for (int a = 0; a < 20; a++)
            {
                for (int b = 0; b < 9; b++)
                {
                    Objetos[x].add(Blocos[a, b]);
                }
            }

            for(int z=0; z<celulas.posicao; z++)
            {
                Objetos[x].add(celulas.getDado(z));
            }

            for(int z=0; z<comidas.posicao; z++)
            {
                Objetos[x].add(comidas.getDado(z));
            }

            celulas.add(newCell);

            celulasFisica[x].colidir(Objetos[x].getDados());
            Controls.Add(newCell);
            Cells cellPerson = new Cells(newCell, newCellFisica, this);
            cellPerson.movimento();
            for(int y=0;y<x;y++)
            {
                if (Objetos[y] != null)
                {
                    Objetos[y].add(newCell);

                    celulasFisica[y].colidir(Objetos[y].getDados());
                }
            }
            while (celulasFisica[x].Colisao() == 1)
            {
                newCell.Location = new Point(random.Next(30, 1000), random.Next(30, 480));
            }
            x++;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            Label comida = new Label();

            comida = Controle.gerarComida();
            comida.Location = new Point(random.Next(30, 1000), random.Next(30, 480));
            fisica comidaFisica = new fisica(comida);
            this.Controls.Add(comida);
            comidaFisica.colidir(Objetos[1].getDados());
            comidas.add(comida);
            while(comidaFisica.Colisao()==1)
            {
                comida.Location = new Point(random.Next(30, 1000), random.Next(30, 480));
            }
            comidaFisica.colidir(celulas.getDados());

            atualizar(comida);
        }
    }
}
