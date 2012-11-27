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


        public void CadastrarEndereco(Endereco _endereco)
        {
            try
            {
                Endereco ObjEndereco = new Endereco();
                ObjEndereco.TipoLogradouro = _endereco.TipoLogradouro;
                ObjEndereco.Logradouro = _endereco.Logradouro;
                ObjEndereco.Numero = _endereco.Numero;
                ObjEndereco.Comp = _endereco.Comp;
                ObjEndereco.Bairro = _endereco.Bairro;
                ObjEndereco.Cidade = _endereco.Cidade;
                ObjEndereco.UF = _endereco.UF;
                ObjEndereco.Cep = _endereco.Cep;

                Cliente.Endereco.Add(ObjEndereco);
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível associar um novo endereço ao cliente.");
            }

        }

    }

}
