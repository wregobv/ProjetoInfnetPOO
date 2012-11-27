using System.Collections.Generic;
using Infnet.EngSoft.SistemaBancario.Modelo.Entidades;


namespace Infnet.EngSoft.SistemaBancario.Repositorio
{
    public static class RepositorioContaCorrente
    {
        private static List<ContaCorrente> contas = new List<ContaCorrente>();

        public static List<ContaCorrente> Listar()
        {
            return contas;
        }

        public static void Adicionar(ContaCorrente conta)
        {
            contas.Add(conta);
        }

        public static void LimparRepositorio()
        {
            contas.Clear();
        }

    }
}

