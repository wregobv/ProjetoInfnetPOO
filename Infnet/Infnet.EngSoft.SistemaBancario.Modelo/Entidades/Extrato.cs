using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public class Extrato : TransacaoBancaria
    {
        public virtual TransacaoMonetaria TransacaoMonetaria { get; set; }

        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public Extrato(ContaCorrente conta)
            : base(conta)
        {

        }

        public override void Executa()
        {

        }

        public override Comprovante Comprovante
        {
            get
            {
                return Comprovante;
            }
            set
            {
                Comprovante = Comprovante;
            }
        }

    }
}
