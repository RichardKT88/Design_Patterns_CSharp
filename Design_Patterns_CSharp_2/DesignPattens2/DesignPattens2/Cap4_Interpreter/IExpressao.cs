using DesignPattens2.Capitulo05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Capitulo04
{
    interface IExpressao
    {

        int Avalia();

        void Aceita(IVisitor impressora);
    }
}
