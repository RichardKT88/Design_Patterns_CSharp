using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class RelatorioComplexos : TemplateRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Nome do banco: Banco das Coves.");
            Console.WriteLine("Endereço: Rua das Compras 42");
            Console.WriteLine("Telefone do banco: 9696mole-6duro.");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta conta in contas)
            {
                Console.WriteLine("Titular: {0} -  Saldo: {1}", conta.Titular, conta.Saldo);
            }
        }

        protected override void Rodape()
        {
            Console.WriteLine("Email: contatos@bancodascoves.com.br");
            Console.WriteLine("Data: {0}", DateTime.Now);
        }
    }
}
