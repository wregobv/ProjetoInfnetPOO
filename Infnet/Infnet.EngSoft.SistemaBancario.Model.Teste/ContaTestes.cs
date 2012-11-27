using System;
using System.Collections.Generic;
using System.Linq;
using Infnet.EngSoft.SistemaBancario.Servicos;
using NUnit.Framework;
using Infnet.EngSoft.SistemaBancario.Modelo.Entidades;
using Infnet.EngSoft.SistemaBancario.Repositorio;

namespace Infnet.EngSoft.SistemaBancario.Model.Teste
{
    [TestFixture]
    public class ContaTestes
    {
        #region Métodos de Teste
        [Test]
        public void TestarCriacaoConta()
        {
            var conta = PreparaAmbienteTeste();
            Assert.Contains(conta, Repositorio.RepositorioContaCorrente.Listar());
        }

        [Test]
        public void TestarLimiteContaEspecial()
        {
            var conta = PreparaAmbienteTeste();

            if (conta.Tipo == ContaCorrente.TipoConta.Especial.ToString())
            {
                Assert.True(conta.ContaE.LimiteCredito > 0);
            }
            else
            {
                Assert.True(!(conta.ContaE.LimiteCredito > 0));
            }

        }

        [Test]
        public void TestarFechamentoDeConta()
        {
            var conta = PreparaAmbienteTeste();

            if (conta.Saldo > 0)
            {
                Assert.Ignore("Conta não pode ser fechado. Há saldo residual. Zere a conta e refaça o cancelamento.");
            }
            else if (conta.Saldo < 0)
            {
                Assert.Ignore("Conta não pode ser fechada. Há débitos na conta.");
            }

            else
            {
                conta.Status = ContaCorrente.StatusConta.Encerrada.ToString();
            }

            Assert.AreEqual(conta.Status, ContaCorrente.StatusConta.Encerrada.ToString());

        }
        [Test]
        public void TestarEncerramentoDeConta()
        {
            var conta = PreparaAmbienteTeste();
            var servico = new ServicoContaCorrente();

            servico.EncerraConta(conta);

            Assert.IsTrue(conta.Status == ContaCorrente.StatusConta.Encerrada.ToString());

        }

        [Test]
        public void TestarBloqueioJudicial()
        {
            var conta = PreparaAmbienteTeste();
            var servico = new ServicoContaCorrente();

            servico.BloqueioJudicial(OrdemJudicial.TipoOrdem.Bloquear.ToString(), conta);

            Assert.IsTrue(conta.Status == ContaCorrente.StatusConta.BloqueadaJudicialmente.ToString());

        }

        [Test]
        public void TestarDesbloqueioJudicial()
        {
            var conta = PreparaAmbienteTeste();
            var servico = new ServicoContaCorrente();

            servico.DesbloqueioJudicial(OrdemJudicial.TipoOrdem.Desbloquear.ToString(), conta);

            Assert.IsTrue(conta.Status == ContaCorrente.StatusConta.Ativa.ToString());

        }

        #endregion

        #region Métodos de Apoio

        public Cliente CarregaCliente()
        {
            var cliente = new PessoaFisica
            {
                Nome = "William Rego",
                Email = "wregobv@gmail.com",
                PerfilCliente = new PerfilCliente(),
                Perfil = PerfilCliente.Perfil.Estrategico.ToString(),
                Cpf = "077.299.887-63",
                Rg = "11.363.443-0",
                DataNascimento = System.DateTime.Now,
                Sexo = "M"
            };

            return cliente;
        }

        public ContaCorrente GetContaPorTipoCliente(Cliente cliente)
        {
            ContaCorrente saida = null;

            if (cliente.Perfil == PerfilCliente.Perfil.Estrategico.ToString())
            {
                cliente.ContaCorrente = new ContaEspecial();
                cliente.ContaCorrente.Numero = 1;
                cliente.ContaCorrente.Status = ContaCorrente.StatusConta.Ativa.ToString();
                cliente.ContaCorrente.Numero = cliente.ContaCorrente.GeradorDeNumerosDeConta();
                cliente.ContaCorrente.Tipo = ContaCorrente.TipoConta.Especial.ToString();
                cliente.ContaCorrente.ContaE = new ContaEspecial();
                cliente.ContaCorrente.ContaE.LimiteCredito = 1000;
                cliente.ContaCorrente.Agencia = new Agencia();
                cliente.ContaCorrente.Agencia.Numero = 1;
                cliente.ContaCorrente.Agencia.Descricao = "AG. Senador Dantas";
                cliente.ContaCorrente.Agencia.Banco = new Banco();
                cliente.ContaCorrente.Agencia.Banco.Numero = 1;
                cliente.ContaCorrente.Agencia.Banco.Descricao = "Banco do Brasil";
                cliente.ContaCorrente.OrdemJudicial = new OrdemJudicial();
                cliente.ContaCorrente.OrdemJudicial.DataExecucao = "01/11/2012";
                cliente.ContaCorrente.OrdemJudicial.DataOrdem = "30/08/2012";
                cliente.ContaCorrente.OrdemJudicial.JuizAssinante = "Ubirajara";
                cliente.ContaCorrente.OrdemJudicial.OrgaoEmissor = "TSJ";
                cliente.ContaCorrente.OrdemJudicial.Ordem = null;

                saida = cliente.ContaCorrente;
            }
            else
            {
                if (cliente.Perfil == PerfilCliente.Perfil.Normal.ToString())
                {
                    cliente.ContaCorrente = new ContaEspecial();
                    cliente.ContaCorrente.Numero = 1;
                    cliente.ContaCorrente.Status = ContaCorrente.StatusConta.Ativa.ToString();
                    cliente.ContaCorrente.Numero = cliente.ContaCorrente.GeradorDeNumerosDeConta();
                    cliente.ContaCorrente.Tipo = ContaCorrente.TipoConta.Especial.ToString();
                    cliente.ContaCorrente.ContaN = new ContaNormal();
                    cliente.ContaCorrente.Agencia = new Agencia();
                    cliente.ContaCorrente.Agencia.Numero = 1;
                    cliente.ContaCorrente.Agencia.Descricao = "AG. Senador Dantas";
                    cliente.ContaCorrente.Agencia.Banco = new Banco();
                    cliente.ContaCorrente.Agencia.Banco.Numero = 1;
                    cliente.ContaCorrente.Agencia.Banco.Descricao = "Banco do Brasil";
                    cliente.ContaCorrente.OrdemJudicial = new OrdemJudicial();
                    cliente.ContaCorrente.OrdemJudicial.DataExecucao = "01/11/2012";
                    cliente.ContaCorrente.OrdemJudicial.DataOrdem = "30/08/2012";
                    cliente.ContaCorrente.OrdemJudicial.JuizAssinante = "Ubirajara";
                    cliente.ContaCorrente.OrdemJudicial.OrgaoEmissor = "TSJ";
                    cliente.ContaCorrente.OrdemJudicial.Ordem = null;

                    saida = cliente.ContaCorrente;

                }

            }

            return saida;

        }

        public ContaCorrente PreparaAmbienteTeste()
        {
            ContaCorrente conta = null;

            var firstOrDefault = RepositorioContaCorrente.Listar().FirstOrDefault();
            if (firstOrDefault != null)
            {
                conta = firstOrDefault;
            }
            else
            {
                conta = (ContaCorrente)GetContaPorTipoCliente(CarregaCliente());
                Repositorio.RepositorioContaCorrente.Adicionar(conta);
            }

            return conta;
        }
        #endregion


    }
}

