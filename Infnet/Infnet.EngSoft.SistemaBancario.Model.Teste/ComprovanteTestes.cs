using System;
using NUnit.Framework;
using Infnet.EngSoft.SistemaBancario.Modelo.Entidades;

namespace Infnet.EngSoft.SistemaBancario.Model.Teste
{
    [TestFixture]
    public class ComprovanteTestes
    {
        [Test]
        public void testar_comprovante()
        {
            var comprovante = new Comprovante("Teste de geração de comprovante.");
            Assert.IsFalse(String.IsNullOrEmpty(comprovante.Descricao));
        }

    }
}