using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Contrato
{
    class Contrato
    {
        public Contrato(DateTime data, string nome, TipoContrato tipoContrato)
        {
            Data = data;
            Nome = nome;
            TipoContrato = tipoContrato;
        }

        public DateTime Data { get; private set; }
        public string Nome { get; private set; }
        public TipoContrato TipoContrato { get; private set; }
        public void Avanca()
        {
            if (this.TipoContrato == TipoContrato.Novo) this.TipoContrato = TipoContrato.EmAndamento;
            else if (this.TipoContrato == TipoContrato.EmAndamento) this.TipoContrato = TipoContrato.Acertado;
            else if (this.TipoContrato == TipoContrato.Acertado) this.TipoContrato = TipoContrato.Concluido;
        }
        public Estado SalvaEstado()
        {
            return new Estado(new Contrato(this.Data, this.Nome, this.TipoContrato));
        }
    }
}
