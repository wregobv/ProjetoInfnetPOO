using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoft.SistemaBancario.Modelo.Entidades;

namespace Infnet.EngSoft.SistemaBancario.Repositorio
{
    public static class RepositorioSaque
    {
        private static List<Saque> saques = new List<Saque>();

        public static List<Saque> Listar()
        {
            return saques;
        }

        public static void Adicionar(Saque saque)
        {
            saques.Add(saque);
        }

    }
}
