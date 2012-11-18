using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public abstract class TransacaoMonetaria : TransacaoBancaria
    {
        public virtual TransacaoBancaria TransacaoBancaria { get; set; }

        public TransacaoMonetaria(ContaCorrente conta)
            : base(conta)
        {

        }

        public decimal Valor { get; set; }
    }



}
