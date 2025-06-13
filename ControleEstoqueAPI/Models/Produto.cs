namespace ControleEstoqueAPI.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public required string Nome { get; set; }

        public string CodigoBarras {  get; set; }
        public string Descricao { get; set; }
        public decimal precoCusto {  get; set; }

        public decimal PrecoVendas { get; set; }

        public DateTime? DataCadastro { get; set; } = DateTime.UtcNow;



    }
}
