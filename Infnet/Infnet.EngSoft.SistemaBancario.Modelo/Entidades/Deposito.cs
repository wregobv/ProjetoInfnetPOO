using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public class Deposito : TransacaoMonetaria
    {
        public virtual TransacaoMonetaria TransacaoMonetaria { get; set; }

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
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
