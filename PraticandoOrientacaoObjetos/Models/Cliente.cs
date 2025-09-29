namespace PraticandoOrientacaoObjetos.Models
{
    public class Cliente
    {
        public string Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email {  get; set; } = string.Empty;

        public virtual decimal CalcularDesconto()
        {
            return 0;
        }
    }
}
