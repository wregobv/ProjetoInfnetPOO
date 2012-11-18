using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public class ContaEspecial : ContaCorrente
    {

        public decimal LimiteCredito { get; set; }
        public virtual ContaCorrente Conta { get; set; }
        public virtual Agencia Agencia { get; set; }


        public override decimal Debita(decimal valor)
        {
            if (valor < 0)
                throw new ArgumentException("Valor a debitar não pode ser negativo!");

            if (Saldo - valor < -LimiteCredito)
                throw new InvalidOperationException("Saldo insuficiente!");

            return Saldo -= valor;
        }
    }
}
