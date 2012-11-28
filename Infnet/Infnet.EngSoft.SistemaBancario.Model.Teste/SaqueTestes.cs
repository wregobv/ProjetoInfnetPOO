using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Infnet.EngSoft.SistemaBancario.Modelo.Entidades;
using Infnet.EngSoft.SistemaBancario.Repositorio;

namespace Infnet.EngSoft.SistemaBancario.Model.Teste
{
    [TestFixture]
    public class SaqueTestes
    {
        [Test]
        public void testar_saque()
        {
            var conta = new ContaCorrente();
            conta.Credita(1000);
            conta.Numero = 123;

            TransacaoBancaria saque = new Saque(conta, 500);
            saque.Executa();

            Comprovante comprovante = saque.Comprovante;

            RepositorioTransacaoBancaria.LimparRepositorio();

            RepositorioTransacaoBancaria.Adicionar(saque);

            Assert.Contains(saque, RepositorioTransacaoBancaria.Listar());

            Saque recuperado = RepositorioTransacaoBancaria.Listar().Cast<Saque>().FirstOrDefault();

            List<Saque> saques = RepositorioTransacaoBancaria.Listar()
                .Where(t => t.GetType().Name == typeof(Saque).Name)
                .Cast<Saque>()
                .ToList();


            Assert.AreEqual(saque, recuperado);

        }

    }
}