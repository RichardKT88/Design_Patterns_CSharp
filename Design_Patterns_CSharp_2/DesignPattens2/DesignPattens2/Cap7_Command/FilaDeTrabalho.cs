using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Capitulo07
{
    class FilaDeTrabalho
    {
        private IList<IComando> Comandos = new List<IComando>();

        public void Adiciona(IComando comando)
        {
            this.Comandos.Add(comando);
        }

        public void Processa()
        {
            foreach (IComando comando in this.Comandos)
            {
                comando.Executa();
            }
        }

    }
}
