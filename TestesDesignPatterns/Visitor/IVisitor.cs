using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDesignPatterns.Interpreter;

namespace TestesDesignPatterns.Visitor
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubtracao(Subtracao subtracao);
        void ImprimeMultiplicacao(Multiplicacao multiplicacao);
        void ImprimeDivisao(Divisao divisao);
        void ImprimeNumero(Numero numero);
    }
}
