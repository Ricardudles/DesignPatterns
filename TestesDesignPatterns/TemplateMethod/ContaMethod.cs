using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.TemplateMethod
{
    public class ContaMethod
    {
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Agencia { get; set; }
        public string Saldo { get; set; }

        public ContaMethod(string nome, string numero,string Agencia,string Saldo) {
            this.Nome = nome;
            this.Numero = numero;
            this.Agencia = Agencia;
            this.Saldo = Saldo;
        }
    }
}
