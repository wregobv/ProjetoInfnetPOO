using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public abstract class TransacaoMonetaria : TransacaoBancaria
    {
        public TransacaoBancaria TransacaoBancaria { get; set; }
        public Extrato Extrato { get; set; }

        public TransacaoMonetaria(ContaCorrente conta) : base(conta)
        {

        }

        public decimal Valor { get; set; }
        //public Comprovante Comprovante { get; protected set; }
        //public abstract void Executa();

    }



}
