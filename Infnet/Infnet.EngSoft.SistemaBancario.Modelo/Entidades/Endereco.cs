using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades.Entidades
{
    public class Endereco
    {
        public string TipoLogradouro { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Comp { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Cep { get; set; }

        public virtual Cliente Cliente { get; set; }
    }

}
