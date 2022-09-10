using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Capitulo07
{
    class PagaPedido : IComando
    {
        private Pedido Pedido;

        public PagaPedido(Pedido pedido)
        {
            this.Pedido = pedido;

        }
        public void Executa()
        {
            Console.WriteLine("Pagando o pedido do Cliente {0}", this.Pedido.Cliente);
            Pedido.Paga();

        }
    }
}
