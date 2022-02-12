using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.ChainOfResposibility
{
    public interface Resposta
    {
        void Responde(Requisicao req, ContaChain conta);
        public Resposta? ProximaResposta { get; set; }
    }
}
