using DesignPattens2.Capitulo01;
using DesignPattens2.Capitulo02;
using DesignPattens2.Capitulo03;
using DesignPattens2.Capitulo04;
using DesignPattens2.Capitulo05;
using DesignPattens2.Capitulo06;
using DesignPattens2.Capitulo07;
using DesignPattens2.Capitulo08;
using DesignPattens2.Capitulo09;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPattens2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aula 01
            IDbConnection conexao = new ConnectionFactory().GetConnection();

            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "Select * trom tabela";            
             */

            /* Aula 02
            NotasMusicais notas = new NotasMusicais();

            IList<INota>  musica = new List<INota>()
            { 
                notas.Pega("do"), notas.Pega("re"), notas.Pega("mi"), notas.Pega("fa"),  notas.Pega("fa"),
                notas.Pega("fa"), notas.Pega("do"), notas.Pega("re"), notas.Pega("do"),  notas.Pega("re"),
                notas.Pega("re"), notas.Pega("re"), notas.Pega("do"), notas.Pega("sol"), notas.Pega("fa"),
                notas.Pega("mi"), notas.Pega("mi"), notas.Pega("mi"), notas.Pega("do"),  notas.Pega("re"),
                notas.Pega("mi"), notas.Pega("fa"), notas.Pega("fa"), notas.Pega("fa")
            };

            Piano piano = new Piano();
            piano.Toca(musica);
            */

            /* Aula 03 

            Historico historico = new Historico();
            Contrato c = new Contrato(DateTime.Now,"lario", TipoContrato.Novo);

            historico.Adiciona(c.SalvaEstado());          

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());            

            Console.WriteLine(historico.Pega(0).Contrato.Tipo);
            */

            /* Aula 04 

            // (1 + 10) + ( 20 - 10)

            //IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            //IExpressao direita = new Subtracao(new Numero(20), new Numero(10));

            //IExpressao soma = new Soma(esquerda, direita);

            //Console.WriteLine(soma.Avalia());

            Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            Func<int> funcao = Expression.Lambda<Func<int>>(soma).Compile();

            Console.WriteLine(funcao());
            */

            /* Aula 05 

            IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));

            IExpressao soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());
            ImpressoraVisitor impressora = new ImpressoraVisitor();
            soma.Aceita(impressora);

            */

            /* Aula 06 

            IMensagem mensagem = new MensagemCliente("Victor");
            IEnviador enviador = new EnviaPorEmail();
            mensagem.Enviador = enviador;

            mensagem.Envia();
            */

            /* Aula 07 
            FilaDeTrabalho fila = new FilaDeTrabalho();
            Pedido pedido1 = new Pedido("Mauricio", 100.0);
            Pedido pedido2 = new Pedido("Marcelo", 200.0);
            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));

            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();
            */

            /* Aula 08 
            Cliente cliente = new Cliente();
            cliente.Nome = "victor";
            cliente.Endereco = "Rua Vergueiro";
            cliente.DataDeNascimento = DateTime.Now;

            String xml = new GeradorDeXml().GeraXML(cliente);

            Console.WriteLine(xml);
            */

            /* Aula 09 */

            string cpf = "1234";
            EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            Cliente cliente = facade.BuscaCliente(cpf);

            var fatura = facade.CriaFatura(cliente, 5000);
            facade.GeraCobranca(tipo, Boleto, fatura);
        }
    }
}
