using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoft.SistemaBancario.Modelo;
using Infnet.EngSoft.SistemaBancario.Modelo.Entidades;

namespace Infnet.EngSoft.SistemaBancario.Repositorio
{
    //class RepositorioTransacaoBancaria
    //{
    //}

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
    }
}
