using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.Strategy
{
    public interface Investimento
    {
        double Calcula(Conta conta);

    }
}
