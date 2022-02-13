using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.Decorator
{
    public abstract class Filtro
    {
        protected Filtro ProximoFiltro { get; private set; }

        public Filtro() { }
        public Filtro(Filtro proximoFiltro)
        {
            this.ProximoFiltro = proximoFiltro;
        }
        public abstract IList<ContaDecorator> Filtra(IList<ContaDecorator> contas);

        protected IList<ContaDecorator> Proximo(IList<ContaDecorator> contas)
        {
            //envia a lista dos itens que entraram no filtro, se nao envia vazio;
            if (ProximoFiltro != null) return ProximoFiltro.Filtra(contas);
            else return new List<ContaDecorator>();
        }

    }
}
