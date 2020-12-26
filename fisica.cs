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
    public class fisica
    {
        public Control objeto1;
        public Control objeto2;
        public Control[] Objetos;//Conjunto de Objetos que detctarão colisão

        int velocidade=2;
        int propriedade=1; //define se o obejto e fixo no cenario
        struct Eixos 
        {
           public int EixoX;
           public int EixoY;
        }; 
        struct Tamanhos
        {
            public int Largura, Altura;
        };

         const int A = 0;
         const int B = 1;
         const int C = 2;
         const int D = 3;

        //Construtores
        public fisica(Control obj1, Control obj2, int prop)
        {
            this.objeto1 = obj1;
            this.objeto2 = obj2;
            this.propriedade = prop;
        }
        public fisica(Control obj1)
        {
            this.objeto1 = obj1;
        }


        //Metodo para personagens
        public void setVelocidade(int vel)
        {
            this.velocidade = vel;
        }
        public void colidir(Control[] objetos)
        {
           this.Objetos = objetos;
        }

        //Metodos para todos objetos
        public int Colisao()
        {
            for (int x = 0; x < Objetos.Length; x++)
            {
                objeto2 = Objetos[x];

                Tamanhos Tamanho1, Tamanho2;
                Eixos[] Eixos1 = new Eixos[4];
                Eixos[] Eixos2 = new Eixos[4];

                Tamanho1.Largura = objeto1.Size.Width;
                Tamanho1.Altura = objeto1.Size.Height;
                Tamanho2.Largura = objeto2.Size.Width;
                Tamanho2.Altura = objeto2.Size.Height;

                Eixos1[A].EixoX = objeto1.Location.X;
                Eixos1[A].EixoY = objeto1.Location.Y;
                Eixos1[B].EixoX = objeto1.Location.X + Tamanho1.Largura;
                Eixos1[B].EixoY = objeto1.Location.Y;
                Eixos1[C].EixoX = objeto1.Location.X;
                Eixos1[C].EixoY = objeto1.Location.Y + Tamanho1.Altura;
                Eixos1[D].EixoX = objeto1.Location.X + Tamanho1.Largura;
                Eixos1[D].EixoY = objeto1.Location.Y + Tamanho1.Altura;

                Eixos2[A].EixoX = objeto2.Location.X;
                Eixos2[A].EixoY = objeto2.Location.Y;
                Eixos2[B].EixoX = objeto2.Location.X + Tamanho2.Largura;
                Eixos2[B].EixoY = objeto2.Location.Y;
                Eixos2[C].EixoX = objeto2.Location.X;
                Eixos2[C].EixoY = objeto2.Location.Y + Tamanho2.Altura;
                Eixos2[D].EixoX = objeto2.Location.X + Tamanho2.Largura;
                Eixos2[D].EixoY = objeto2.Location.Y + Tamanho2.Altura;


                //Colisão AC com BD//
                if (Eixos2[A].EixoY >= Eixos1[B].EixoY && Eixos2[A].EixoY <= Eixos1[C].EixoY && Eixos2[A].EixoX >= Eixos1[A].EixoX && Eixos2[A].EixoX <= Eixos1[B].EixoX)
                { return 1; }

                if (Eixos2[A].EixoX >= Eixos1[C].EixoX && Eixos2[A].EixoX <= Eixos1[D].EixoX && Eixos2[A].EixoY >= Eixos1[A].EixoY && Eixos2[A].EixoY <= Eixos1[C].EixoY)
                { return 1; }

                if (Eixos2[C].EixoY >= Eixos1[B].EixoY && Eixos2[C].EixoY <= Eixos1[C].EixoY && Eixos2[A].EixoX >= Eixos1[A].EixoX && Eixos2[A].EixoX <= Eixos1[B].EixoX)
                { return 1; }

                if (Eixos2[C].EixoX >= Eixos1[C].EixoX && Eixos2[C].EixoX <= Eixos1[D].EixoX && Eixos2[A].EixoY >= Eixos1[A].EixoY && Eixos2[A].EixoY <= Eixos1[C].EixoY)
                { return 1; }


                if (Eixos1[A].EixoY >= Eixos2[B].EixoY && Eixos1[A].EixoY <= Eixos2[C].EixoY && Eixos1[A].EixoX >= Eixos2[A].EixoX && Eixos1[A].EixoX <= Eixos2[B].EixoX)
                { return 1; }

                if (Eixos1[A].EixoX >= Eixos2[C].EixoX && Eixos1[A].EixoX <= Eixos2[D].EixoX && Eixos1[A].EixoY >= Eixos2[A].EixoY && Eixos1[A].EixoY <= Eixos2[C].EixoY)
                { return 1; }

                if (Eixos1[C].EixoY >= Eixos2[B].EixoY && Eixos1[C].EixoY <= Eixos2[C].EixoY && Eixos1[A].EixoX >= Eixos2[A].EixoX && Eixos1[A].EixoX <= Eixos2[B].EixoX)
                { return 1; }

                if (Eixos1[C].EixoX >= Eixos2[C].EixoX && Eixos1[C].EixoX <= Eixos2[D].EixoX && Eixos1[A].EixoY >= Eixos2[A].EixoY && Eixos1[A].EixoY <= Eixos2[C].EixoY)
                { return 1; }

                if (Eixos2[B].EixoX >= Eixos1[A].EixoX && Eixos2[B].EixoX <= Eixos1[B].EixoX && Eixos2[B].EixoY >= Eixos1[A].EixoY && Eixos2[B].EixoY <= Eixos1[C].EixoY)
                { return 1; }

                if (Eixos2[D].EixoX >= Eixos1[A].EixoX && Eixos2[D].EixoX <= Eixos1[B].EixoX && Eixos2[D].EixoY >= Eixos1[A].EixoY && Eixos2[D].EixoY <= Eixos1[C].EixoY)
                { return 1; }

                if (Eixos1[B].EixoX >= Eixos2[A].EixoX && Eixos1[B].EixoX <= Eixos2[B].EixoX && Eixos1[B].EixoY >= Eixos2[A].EixoY && Eixos1[B].EixoY <= Eixos2[C].EixoY)
                { return 1; }

                if (Eixos1[D].EixoX >= Eixos2[A].EixoX && Eixos1[D].EixoX <= Eixos2[B].EixoX && Eixos1[D].EixoY >= Eixos2[A].EixoY && Eixos1[D].EixoY <= Eixos2[C].EixoY)
                { return 1; }
            }
            return 0;
        }
        public int Range()
        {
            Tamanhos Tamanho1, Tamanho2;
            Eixos[] Eixos1 = new Eixos[4];
            Eixos[] Eixos2 = new Eixos[4];

            Tamanho1.Largura = objeto1.Size.Width;
            Tamanho1.Altura = objeto1.Size.Height;
            Tamanho2.Largura = objeto2.Size.Width;
            Tamanho2.Altura = objeto2.Size.Height;

            Eixos1[A].EixoX = objeto1.Location.X;
            Eixos1[A].EixoY = objeto1.Location.Y;
            Eixos1[B].EixoX = objeto1.Location.X + (Tamanho1.Largura/2);
            Eixos1[B].EixoY = objeto1.Location.Y;
            Eixos1[C].EixoX = objeto1.Location.X;
            Eixos1[C].EixoY = objeto1.Location.Y + (Tamanho1.Altura/2);
            
            Eixos2[A].EixoX = objeto2.Location.X;
            Eixos2[A].EixoY = objeto2.Location.Y;
            Eixos2[B].EixoX = objeto2.Location.X + (Tamanho2.Largura/2);
            Eixos2[B].EixoY = objeto2.Location.Y;
            Eixos2[C].EixoX = objeto2.Location.X;
            Eixos2[C].EixoY = objeto2.Location.Y + (Tamanho2.Altura/2);
            objeto1.Text = ((int)Math.Sqrt(((Eixos2[C].EixoY - Eixos1[C].EixoY) * (Eixos2[C].EixoY - Eixos1[C].EixoY)) + ((Eixos2[B].EixoX - Eixos1[B].EixoX) * (Eixos2[B].EixoX - Eixos1[B].EixoX)))).ToString();

            return (int)Math.Sqrt(((Eixos2[C].EixoY - Eixos1[C].EixoY) * (Eixos2[C].EixoY - Eixos1[C].EixoY))+ ((Eixos2[B].EixoX - Eixos1[B].EixoX)* (Eixos2[B].EixoX - Eixos1[B].EixoX)));
        }
   
        public void destruir()
        {

            for (int x = 0; x < Objetos.Length; x++)
            {
                if (Colisao()==1)
                {
                    Objetos[x].Size = new Size(0, 0);
                }
            }
        }


        public void mover(int e)
        {
            Random random = new Random();
            if (e == 81)
            {
                objeto1.Location = new Point(objeto1.Location.X - velocidade, objeto1.Location.Y - velocidade);

                for (int x = 0; x < Objetos.Length; x++)
                {
                    if (Colisao() == 1)
                    {
                        objeto1.Location = new Point(objeto1.Location.X + velocidade, objeto1.Location.Y + velocidade);
                    }
                }
            }

            if (e == 69)
            {
                objeto1.Location = new Point(objeto1.Location.X + velocidade, objeto1.Location.Y - velocidade);

                for (int x = 0; x < Objetos.Length; x++)
                {
                    if (Colisao() == 1)
                    {
                        objeto1.Location = new Point(objeto1.Location.X - velocidade, objeto1.Location.Y + velocidade);
                    }

                }
            }

            if (e == 90)
            {
                objeto1.Location = new Point(objeto1.Location.X - velocidade, objeto1.Location.Y + velocidade);

                for (int x = 0; x < Objetos.Length; x++)
                {
                    if (Colisao() == 1)
                    {
                        objeto1.Location = new Point(objeto1.Location.X + velocidade, objeto1.Location.Y - velocidade);
                    }

                }
            }

            if (e == 67)
            {
                objeto1.Location = new Point(objeto1.Location.X + velocidade, objeto1.Location.Y + velocidade);

                for (int x = 0; x < Objetos.Length; x++)
                {
                    if (Colisao() == 1 )
                    {
                        objeto1.Location = new Point(objeto1.Location.X - velocidade, objeto1.Location.Y - velocidade);
                    }

                }
            }

            if (e == 87)
            {
                objeto1.Location = new Point(objeto1.Location.X, objeto1.Location.Y - velocidade);

                for (int x = 0; x < Objetos.Length; x++)
                {
                    if (Colisao() == 1)
                    {
                        objeto1.Location = new Point(objeto1.Location.X, objeto1.Location.Y + velocidade);
                    }
                }
            }
                if (e == 83)
                {
                    objeto1.Location = new Point(objeto1.Location.X, objeto1.Location.Y + velocidade);
                    for (int x = 0; x <Objetos.Length; x++)
                    {
                        if(Colisao() == 1)
                        {
                            objeto1.Location = new Point(objeto1.Location.X, objeto1.Location.Y - velocidade);
                        }
                    }
                }

                if (e == 65)
                {
                    objeto1.Location = new Point(objeto1.Location.X - velocidade, objeto1.Location.Y);

                    for (int x = 0; x < Objetos.Length; x++)
                    {
                        if(Colisao() == 1)
                        {
                            objeto1.Location = new Point(objeto1.Location.X + velocidade, objeto1.Location.Y);
                        }
                    }
                }

                if (e == 68)
                {
                    objeto1.Location = new Point(objeto1.Location.X + velocidade, objeto1.Location.Y);
                    for (int x = 0; x < Objetos.Length; x++)
                    {
                        if (Colisao() == 1)
                        {
                            objeto1.Location = new Point(objeto1.Location.X - velocidade, objeto1.Location.Y);
                        }
                    }
                }
        }
    }
}
