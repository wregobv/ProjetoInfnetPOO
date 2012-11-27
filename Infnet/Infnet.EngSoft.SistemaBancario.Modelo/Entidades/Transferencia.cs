using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public class Transferencia : TransacaoMonetaria
    {
        public TransacaoMonetaria TransacaoMonetaria { get; set; }
        private ContaCorrente ContaOrigem;
        private ContaCorrente ContaDestino;
        private decimal valor;

        public Transferencia(ContaCorrente _ContaOrigem, ContaCorrente _ContaDestino, decimal _valor)
            : base(_ContaOrigem)
        {
            ContaOrigem = _ContaOrigem;
            ContaDestino = _ContaDestino;
            valor = _valor;
        }
        
        public override void Executa()
        {
            Conta.Tranfere(ContaOrigem, ContaDestino, valor);
        }

        public override Comprovante GerarComprovante()
        {
            return new Comprovante("Transferência no valor de: " + Valor + " entre as contas " + ContaOrigem + " e " + ContaDestino + " foi realizada com sucesso em " + System.DateTime.Now.ToString());
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
