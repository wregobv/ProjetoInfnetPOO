using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public class Extrato : TransacaoBancaria
    {
        public TransacaoMonetaria TransacaoMonetaria { get; set; }

        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public Extrato(ContaCorrente conta)
            : base(conta)
        {

        }

        public override void Executa()
        {

        }

        public override Comprovante Comprovante
        {
            get
            {
                return Comprovante;
            }
            protected set
            {
                Comprovante = Comprovante;
            }
        }

        public override Comprovante GerarComprovante()
        {
            return new Comprovante("Extrato em: " + Data + " Referente a conta: " + Conta.Numero + " Período de: " + Conta.TransacaoMonetaria.Extrato.DataInicial + " até " + Conta.TransacaoMonetaria.Extrato.DataFinal );
        }

    }
}
