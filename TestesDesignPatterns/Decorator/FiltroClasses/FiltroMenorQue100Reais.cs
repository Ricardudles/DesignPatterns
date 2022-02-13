using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.Decorator
{
    public  class FiltroMenorQue100Reais : Filtro
    {
        public FiltroMenorQue100Reais(Filtro outroFiltro) : base(outroFiltro) { }

        public FiltroMenorQue100Reais() : base() { }

        public override IList<ContaDecorator> Filtra(IList<ContaDecorator> contas)
        {
            IList<ContaDecorator> filtrada = new List<ContaDecorator>();
            foreach (ContaDecorator c in contas)
            {
                if (c.Valor < 100) filtrada.Add(c);
            }
            foreach (ContaDecorator c in Proximo(contas))
            {
                filtrada.Add(c);
            }
            return filtrada;
        }
    }
}
