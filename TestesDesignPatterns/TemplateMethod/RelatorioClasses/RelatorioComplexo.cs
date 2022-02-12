using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.TemplateMethod
{
    class RelatorioComplexo : Relatorio
    {
        protected override void Cabecalho() {
            Console.WriteLine("Realtorio Complexo");
            Console.WriteLine("Banco XYZ");
            Console.WriteLine("Avenida Paulista, 1234");
            Console.WriteLine("(11) 1234-5678");
        }
        protected override void Corpo(IList<ContaMethod> contas) {
            foreach (ContaMethod c in contas)
            {
                Console.WriteLine(c.Nome + " - " + c.Numero + " - " + c.Agencia + " - " + c.Saldo);
            }
        }
        protected override void Rodape() {
            Console.WriteLine("banco@xyz.com.br");
            Console.WriteLine(DateTime.Now);
        }

    }
}
