using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.Strategy
{
    public class RealizadorDeInvestimentos
    {
        public void Realiza(Conta conta, Investimento investimento) {

            double resultado = investimento.Calcula(conta);

            conta.Deposita(resultado * 0.75);

            Console.WriteLine("Novo Saldo: " + conta.Saldo + "\n Tipo de investimento: " + investimento.GetType());
        }
    }
}
