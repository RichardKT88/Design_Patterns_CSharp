using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Capitulo07
{
    class FinalizaPedido : IComando
    {
        private Pedido Pedido;

        public FinalizaPedido(Pedido pedido)
        {
            this.Pedido = pedido;

        }
        public void Executa()
        {
            Console.WriteLine("Finalizando o pedido do Cliente {0}", this.Pedido.Cliente);
            Pedido.Finaliza();
        }
    }
}
