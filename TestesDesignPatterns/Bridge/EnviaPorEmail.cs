using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.Bridge
{
    public class EnviaPorEmail : IEnviador
    {
        public void Envia(IMensagem mensagem) {
            Console.WriteLine("Mensagem enviada por email");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
