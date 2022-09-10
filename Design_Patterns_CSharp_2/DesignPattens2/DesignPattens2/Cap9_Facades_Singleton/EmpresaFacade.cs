using DesignPattens2.Capitulo08;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Capitulo09
{
    class EmpresaFacade
    {
        public Cliente BuscaCliente(string cpf)
        {
            return new ClienteDAO().BuscaPorCpf(cpf);
        }

        public Fatura CriaFatura(Cliente cliente, double valor)
        {
            return new Fatura(cliente, valor);
        }

        public Cobranca GeraCobranca(Tiop tipo, Fatura fatura)
        {
            GeraCobranca cobranca = new GeraCobranca(tipo, fatura);
            cobranca.Emite();
            return cobranca;
        }

        public CotnatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        {
            ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            contato.Dispara();
            return contato;
        }
    }
}
