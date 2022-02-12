using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.ChainOfResposibility
{
    public class RespostaEmPorcento : Resposta
    {
        public Resposta? ProximaResposta { get; set; }

        public RespostaEmPorcento()
        {

        }
        public RespostaEmPorcento(Resposta proximaResposta)
        {
            this.ProximaResposta = proximaResposta;
        }
        public void Responde(Requisicao req, ContaChain conta) {

            if (req.Formato == Formato.PORCENTO) {
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
            }
            else {
                Console.WriteLine("Estou em: Porcento, vou para: " + ProximaResposta?.GetType());
                ProximaResposta?.Responde(req, conta);
            }

        }
    }
}
