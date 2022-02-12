using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.TemplateMethod
{
    class RelatorioSimples : Relatorio
    {
        protected override void Cabecalho() {
            Console.WriteLine("Realtorio Simples \nBanco XYZ");
        }
        protected override void Corpo(IList<ContaMethod> contas) {
            foreach (ContaMethod c in contas)
            {
                Console.WriteLine(c.Nome + " - " + c.Saldo);
            }
        }
        protected override void Rodape() {
            Console.WriteLine("(11) 1234-5678");
        }

    }
}
