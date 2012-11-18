using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public class Deposito : TransacaoMonetaria
    {
        public TransacaoMonetaria TransacaoMonetaria { get; set; }

        public Deposito(ContaCorrente conta, decimal valor) : base(conta)
        {
            this.Valor = valor;
        }

        public override void Executa()
        {
            Conta.Credita(Valor);
        }

        public override Comprovante GerarComprovante()
        {
            return new Comprovante("Depósito em: " + Data + " Creditado na conta: " + Conta.Numero + " Valor de: " + Valor);
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
