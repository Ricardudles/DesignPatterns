using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.Memento
{
    public class Historico
    {
        private IList<Estado> Estados = new List<Estado>();

        public Estado Pega(int index)
        {
            return Estados[index];
        }

        public void Adiciona(Estado estado)
        {
            Estados.Add(estado);
        }
    }
}
