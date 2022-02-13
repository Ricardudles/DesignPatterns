using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.FlyWeight
{
    public class NotasMusicais
    {
        private static IDictionary<string, INota> notas =
            new Dictionary<string, INota>() {
        { "do", new Do() } ,
        { "re", new Re() } ,
        { "mi", new Mi() },
        { "fa", new Fa() },
        { "sol", new Sol() },
        { "la", new La() },
        { "si", new Si() }
        };

        public INota Pega(string nome)
        {
            return notas[nome];
        }
    }
}
