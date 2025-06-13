namespace ControleEstoqueAPI.Models
{
    public class EstoqueVievModel
    {
        public int ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public int Entradas { get; set; } 
        public int Saidas { get; set; }
        public int SaldoAtual {  get; set; }
        public  DateTime UltimaAtualizacao { get; set; }
     
    }
}
