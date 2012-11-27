using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Infnet.EngSoft.SistemaBancario.Modelo.Entidades;
using Infnet.EngSoft.SistemaBancario.Repositorio;

namespace Infnet.EngSoft.SistemaBancario.Model.Teste
{
    [TestFixture]
    public class TransferenciaTestes
    {
        [Test]
        public void testar_deposito()
        {
            var contaorigem = new ContaCorrente();
            var contadestino = new ContaCorrente();

            contaorigem.Agencia = new Agencia();
            contaorigem.Agencia.Banco = new Banco();
            contaorigem.Credita(1000);
            contaorigem.Numero = 568465;
            contaorigem.Status = "Ativa";
            contaorigem.DataAbertura = System.DateTime.Now.Date;
            contaorigem.Agencia.Numero = 1;
            contaorigem.Agencia.Banco.Numero = 1;


            contadestino.Agencia = new Agencia();
            contadestino.Agencia.Banco = new Banco();
            contadestino.Credita(1000);
            contadestino.Numero = 999546;
            contadestino.Status = "Ativa";
            contadestino.DataAbertura = System.DateTime.Now.Date;
            contadestino.Agencia.Numero = 1;
            contadestino.Agencia.Banco.Numero = 1;
            
            TransacaoBancaria transferencia = new Transferencia(contaorigem, contadestino, 500);
            transferencia.Executa();

            Comprovante comprovante = transferencia.Comprovante;

            RepositorioTransacaoBancaria.LimparRepositorio();

            RepositorioTransacaoBancaria.Adicionar(transferencia);

            Assert.Contains(transferencia, RepositorioTransacaoBancaria.Listar());

            Transferencia recuperado = RepositorioTransacaoBancaria.Listar().Cast<Transferencia>().FirstOrDefault();

            List<Transferencia> transferencias = RepositorioTransacaoBancaria.Listar()
                .Where(t => t.GetType().Name == typeof(Transferencia).Name)
                .Cast<Transferencia>()
                .ToList();


            Assert.AreEqual(transferencia, recuperado);

        }

    }
}