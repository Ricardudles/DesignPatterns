using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDesignPatterns.Visitor;

namespace TestesDesignPatterns.Interpreter
{
    public class Divisao : IExpressao
    {
        public IExpressao Esquerda { get; set; }
        public IExpressao Direita { get; set; }
        public Divisao(IExpressao esquerda, IExpressao direita)
        {

            this.Esquerda = esquerda;
            this.Direita = direita;

        }

        public int Avalia()
        {
            int esquerda = Esquerda.Avalia();
            int direita = Direita.Avalia();

            return esquerda / direita;

        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeDivisao(this);
        }
    }
}
