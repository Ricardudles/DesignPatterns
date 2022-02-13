using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.FlyWeight
{
    public class Piano
    {
        public void Toca(IList<INota> musica)
        {
            foreach (INota nota in musica)
            {
                Console.Beep(nota.Frequencia, 300);
            }

        }
    }
}
