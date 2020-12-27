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
    class Cells
    {
        fisica scriptInimigo;
        Control celula;
        int Distanticia;
        int velociade=2;
        Form1 form;

        public Cells(Control eny,  fisica script, Form1 form)
        {
            this.celula = eny;
            this.scriptInimigo = script;
            this.form = form;
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
                    celula.Location = new Point(celula.Location.X + velociade, celula.Location.Y);

                    if (scriptInimigo.Colisao() == 1)
                    {
                        celula.Location = new Point(celula.Location.X - velociade, celula.Location.Y);
                        if (scriptInimigo.objeto2.Tag == "comida")
                        {
                            scriptInimigo.objeto2.Location = new Point(0, 0);
                            celula.BackColor = Color.Red;
                        }

                        if (scriptInimigo.objeto2.Tag == "celula" && celula.BackColor==Color.Red && celula.Text=="F" && scriptInimigo.objeto2.Text=="M")
                        {
                            form.novaCelula(celula.Location.X, celula.Location.Y);
                            celula.BackColor = Color.Orange;
                        }
                        colidiu = true;
                    }

                    if (celula.Location.X < 30 || celula.Location.X > 1007)
                    {
                        celula.Location = new Point(celula.Location.X - velociade, celula.Location.Y);
                        colidiu = true;
                    }
                    if (celula.Location.Y < 30 || celula.Location.Y > 450)
                    {
                        celula.Location = new Point(celula.Location.X - velociade, celula.Location.Y );
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
                    celula.Location = new Point(celula.Location.X - velociade, celula.Location.Y);


                    if (scriptInimigo.Colisao() == 1)
                    {   
                        celula.Location = new Point(celula.Location.X + velociade, celula.Location.Y);
                        if (scriptInimigo.objeto2.Tag == "comida")
                        {
                            celula.BackColor = Color.Red;
                            scriptInimigo.objeto2.Location = new Point(0, 0);
                        }

                        if (scriptInimigo.objeto2.Tag == "celula" && celula.BackColor == Color.Red && celula.Text == "F" && scriptInimigo.objeto2.Text == "M")
                        {
                            form.novaCelula(celula.Location.X, celula.Location.Y);
                            celula.BackColor = Color.Orange;
                        }
                        colidiu = true;
                    }

                    if (celula.Location.X < 30 || celula.Location.X > 1007)
                    {
                        celula.Location = new Point(celula.Location.X + velociade, celula.Location.Y);
                        colidiu = true;
                    }
                    if (celula.Location.Y < 30 || celula.Location.Y > 450)
                    {
                        celula.Location = new Point(celula.Location.X + velociade, celula.Location.Y);
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
                    celula.Location = new Point(celula.Location.X, celula.Location.Y + velociade);
                    if (scriptInimigo.Colisao() == 1)
                    {
                        celula.Location = new Point(celula.Location.X, celula.Location.Y - velociade);
                        if (scriptInimigo.objeto2.Tag == "comida")
                        {
                            celula.BackColor = Color.Red;
                            scriptInimigo.objeto2.Location = new Point(0, 0);
                        }
                        if (scriptInimigo.objeto2.Tag == "celula" && celula.BackColor == Color.Red && celula.Text == "F" && scriptInimigo.objeto2.Text == "M")
                        {
                            form.novaCelula(celula.Location.X, celula.Location.Y);
                            celula.BackColor = Color.Orange;
                        }
                        colidiu = true;
                    }

                    if (celula.Location.X < 30 || celula.Location.X > 1007)
                    {
                        celula.Location = new Point(celula.Location.X , celula.Location.Y - velociade);
                        colidiu = true;
                    }
                    if (celula.Location.Y < 30 || celula.Location.Y > 450)
                    {
                        celula.Location = new Point(celula.Location.X, celula.Location.Y - velociade);
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
                    celula.Location = new Point(celula.Location.X , celula.Location.Y - velociade);
                    if (scriptInimigo.Colisao() == 1)
                    {
                        celula.Location = new Point(celula.Location.X , celula.Location.Y + velociade);
                        if(scriptInimigo.objeto2.Tag == "comida")
                        {
                            celula.BackColor = Color.Red;
                            scriptInimigo.objeto2.Location = new Point(0, 0);
                        }
                        if (scriptInimigo.objeto2.Tag == "celula" && celula.BackColor == Color.Red && celula.Text == "F" && scriptInimigo.objeto2.Text == "M")
                        {
                            form.novaCelula(celula.Location.X, celula.Location.Y);
                            celula.BackColor = Color.Orange;
                        }
                        colidiu = true;
                    }

                    if (celula.Location.X < 30 || celula.Location.X > 1007)
                    {
                        celula.Location = new Point(celula.Location.X , celula.Location.Y + velociade);
                        colidiu = true;
                    }
                    if (celula.Location.Y < 30 || celula.Location.Y > 450)
                    {
                        celula.Location = new Point(celula.Location.X, celula.Location.Y + velociade);
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

