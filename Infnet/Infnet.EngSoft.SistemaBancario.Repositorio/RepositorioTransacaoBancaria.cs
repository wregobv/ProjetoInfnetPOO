    using System.Collections.Generic;
using Infnet.EngSoft.SistemaBancario.Modelo.Entidades;

namespace Infnet.EngSoft.SistemaBancario.Repositorio
{

    public static class RepositorioTransacaoBancaria
    {
        private static List<TransacaoBancaria> transacoes = new List<TransacaoBancaria>();

        public static List<TransacaoBancaria> Listar()
        {
            return transacoes;
        }

        public static void Adicionar(TransacaoBancaria transacao)
        {
            transacoes.Add(transacao);
        }

        public static void LimparRepositorio()
        {
            transacoes.Clear();
        }
    }
}
