using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoft.SistemaBancario.Repositorio.Factory.FactoryMethod;

namespace Infnet.EngSoft.SistemaBancario.Repositorio.Factory.FactoryMethod
{
    public class ProdutoRepositorioFactory : RepositoriosFactory
    {
        public override Repositorio Criar()
        {
            return new ProdutoRepositorioSqlProvider();
        }

    }
}