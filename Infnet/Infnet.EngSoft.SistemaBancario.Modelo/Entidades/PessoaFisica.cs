﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public class PessoaFisica : Cliente
    {

        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }

        public virtual Cliente cliente { get; set; }
        public virtual ContaCorrente Conta { get; set; }

    }
}
