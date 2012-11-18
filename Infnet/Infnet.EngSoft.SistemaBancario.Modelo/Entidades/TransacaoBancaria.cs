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
        public virtual ContaCorrente Conta { get; set; }
        public virtual Comprovante Comprovante { get; set; }


        public TransacaoBancaria(ContaCorrente contaCorrente)
        {
            Conta = contaCorrente;
        }

        public abstract void Executa();
    }
}
