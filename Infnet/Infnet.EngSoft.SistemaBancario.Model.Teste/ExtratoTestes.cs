using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Infnet.EngSoft.SistemaBancario.Modelo;
using Infnet.EngSoft.SistemaBancario.Modelo.Entidades;
using Infnet.EngSoft.SistemaBancario.Repositorio;
using Infnet.EngSoft.SistemaBancario.Servicos;

namespace Infnet.EngSoft.SistemaBancario.Model.Teste
{
    [TestFixture]
    public class ExtratoTestes
    {
        [Test]
        public void testar_extrato()
        {
            var conta = new ContaCorrente();
            conta.Credita(1000);
            conta.Numero = 123;

            var extrato = new Extrato(conta);
            extrato.Executa();

            RepositorioTransacaoBancaria.LimparRepositorio();

            RepositorioTransacaoBancaria.Adicionar(extrato);

            Assert.Contains(extrato, RepositorioTransacaoBancaria.Listar());

            Extrato recuperado = RepositorioTransacaoBancaria.Listar().Cast<Extrato>().FirstOrDefault();

            List<Extrato> extratos = RepositorioTransacaoBancaria.Listar()
                .Where(t => t.GetType().Name == typeof(Extrato).Name)
                .Cast<Extrato>()
                .ToList();

            Assert.AreEqual(extrato, recuperado);

        }

    }
}