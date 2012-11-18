using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public class Transferencia : TransacaoMonetaria
    {
        public virtual TransacaoMonetaria TransacaoMonetaria { get; set; }

        public Transferencia(ContaCorrente conta)
            : base(conta)
        {

        }

        public override void Executa()
        {

        }

        private Comprovante GerarComprovante()
        {
            return new Comprovante("Saque em:" + Data + "Custo:" + Custo + "Valor de:" + Valor);
        }

        private Comprovante comprovante;
        public override Comprovante Comprovante
        {
            get
            {
                if (comprovante == null)
                    comprovante = GerarComprovante();
                return comprovante;
            }
            set
            {
                comprovante = value;
            }
        }
    }
}
