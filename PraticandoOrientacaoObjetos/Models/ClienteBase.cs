namespace PraticandoOrientacaoObjetos.Models
{
    public class ClienteBase : Cliente
    {
        public override decimal CalcularDesconto()
        {
            return 10;
        }
    }
}