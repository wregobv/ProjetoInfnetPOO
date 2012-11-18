using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoft.SistemaBancario.Repositorio;
using Infnet.EngSoft.SistemaBancario.Modelo;
using Infnet.EngSoft.SistemaBancario.Modelo.Entidades;

namespace Infnet.EngSoft.SistemaBancario.Servico
{
    public class ServicoContaCorrente
    {

        public string CriarConta(ContaCorrente ContaOrigem)
        {
            string NumeroContaGerado = "";

            //To do
            return NumeroContaGerado;
        }

        public void BloqueioJudicial(OrdemJudicial Ordem, ContaCorrente ContaOrigem)
        {
            //To do
        }

        public void DesbloqueioJudicial(OrdemJudicial Ordem, string ContaOrigem)
        {
            //To do 
        }


        public void Deposito(ContaCorrente ContaDestino, double Valor)
        {
            //To do 
        }

        public void Saque(ContaCorrente ContaOrigem, double Valor)
        {
            //To do 
        }

        public void Transferencia(ContaCorrente ContaOrigem, ContaCorrente ContaDestino, double Valor)
        {
            //To do 
        }

        public void EncerraConta(ContaCorrente ContaOrigem, Cliente Cliente)
        {
            //To do 
        }
    }
}
