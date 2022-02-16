using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.Bridge
{
    public class MensagemUsuario : IMensagem
    {
        public string Nome { get; set; }
        public IEnviador Enviador { get; set; }

        public MensagemUsuario(string nome )
        {
            this.Nome = nome; 
        }

        public void Envia() {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return String.Format("Mensagem enviada para o usuario {0}", Nome);
        }
    }
}
