using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.ChainOfResposibility
{
    public class RespostaEmXML : Resposta
    {
        public Resposta? ProximaResposta { get; set; }

        public RespostaEmXML()
        {

        }
        public RespostaEmXML(Resposta proximaResposta)
        {
            this.ProximaResposta = proximaResposta;
        }
        public void Responde(Requisicao req, ContaChain conta) {

            if (req.Formato == Formato.XML) {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else {
                Console.WriteLine("Estou em: XML, vou para: " + ProximaResposta?.GetType());
                ProximaResposta?.Responde(req, conta);
            }

        }
    }
}
