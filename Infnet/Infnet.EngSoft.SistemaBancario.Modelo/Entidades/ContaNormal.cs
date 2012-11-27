namespace Infnet.EngSoft.SistemaBancario.Modelo.Entidades
{
    public class ContaNormal : ContaCorrente
    {

        public virtual ContaCorrente Conta { get; set; }

    }
}
