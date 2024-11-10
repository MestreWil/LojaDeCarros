using System;
using System.ComponentModel.DataAnnotations;

namespace LojaDeCarros.Models

{
	public class Carro
	{
		public int Id { get; set; }
        public string Marca { get; set; }
		public string Modelo { get; set; }
		
		[Range(1900, 2100, ErrorMessage = "O ano deve estar entre 1900 e 2100.")]
		[Display(Name = "Ano de Fabricação")]
		public int AnoFabricacao { get; set; }

		[Range(1900, 2100, ErrorMessage = "O ano deve estar entre 1900 e 2100.")]
		[Display(Name = "Ano do Modelo")]
		public int AnoModelo { get; set; }
		public string Chassi {  get; set; }
		public double Preco { get; set; }

        public List<Nota> Notas { get; set; } = new List<Nota>();

    }
}
