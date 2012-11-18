using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public class Saque : TransacaoMonetaria
    {
        public TransacaoMonetaria TransacaoMonetaria { get; set; }

        public Saque(ContaCorrente conta, decimal valor) : base(conta)
        {
            this.Valor = valor;
        }

        public override void Executa()
        {
            Conta.Debita(Valor);
        }

        public override Comprovante GerarComprovante()
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
            protected set
            {
                comprovante = value;
            }

        }

    }
}
