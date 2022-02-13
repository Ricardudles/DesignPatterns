using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDesignPatterns.Visitor;

namespace TestesDesignPatterns.Interpreter
{
    public class Numero : IExpressao
    {
        public int Valor { get; set; }
        public Numero(int numero)
        {
            this.Valor = numero;
        }
        public int Avalia()
        {
            return Valor;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeNumero(this);
        }
    }
}
