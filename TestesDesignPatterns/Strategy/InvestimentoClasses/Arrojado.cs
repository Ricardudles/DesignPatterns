using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.Strategy
{
    public class Arrojado : Investimento
    {
        private Random random;

        public Arrojado() {
        
         this.random = new Random();

        }
        public double Calcula(Conta conta) {

            int valor = random.Next(10);

            if (valor >= 0 && valor <= 1) {
                return conta.Saldo * 0.05;
            } else if (valor >= 2 && valor <= 4) {
                return conta.Saldo * 0.3;
             } else return conta.Saldo * 0.0006;
        }
    }
}
