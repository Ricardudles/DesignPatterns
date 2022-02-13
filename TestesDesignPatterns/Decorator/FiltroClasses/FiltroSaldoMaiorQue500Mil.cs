using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.Decorator
{
    public class FiltroSaldoMaiorQue500Mil : Filtro
    {
        public FiltroSaldoMaiorQue500Mil(Filtro proximoFiltro) : base(proximoFiltro) { }

        public FiltroSaldoMaiorQue500Mil() : base() { }

        public override IList<ContaDecorator> Filtra(IList<ContaDecorator> contas)
        {
            var filtrado = new List<ContaDecorator>();
            foreach (ContaDecorator conta in contas)
            {
                if(conta.Valor > 500000)
                filtrado.Add(conta);
            }
            foreach (ContaDecorator conta in Proximo(contas)) {
                filtrado.Add(conta);
            }
            return filtrado;
        }
    }
}
