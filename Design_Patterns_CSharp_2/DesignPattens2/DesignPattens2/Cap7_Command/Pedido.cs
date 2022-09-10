using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Capitulo07
{
    public class Pedido
    {
        public String Cliente { get; private set; }
        public double Valor { get; private set; }
        public DateTime DataFinalizacao { get; private set; }
        public Status Status { get; private set; }

        public Pedido(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Status = Status.Novo;
        }

        public void Paga()
        {
            this.Status = Status.Pago;
        }

        public void Finaliza()
        {            
            this.Status = Status.Entregue;
            this.DataFinalizacao = DateTime.Now;
        }    
    }
}
