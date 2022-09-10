using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Capitulo06
{
    class EnviaPorEmail : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a mensagem por E-mail");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
