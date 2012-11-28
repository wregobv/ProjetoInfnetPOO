using System.Collections.Generic;
using Infnet.EngSoft.SistemaBancario.Modelo.Entidades;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public abstract class Cliente
    {
        public Cliente()
        {
            this.Telefone = new HashSet<Telefone>();
            this.Endereco = new HashSet<Endereco>();
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Perfil { get; set; }

        public ICollection<Endereco> Endereco { get; set; }
        public ICollection<Telefone> Telefone { get; set; }
        public ContaCorrente ContaCorrente { get; set; }
        public PerfilCliente PerfilCliente { get; set; }

    }
}
