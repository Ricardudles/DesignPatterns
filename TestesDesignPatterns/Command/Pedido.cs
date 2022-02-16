using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.Command
{
    public class Pedido
    {
        public String Cliente { get; private set; }
        public double Valor { get; private set; }
        public Status Status { get; private set; }
        public DateTime DataFinalizacao { get; private set; }

        public Pedido(String cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Status = Status.Novo;
        }

        public void Paga()
        {
            Console.WriteLine("Pedido Pago em nome de {0}",Cliente);
            Status = Status.Pago;
        }

        public void Finaliza()
        {
            Console.WriteLine("Pedido Finalizado em nome de {0}", Cliente);
            DataFinalizacao = DateTime.Now;
            Status = Status.Entregue;
        }
    }
}
