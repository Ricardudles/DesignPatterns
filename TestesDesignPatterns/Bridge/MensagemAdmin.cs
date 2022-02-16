using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.Bridge
{
    public class MensagemAdmin : IMensagem
    {
        public string Nome { get; set; }
        public IEnviador Enviador { get; set; }

        public MensagemAdmin(string nome)
        {
            this.Nome = nome;
        }

        public void Envia() {
            this.Enviador.Envia(this);
        }

        public string Formata() {
            return String.Format("Mensagem para o admin {0}", Nome);
        }
    }
}
