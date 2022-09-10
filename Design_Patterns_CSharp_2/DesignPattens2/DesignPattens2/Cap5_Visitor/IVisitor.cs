using DesignPattens2.Capitulo04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Capitulo05
{
    interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubtracao(Subtracao subtracao);
        void ImprimeNumero(Numero Numero);
    }
}
