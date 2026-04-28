using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SalesDatabase.Models
{
	public class Sale
	{
		[Key]
		public int SaleId { get; set; }

		[Required]
		public DateTime Date { get; set; }

		public int ProductId { get; set; }

		[ForeignKey(nameof(ProductId))]
		public Product Product { get; set; } = null!;

		public int CustomerId { get; set; }

		[ForeignKey(nameof(CustomerId))]
		public Customer Customer { get; set; } = null!;

		public int StoreId { get; set; }

		[ForeignKey(nameof(StoreId))]
		public Store Store { get; set; } = null!;
	}
}
