using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LojaDeCarros.Models;

public class Nota
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O número da nota é obrigatório.")]
    public int Numero { get; set; }

    [Required(ErrorMessage = "A data de emissão é obrigatória.")]
    [DataType(DataType.Date, ErrorMessage = "Data em formato inválido.")]
    public DateTime DataEmissao { get; set; }

    [Required(ErrorMessage = "O período de garantia é obrigatório.")]
    [Range(0, 60, ErrorMessage = "A garantia deve ser entre 0 e 60 meses.")]
    public int Garantia { get; set; }  // Garantia em meses

    [Required(ErrorMessage = "O valor de venda é obrigatório.")]
    [Range(0, double.MaxValue, ErrorMessage = "O valor de venda deve ser um valor positivo.")]
    [DataType(DataType.Currency, ErrorMessage = "Formato de moeda inválido.")]
    public decimal ValorVenda { get; set; }

    // Relacionamento com Cliente (Comprador)
    [Required(ErrorMessage = "O comprador é obrigatório.")]
    public int ClienteId { get; set; }
    [ForeignKey("ClienteId")]
    public Cliente Comprador { get; set; }

    // Relacionamento com Vendedor
    [Required(ErrorMessage = "O vendedor é obrigatório.")]
    public int VendedorId { get; set; }
    [ForeignKey("VendedorId")]
    public Vendedor Vendedor { get; set; }

    // Relacionamento com Carro
    [Required(ErrorMessage = "O carro é obrigatório.")]
    public int CarroId { get; set; }
    [ForeignKey("CarroId")]
    public Carro Carro { get; set; }
}
