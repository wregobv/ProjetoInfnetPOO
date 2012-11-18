using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public class Comprovante
    {

        public string Descricao { get; set; }

        public Comprovante(string descricao)
        {
            Descricao = descricao;
        }


    }
}
