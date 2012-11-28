using System;
using Infnet.EngSoft.SistemaBancario.Modelo.Entidades;

namespace Infnet.EngSoft.SistemaBancario.Servicos
{
    public class ServicoContaCorrente
    {

        public void BloqueioJudicial(string _tipo, ContaCorrente contaOrigem)
        {
            if (_tipo == OrdemJudicial.TipoOrdem.Bloquear.ToString())
                contaOrigem.Status = ContaCorrente.StatusConta.BloqueadaJudicialmente.ToString();
        }

        public void DesbloqueioJudicial(string _tipo, ContaCorrente contaOrigem)
        {
            if (_tipo == OrdemJudicial.TipoOrdem.Desbloquear.ToString())
            {
                contaOrigem.Status = ContaCorrente.StatusConta.Ativa.ToString();
            }

        }

        public void EncerraConta(ContaCorrente contaOrigem)
        {

            ValidaSaldo(contaOrigem, 0, "Encerramento");
            contaOrigem.Status = ContaCorrente.StatusConta.Encerrada.ToString();

        }

        public void Deposito(ContaCorrente contaDestino, decimal valor)
        {
            if (contaDestino.Status.Equals(ContaCorrente.StatusConta.Ativa.ToString()))
            {
                TransacaoBancaria transacao = new Deposito(contaDestino, valor);

                ValidaSaldo(contaDestino, valor, "Deposito");

                transacao.Executa();
            }
            else
            {
                throw new Exception("Conta não está ativa");
            }
        }

        public void Saque(ContaCorrente contaOrigem, decimal valor)
        {
            if (contaOrigem.Status.Equals(ContaCorrente.StatusConta.Ativa.ToString()))
            {
                TransacaoBancaria transacao = new Saque(contaOrigem, valor);

                ValidaSaldo(contaOrigem, valor, "Saque");

                transacao.Executa();
            }
            else
            {
                throw new Exception("Conta não está ativa");
            }
        }

        public void Transferencia(ContaCorrente contaOrigem, ContaCorrente contaDestino, decimal valor)
        {
            if (contaOrigem.Status.Equals(ContaCorrente.StatusConta.Ativa.ToString()) &&
                contaDestino.Status.Equals(ContaCorrente.StatusConta.Ativa.ToString()))
            {
                TransacaoBancaria transacao = new Transferencia(contaOrigem, contaDestino, valor);

                ValidaSaldo(contaOrigem, valor, "Transferencia");

                transacao.Executa();
            }
            else
            {
                throw new Exception("Conta não está ativa");
            }
        }

        #region Métodos de Apoio
        public void ValidaSaldo(ContaCorrente contaorigem, decimal valor, string operacao)
        {
            switch (operacao)
            {
                case "Saque":
                    if (valor < 0)
                        throw new ArgumentException("Valor a debitar não pode ser negativo!");

                    if (contaorigem.Saldo - valor < 0)
                        throw new InvalidOperationException("Saldo insuficiente!");
                    break;

                case "Transferencia":
                    if (valor < 0)
                        throw new ArgumentException("Valor a tranferir não pode ser negativo!");
                    if (contaorigem.Saldo - valor < 0)
                        throw new InvalidOperationException("Saldo da conta de origem número: " + contaorigem.Numero
                                                             + " do Cliente " + contaorigem.Cliente.Nome + " é insuficiente.");
                    break;

                case "Deposito":
                    if (valor < 0)
                        throw new ArgumentException("Valor a creditar não pode ser negativo!");
                    break;

                case "Encerramento":
                    if(contaorigem.Saldo > 0)
                        throw new InvalidOperationException("Saldo da conta de origem número: " + contaorigem.Numero
                                                             + " do Cliente " + contaorigem.Cliente.Nome + " é maior que zero. Retire todo o saldo da conta e repita operação.");
                    break;

                default:
                    throw new Exception("Opcao invalida");



            }
        }
        #endregion

    }
}
