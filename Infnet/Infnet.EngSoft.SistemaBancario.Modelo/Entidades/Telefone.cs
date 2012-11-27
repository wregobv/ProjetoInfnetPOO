using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public class Telefone 
    {
        public string Tipo { get; set; }
        public int DDD { get; set; }
        public int Numero { get; set; }

        public virtual Cliente Cliente { get; set; }

        public void CadastrarTelefone(Telefone _telefone)
        {
            try
            {
                Telefone ObjTelefone = new Telefone();
                ObjTelefone.Tipo = _telefone.Tipo;
                ObjTelefone.DDD = _telefone.DDD;
                ObjTelefone.Numero = _telefone.Numero;

                Cliente.Telefone.Add(ObjTelefone);

            }
            catch (Exception)
            {
                throw new Exception("Não foi possível associar um novo telefone ao cliente.");
            }

        }

    }
}
