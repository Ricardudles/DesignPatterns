using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.Strategy
{
    public class Moderado : Investimento
    {
        private Random random;
        public Moderado()
        {
            this.random = new Random();
        }
        public double Calcula(Conta conta)
        {
            if (random.Next(2) == 0)
            {
                return conta.Saldo * 0.025;
            }

            return conta.Saldo * 0.007;
        }
    }
}
