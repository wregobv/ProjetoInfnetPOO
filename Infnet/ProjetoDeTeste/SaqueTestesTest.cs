using EngSoft.SistemaBancario.Model.Teste;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Infnet.EngSoft.SistemaBancario.ProjetoDeTeste
{
    
    
    /// <summary>
    ///This is a test class for SaqueTestesTest and is intended
    ///to contain all SaqueTestesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SaqueTestesTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for testar_saque_transacoesBancarias
        ///</summary>
        [TestMethod()]
        public void testar_saque_transacoesBancariasTest()
        {
            SaqueTestes target = new SaqueTestes(); // TODO: Initialize to an appropriate value
            target.testar_saque_transacoesBancarias();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SaqueTestes Constructor
        ///</summary>
        [TestMethod()]
        public void SaqueTestesConstructorTest()
        {
            SaqueTestes target = new SaqueTestes();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for testar_saque
        ///</summary>
        [TestMethod()]
        public void testar_saqueTest()
        {
            SaqueTestes target = new SaqueTestes(); // TODO: Initialize to an appropriate value
            target.testar_saque();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for testar_saque_transacoesBancarias1
        ///</summary>
        [TestMethod()]
        public void testar_saque_transacoesBancarias1Test()
        {
            SaqueTestes target = new SaqueTestes(); // TODO: Initialize to an appropriate value
            target.testar_saque_transacoesBancarias1();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
