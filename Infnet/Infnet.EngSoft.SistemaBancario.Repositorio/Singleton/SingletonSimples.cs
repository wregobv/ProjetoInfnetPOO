namespace Infnet.EngSoft.SistemaBancario.Repositorio.Singleton
{
    public sealed class SingletonSimples
    {
        private static SingletonSimples _instancia = null;

        SingletonSimples()
        {
        }

        public static SingletonSimples Instancia
        {
            get { return _instancia ?? (_instancia = new SingletonSimples()); }
        }
    }
}