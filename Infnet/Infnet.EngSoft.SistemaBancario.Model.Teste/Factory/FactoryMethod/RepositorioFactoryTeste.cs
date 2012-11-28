

using Infnet.EngSoft.SistemaBancario.Repositorio.Factory.FactoryMethod;
using NUnit.Framework;

namespace Infnet.EngSoft.SistemaBancario.Model.Teste.Factory.FactoryMethod
{
    [TestFixture]
    public class RepositorioFactoryTeste
    {
        [Test]
        public void repositorio_deve_ser_do_tipo_ProdutoSqlProvider()
        {
            RepositoriosFactory repositorioFactory = new ProdutoRepositorioFactory();
            var repositorio = repositorioFactory.Criar();

            repositorio.Adicionar();

            Assert.AreEqual(typeof(ProdutoRepositorioSqlProvider).Name, repositorio.GetType().Name);
        }
    }
}