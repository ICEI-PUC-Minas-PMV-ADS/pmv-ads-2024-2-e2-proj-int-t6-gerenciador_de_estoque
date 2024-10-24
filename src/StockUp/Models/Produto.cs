using StockUp.Models.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockUp.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Usuário é obrigatório")]
        [Display(Name = "Usuario")]
        public Guid UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public required Usuario Usuario { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "Preço é obrigatório")]
        public float Preco { get; set; }

        [Required(ErrorMessage = "Quantidade é obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade não pode ser menor que 0")]
        [QuantidadeMinimaSuperiorEstoque(ErrorMessage = "A quantidade do produto deve ser maior ou igual ao estoque mínimo")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório")]
        public required string Descricao { get; set; }

        [Required(ErrorMessage = "Estoque mínimo é obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage = "O estoque mínimo não pode ser menor que 0")]
        public int EstoqueMinimo { get; set; }

        [Required(ErrorMessage = "Categoria é obrigatória")]
        public Categorias Categoria { get; set; }

        [Required(ErrorMessage = "Fornecedor é obrigatório")]
        [Display(Name = "Fornecedor")]
        public Guid FornecedorId { get; set; }

        [ForeignKey("FornecedorId")]
        public required Fornecedor Fornecedor { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Criado Em")]
        public DateTime CriadoEm { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Atualizado Em")]
        public DateTime AtualizadoEm { get; set; }

        public ICollection<Saida>? Saidas { get; set; }

        public ICollection<Entrada>? Entradas { get; set; }
    }

    public enum Categorias
    {
        Alimentos,
        Saude,
        Vestuario,
        Eletronicos,
        Eletrodomesticos,
        Livros,
        Esportes,
        Brinquedos,
        Moveis,
        Beleza,
        Escritorio,
        Automotivo,
        Joias,
        Calcados,
        Jardim,
        Animais,
        Bebe,
        InstrumentosMusicais,
        Ferramentas,
        Artesanato
    }

}
