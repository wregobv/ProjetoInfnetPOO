using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public class ContaNormal : ContaCorrente
    {

        public virtual ContaCorrente Conta { get; set; }

    }
}
