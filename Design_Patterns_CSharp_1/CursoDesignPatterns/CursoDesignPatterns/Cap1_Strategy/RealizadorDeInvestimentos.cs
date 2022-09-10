using System;

namespace CursoDesignPatterns.Cap1_Strategy
{
    public class RealizadorDeInvestimentos
    {
        public void Investir(Conta conta, EstrategiaDeInvestimento investimento)
        {
            double resultado = investimento.Calcula(conta);
            conta.Deposita(resultado * 0.75);
            Console.WriteLine("Novo saldo: " + conta.Saldo);
        }
    }
}
