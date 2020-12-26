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
    class Inimigo
    {
        fisica scriptInimigo;
        Control enemy;
        int Distanticia;
        int velociade=2;
        Form1 form;

        public Inimigo(Control eny,  fisica script, Form1 form)
        {
            this.enemy = eny;
            //this.Distanticia = Dist;
            this.scriptInimigo = script;
            this.form = form;
        }

        public async void mudarCor()
        {
            await Task.Delay(5000);
            enemy.BackColor = Color.Red;
        }
       

        public async void movimento()
        {
            
            bool colidiu = false;
            int x = 0;
            Random random = new Random(DateTime.Now.Millisecond);

            if (random.Next(1, 3) == 1)
            {
                while (x < random.Next(50, 100) && !colidiu)
                {
                    enemy.Location = new Point(enemy.Location.X + velociade, enemy.Location.Y);

                    if (scriptInimigo.Colisao() == 1)
                    {
                        enemy.Location = new Point(enemy.Location.X - velociade, enemy.Location.Y);
                        if (scriptInimigo.objeto2.Tag == "comida")
                        {
                            scriptInimigo.objeto2.Location = new Point(0, 0);
                            enemy.BackColor = Color.Red;
                        }

                        if (scriptInimigo.objeto2.Tag == "celula" && enemy.BackColor==Color.Red && enemy.Text=="F" && scriptInimigo.objeto2.Text=="M")
                        {
                            form.novaCelula(enemy.Location.X, enemy.Location.Y);
                            enemy.BackColor = Color.Orange;
                        }
                        colidiu = true;
                    }

                    if (enemy.Location.X < 30 || enemy.Location.X > 1007)
                    {
                        enemy.Location = new Point(enemy.Location.X - velociade, enemy.Location.Y);
                        colidiu = true;
                    }
                    if (enemy.Location.Y < 30 || enemy.Location.Y > 450)
                    {
                        enemy.Location = new Point(enemy.Location.X - velociade, enemy.Location.Y );
                        colidiu = true;
                    }
                    await Task.Delay(25);
                    x++;
                }
            }
            else
            {
                while (x < random.Next(50, 100) && !colidiu)
                {
                    enemy.Location = new Point(enemy.Location.X - velociade, enemy.Location.Y);


                    if (scriptInimigo.Colisao() == 1)
                    {   
                        enemy.Location = new Point(enemy.Location.X + velociade, enemy.Location.Y);
                        if (scriptInimigo.objeto2.Tag == "comida")
                        {
                            enemy.BackColor = Color.Red;
                            scriptInimigo.objeto2.Location = new Point(0, 0);
                        }

                        if (scriptInimigo.objeto2.Tag == "celula" && enemy.BackColor == Color.Red && enemy.Text == "F" && scriptInimigo.objeto2.Text == "M")
                        {
                            form.novaCelula(enemy.Location.X, enemy.Location.Y);
                            enemy.BackColor = Color.Orange;
                        }
                        colidiu = true;
                    }

                    if (enemy.Location.X < 30 || enemy.Location.X > 1007)
                    {
                        enemy.Location = new Point(enemy.Location.X + velociade, enemy.Location.Y);
                        colidiu = true;
                    }
                    if (enemy.Location.Y < 30 || enemy.Location.Y > 450)
                    {
                        enemy.Location = new Point(enemy.Location.X + velociade, enemy.Location.Y);
                        colidiu = true;
                    }
                    await Task.Delay(25);
                    x++;
                }
            }
            movimentoRetrogrado();
        }

        public async void movimentoRetrogrado()
        {
            bool colidiu = false;
            int x = 0;
            Random random = new Random(DateTime.Now.Millisecond);

            if (random.Next(1, 3) == 1)
            {
                while (x < random.Next(1, 100) && !colidiu)
                {
                    enemy.Location = new Point(enemy.Location.X, enemy.Location.Y + velociade);
                    if (scriptInimigo.Colisao() == 1)
                    {
                        enemy.Location = new Point(enemy.Location.X, enemy.Location.Y - velociade);
                        if (scriptInimigo.objeto2.Tag == "comida")
                        {
                            enemy.BackColor = Color.Red;
                            scriptInimigo.objeto2.Location = new Point(0, 0);
                        }
                        if (scriptInimigo.objeto2.Tag == "celula" && enemy.BackColor == Color.Red && enemy.Text == "F" && scriptInimigo.objeto2.Text == "M")
                        {
                            form.novaCelula(enemy.Location.X, enemy.Location.Y);
                            enemy.BackColor = Color.Orange;
                        }
                        colidiu = true;
                    }

                    if (enemy.Location.X < 30 || enemy.Location.X > 1007)
                    {
                        enemy.Location = new Point(enemy.Location.X , enemy.Location.Y - velociade);
                        colidiu = true;
                    }
                    if (enemy.Location.Y < 30 || enemy.Location.Y > 450)
                    {
                        enemy.Location = new Point(enemy.Location.X, enemy.Location.Y - velociade);
                        colidiu = true;
                    }
                    await Task.Delay(25);
                    x++;
                }
            }
            else
            {
                while (x < random.Next(1, 100) && !colidiu)
                {
                    enemy.Location = new Point(enemy.Location.X , enemy.Location.Y - velociade);
                    if (scriptInimigo.Colisao() == 1)
                    {
                        enemy.Location = new Point(enemy.Location.X , enemy.Location.Y + velociade);
                        if(scriptInimigo.objeto2.Tag == "comida")
                        {
                            enemy.BackColor = Color.Red;
                            scriptInimigo.objeto2.Location = new Point(0, 0);
                        }
                        if (scriptInimigo.objeto2.Tag == "celula" && enemy.BackColor == Color.Red && enemy.Text == "F" && scriptInimigo.objeto2.Text == "M")
                        {
                            form.novaCelula(enemy.Location.X, enemy.Location.Y);
                            enemy.BackColor = Color.Orange;
                        }
                        colidiu = true;
                    }

                    if (enemy.Location.X < 30 || enemy.Location.X > 1007)
                    {
                        enemy.Location = new Point(enemy.Location.X , enemy.Location.Y + velociade);
                        colidiu = true;
                    }
                    if (enemy.Location.Y < 30 || enemy.Location.Y > 450)
                    {
                        enemy.Location = new Point(enemy.Location.X, enemy.Location.Y + velociade);
                        colidiu = true;
                    }
                    await Task.Delay(25);
                    x++;
                }
            }
            movimento();
        }
    }
}

