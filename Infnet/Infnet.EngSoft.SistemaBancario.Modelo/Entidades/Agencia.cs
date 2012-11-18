using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public class Agencia
    {
        public int Numero { get; set; }
        public string Descricao { get; set; }
        public virtual Banco Banco { get; set; }
        
        List<ContaCorrente> contas = new List<ContaCorrente>();
        public IList<ContaCorrente> Contas
        {
            get { return contas; }
        }


    }
}
