using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo
{
    public class Banco
    {

        public int Numero { get; set; }
        public string Descricao { get; set; }

        List<Agencia> agencias = new List<Agencia>();
        public IList<Agencia> Agencias
        {
            get { return agencias; }
        }
    }

}
