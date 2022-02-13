using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.Decorator
{
    public class ContaDecorator
    {
        public double Valor { get; private set; }

        public void Deposita(double valor) {

            this.Valor += valor;
        }
    }
}
