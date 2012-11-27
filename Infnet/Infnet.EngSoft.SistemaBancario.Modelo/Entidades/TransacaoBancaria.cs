using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public abstract class TransacaoBancaria
    {
        public System.DateTime Data { get; set; }
        public decimal Custo { get; set; }
        public ContaCorrente Conta { get; private set; }
        public abstract Comprovante Comprovante { get; protected set; }
        public abstract Comprovante GerarComprovante();

        public TransacaoBancaria(ContaCorrente contaCorrente)
        {
            Conta = contaCorrente;
        }

        public abstract void Executa();


    }
}
