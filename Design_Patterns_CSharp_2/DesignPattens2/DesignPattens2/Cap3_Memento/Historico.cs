using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Capitulo03
{
    class Historico
    {
        private IList<Estado> Estado = new List<Estado>();

        public void Adiciona(Estado estado)
        {
            this.Estado.Add(estado);
        }

        public Estado Pega(int indice)
        {
            return Estado[indice];
        }
    }
}
