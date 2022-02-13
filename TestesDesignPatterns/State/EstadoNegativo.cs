using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.State
{
    public class EstadoNegativo : EstadoConta
    {
        public void Saca(ContaState conta, double valor) {
            throw new Exception("Sua conta está no vermelho. Não é possível sacar!");
        }
        public void Deposita(ContaState conta, double valor) {
            conta.Saldo += valor * 0.95;

            Console.WriteLine("\nEstado Positivo Deposita: \n Estado: " + conta.Estado + "\n Saldo: " + conta.Saldo);


            if (conta.Saldo > 0) conta.Estado = new EstadoPositivo();
        }
    }
}
