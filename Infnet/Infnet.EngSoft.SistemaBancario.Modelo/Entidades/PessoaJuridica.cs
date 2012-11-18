using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public class PessoaJuridica : Cliente
    {
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public DateTime DataFundacao { get; set; }

        public virtual Cliente cliente { get; set; }
    }
}
