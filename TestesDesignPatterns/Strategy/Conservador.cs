using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.Strategy
{
    public class Conservador : Investimento
    {
        public double Calcula(Conta conta) {

            return conta.Saldo * 0.008;
        }
    }
}
