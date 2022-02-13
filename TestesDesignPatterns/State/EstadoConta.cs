using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.State
{
    public interface EstadoConta
    {
        void Saca(ContaState conta, double valor);
        void Deposita(ContaState conta, double valor);
    }
}
