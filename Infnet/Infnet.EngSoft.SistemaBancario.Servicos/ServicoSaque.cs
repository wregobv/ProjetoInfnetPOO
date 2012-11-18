﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.EngSoft.SistemaBancario.Repositorio;
using Infnet.EngSoft.SistemaBancario.Modelo;
using Infnet.EngSoft.SistemaBancario.Modelo.Entidades;

namespace Infnet.EngSoft.SistemaBancario.Servico
{
    public class ServicoSaque
    {
        private ContaCorrente _conta;
        private decimal _valor;

        public ServicoSaque(ContaCorrente conta, decimal valor)
        {
            _conta = conta;
            _valor = valor;
        }

        public void Executar()
        {
            if (_conta.Status != "Bloqueado" && _conta.Saldo >= _valor)
            {
                TransacaoBancaria saque = new Saque(_conta, _valor);
                saque.Executa();
                RepositorioTransacaoBancaria.Adicionar(saque);
            }
        }
    }
}