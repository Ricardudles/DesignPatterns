using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.ChainOfResposibility
{
    public class RespostaEmCSV : Resposta
    {
        public Resposta? ProximaResposta { get; set; }

        public RespostaEmCSV()
        {

        }
        public RespostaEmCSV(Resposta proximaResposta) { 
            this.ProximaResposta = proximaResposta;
        }
        public void Responde(Requisicao req, ContaChain conta) {

            if (req.Formato == Formato.CSV) {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else {
                Console.WriteLine("Estou em: CSV, vou para: " + ProximaResposta?.GetType());
                ProximaResposta?.Responde(req, conta);
            }

        }
    }
}
