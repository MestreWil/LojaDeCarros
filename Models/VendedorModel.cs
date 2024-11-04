using System;
using System.ComponentModel.DataAnnotations;

public class Vendedor
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A data de admissão é obrigatória.")]
    [DataType(DataType.Date, ErrorMessage = "Data em formato inválido.")]
    public DateTime DataAdmissao { get; set; }

    [Required(ErrorMessage = "O salário é obrigatório.")]
    [Range(0, double.MaxValue, ErrorMessage = "O salário deve ser um valor positivo.")]
    [DataType(DataType.Currency, ErrorMessage = "Formato de moeda inválido.")]
    public decimal Salario { get; set; }
}
