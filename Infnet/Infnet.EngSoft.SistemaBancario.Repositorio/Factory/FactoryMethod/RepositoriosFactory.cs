using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Repositorio.Factory.FactoryMethod
{
    public abstract class RepositoriosFactory
    {
        public abstract Repositorio Criar();
    }
}
