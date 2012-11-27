using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public class Extrato : TransacaoBancaria
    {
        public TransacaoMonetaria TransacaoMonetaria { get; set; }

        public static DateTime DataInicial { get; set; }
        public static DateTime DataFinal { get; set; }

        public Extrato(ContaCorrente conta)
            : base(conta)
        {

        }

        public override void Executa()
        {
            GerarComprovante();
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
            return new Comprovante("Extrato em: " + System.DateTime.Now + " Referente a conta: " + Conta.Numero + " Período de: " + Extrato.DataInicial + " até " + Extrato.DataFinal);
        }

    }
}
