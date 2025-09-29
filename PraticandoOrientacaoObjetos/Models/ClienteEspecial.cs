namespace PraticandoOrientacaoObjetos.Models
{
    public class ClienteEspecial : Cliente 
    {
        public override decimal CalcularDesconto()
        {
            return 25;
        }
    }
}
