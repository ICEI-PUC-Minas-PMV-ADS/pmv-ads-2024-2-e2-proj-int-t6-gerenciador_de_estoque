namespace StockUp.Models
{
    public class ListaEntradas
    {

        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
