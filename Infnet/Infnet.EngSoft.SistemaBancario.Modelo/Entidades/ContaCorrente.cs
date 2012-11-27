using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public class ContaCorrente
    {
        public int Numero { get; set; }
        public string Status { get; set; }
        public DateTime DataAbertura { get; set; }
        public decimal Saldo { get; protected set; }
        public string Tipo { get; set; }
        public enum TipoConta { Especial, Normal }
        public enum StatusConta { Ativa, Encerrada, BloqueadaJudicialmente }
        public virtual Agencia Agencia { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ContaEspecial ContaE { get; set; }
        public virtual ContaNormal ContaN { get; set; }
        public virtual OrdemJudicial OrdemJudicial { get; set; }
        public TransacaoMonetaria TransacaoMonetaria { get; set; }


        List<TransacaoBancaria> transacoesBancarias = new List<TransacaoBancaria>();
        public IList<TransacaoBancaria> TransacoesBancarias
        {
            get { return transacoesBancarias; }
        }

        public virtual decimal Debita(decimal valor)
        {
            return Saldo -= valor;
        }

        public virtual decimal Credita(decimal valor)
        {

            return Saldo += valor;
        }

        public virtual decimal Tranfere(ContaCorrente ContaOrigem, ContaCorrente ContaDestino, decimal valor)
        {
            ContaOrigem.Saldo -= valor;
            ContaDestino.Saldo += valor;
            return ContaOrigem.Saldo -= valor;

        }

        public int GeradorDeNumerosDeConta()
        {
            var random = new Random();
            return random.Next(1000, 999999);

        }


    }
}
