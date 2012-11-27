using System.Collections.Generic;
using Infnet.EngSoft.SistemaBancario.Modelo.Entidades;


namespace Infnet.EngSoft.SistemaBancario.Repositorio
{
    public static class RepositorioCliente
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public static List<Cliente> Listar()
        {
            return clientes;
        }

        public static void Adicionar(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public static void LimparRepositorio()
        {
            clientes.Clear();
        }

    }
}
