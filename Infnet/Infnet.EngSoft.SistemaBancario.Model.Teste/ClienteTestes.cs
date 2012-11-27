using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Infnet.EngSoft.SistemaBancario.Modelo.Entidades;
using Infnet.EngSoft.SistemaBancario.Repositorio;
using Infnet.EngSoft.SistemaBancario.Servicos;

namespace Infnet.EngSoft.SistemaBancario.Model.Teste
{
    [TestFixture]
    public class ClienteTestes
    {

        [Test]
        public void TestarCriacaoCliente()
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

            RepositorioCliente.LimparRepositorio();

            RepositorioCliente.Adicionar(cliente);

            Cliente recuperado = RepositorioCliente.Listar().Cast<Cliente>().FirstOrDefault();

            RepositorioCliente.Listar()
                                        .Where(t => t.GetType().Name == typeof(Cliente).Name)
                                        .Cast<Cliente>()
                                        .ToList();

            Assert.AreEqual(cliente, recuperado);
        }

    }
}
