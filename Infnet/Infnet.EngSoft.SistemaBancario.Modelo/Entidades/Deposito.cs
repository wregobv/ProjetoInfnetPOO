﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo
{
    public class Deposito : TransacaoMonetaria
    {
        public Deposito(ContaCorrente conta)
            : base(conta)
        {

        }
        public override void Executa()
        {
            throw new NotImplementedException();
        }

        public override Comprovante Comprovante
        {
            get
            {
                throw new NotImplementedException();
            }
            protected set
            {
                throw new NotImplementedException();
            }
        }
    }
}
