using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDesignPatterns.Memento
{
    public class Contrato
    {
        public DateTime Data { get; private set; }
        public String Cliente { get; private set; }
        public TipoContrato Tipo { get; private set; }

        public Contrato(DateTime data, String cliente, TipoContrato tipo)
        {
            this.Data = data;
            this.Cliente = cliente;
            this.Tipo = tipo;
        }

        public void Avanca()
        {
            if (Tipo == TipoContrato.Novo) Tipo = TipoContrato.EmAndamento;
            else if (Tipo == TipoContrato.EmAndamento) Tipo = TipoContrato.Acertado;
            else if (Tipo == TipoContrato.Acertado) Tipo = TipoContrato.Concluido;
        }

        public Estado SalvaEstado()
        {
            return new Estado(new Contrato(this.Data, this.Cliente, this.Tipo));
        }
    }
}
