﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo
{
    public abstract class TransacaoBancaria
    {
        public ContaCorrente Conta { get; private set; }

        public TransacaoBancaria(ContaCorrente contaCorrente)
        {
            Conta = contaCorrente;
        }

        public DateTime Data { get; set; }
        public decimal Custo { get; set; }

        public abstract Comprovante Comprovante { get; protected set; }

        public abstract void Executa();
    }
}
