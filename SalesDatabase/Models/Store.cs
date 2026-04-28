using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SalesDatabase.Models
{
	public class Store
	{
		[Key]
		public int StoreId { get; set; }

		[Required]
		[MaxLength(80)]
		public string Name { get; set; } = null!;

		public ICollection<Sale> Sales { get; set; } = new HashSet<Sale>();
	}
}
