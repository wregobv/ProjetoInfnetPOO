using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Infnet.EngSoft.SistemaBancario.Modelo.Entidades;
using Infnet.EngSoft.SistemaBancario.Repositorio;

namespace Infnet.EngSoft.SistemaBancario.Model.Teste
{
    [TestFixture]
    public class DepositoTestes
    {
        [Test]
        public void testar_deposito()
        {
            var conta = new ContaCorrente();
            conta.Numero = 123;
            conta.Credita(1000);
            
            var deposito = new Deposito(conta, 500);
            deposito.Executa();

            var comprovante = deposito.Comprovante;

            RepositorioTransacaoBancaria.Adicionar(deposito);

            Assert.Contains(deposito, RepositorioTransacaoBancaria.Listar());

            var recuperado = RepositorioTransacaoBancaria.Listar().Cast<Deposito>().FirstOrDefault();

            List<Deposito> depositos = RepositorioTransacaoBancaria.Listar()
                .Where(t => t.GetType().Name == typeof(Deposito).Name)
                .Cast<Deposito>()
                .ToList();


            Assert.AreEqual(deposito, recuperado);

        }

    }
}