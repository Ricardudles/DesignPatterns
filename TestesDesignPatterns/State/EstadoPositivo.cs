using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.State
{
    public class EstadoPositivo : EstadoConta
    {
        public void Saca(ContaState conta, double valor) {
            conta.Saldo -= valor;

            Console.WriteLine("\nEstado Positivo Saca: \n Estado: " + conta.Estado + "\n Saldo: " + conta.Saldo);

            if (conta.Saldo < 0) conta.Estado = new EstadoNegativo();
        }
        public void Deposita(ContaState conta, double valor) {
            conta.Saldo += valor * 0.98;

            Console.WriteLine("\nEstado Positivo Deposita: \n Estado: " + conta.Estado + "\n Saldo: " + conta.Saldo);

        }

    }
}
