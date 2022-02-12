using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.TemplateMethod
{
    abstract class Relatorio
    {
        protected abstract void Cabecalho();
        protected abstract void Corpo(IList<ContaMethod> contas);
        protected abstract void Rodape();

        public void ImprimeRelatorio(IList<ContaMethod> contas) {

            Cabecalho();
            Corpo(contas);
            Rodape();

        }

    }
}
