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
    public class Estrutura
    {
        Control[] dados = new Control[500];
        public int posicao = 0;
        public Estrutura()
        {

        }

        public void add(Control atual)
        {
            this.dados[posicao] = atual;
            this.posicao++;
        }

        public Control[] getDados()
        {
            Control[] dadosAtuais = new Control[posicao];

            for(int x=0; x<posicao; x++)
            {
                dadosAtuais[x] = dados[x];
            }

            return dadosAtuais;
        }

        public Control getUltimo()
        {
            return dados[posicao-1];
        }

        public Control getDado(int pos)
        {
            return dados[pos];
        }
    }
}
