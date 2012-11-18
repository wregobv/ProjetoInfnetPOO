using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public class OrdemJudicial
    {
        public string OrgaoEmissor { get; set; }
        public string JuizAssinante { get; set; }
        public string DataOrdem { get; set; }
        public string DataExecucao { get; set; }
        public enum Ordem { Bloquer, Desbloquear }
               

    }
}
