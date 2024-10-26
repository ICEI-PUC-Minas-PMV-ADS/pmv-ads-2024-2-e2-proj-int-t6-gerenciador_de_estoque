using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace StockUp.Models
{
    [Table("Fornecedores")]
    public class Fornecedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public required string Nome { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Criado em")]
        public DateTime CriadoEm { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}
