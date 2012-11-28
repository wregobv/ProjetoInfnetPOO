using Infnet.EngSoft.SistemaBancario.Repositorio.Singleton;
using NUnit.Framework;

namespace Infnet.EngSoft.SistemaBancario.Model.Teste.Singleton
{
    [TestFixture]
    public class SingletonSimplesTeste
    {

        [Test]
        public void exemploSingleton_deve_retornar_a_mesma_instancia()
        {
            var instancia = SingletonSimples.Instancia;
            var novaInstancia = SingletonSimples.Instancia;

            Assert.AreSame(instancia, novaInstancia);
        }
    }
}