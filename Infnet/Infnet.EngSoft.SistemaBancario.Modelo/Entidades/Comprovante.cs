using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo
{
    public class Comprovante
    {

        public string Descricao { get; private set; }

        public Comprovante(string descricao)
        {
            Descricao = descricao;
        }


    }
}
