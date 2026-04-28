using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesDatabase.Models
{
	public class Product
	{
		[Key]
		public int ProductId { get; set; }

		[Required]
		[MaxLength(50)]
		public string Name { get; set; } = null!;

		[Required]
		public float Quantity { get; set; }   

		[Required]
		public decimal Price { get; set; }

		[MaxLength(250)]
		public string? Description { get; set; }   

		public ICollection<Sale> Sales { get; set; } = new HashSet<Sale>();
	}
}
