using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Capitulo06
{
    public interface IMensagem
    {
        IEnviador Enviador { get; set; }
        void Envia();

        string Formata();
    }
}
