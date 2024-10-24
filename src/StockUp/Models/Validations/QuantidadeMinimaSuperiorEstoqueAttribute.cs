using System.ComponentModel.DataAnnotations;

namespace StockUp.Models.Validations
{
    public class QuantidadeMinimaSuperiorEstoqueAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var produto = validationContext.ObjectInstance as Produto;
            
            if (produto != null)
            {
                if (produto.Quantidade < produto.EstoqueMinimo)
                {
                    return new ValidationResult($"A quantidade ({produto.Quantidade}) não pode ser menor que o estoque mínimo ({produto.EstoqueMinimo})");
                }
            }

            return ValidationResult.Success;
        }
    }
}