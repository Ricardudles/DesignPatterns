using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.ChainOfResposibility
{
    public class ContaChain
    {
        public double Saldo { get; private set; }
        public String Titular { get; private set; }

        public ContaChain(String titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
}
