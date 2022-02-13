using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.State
{
    public class ContaState
    {
        public double Saldo { get; set; }
        public EstadoConta Estado;

        public ContaState() {
            this.Saldo = 0;
            this.Estado = new EstadoPositivo();
        }

        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }

        public void Deposita(double valor)
        {
            Estado.Deposita(this, valor);
        }
    }
}
