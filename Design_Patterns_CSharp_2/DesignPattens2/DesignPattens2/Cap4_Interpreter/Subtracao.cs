using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattens2.Capitulo05;

namespace DesignPattens2.Capitulo04
{
    class Subtracao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = this.Esquerda.Avalia();
            int valorDireita = this.Direita.Avalia();
            return valorEsquerda - valorDireita;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeSubtracao(this);
        }
    }
}
