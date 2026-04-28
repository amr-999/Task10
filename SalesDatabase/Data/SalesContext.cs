using Microsoft.EntityFrameworkCore;
using SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesDatabase.Data
{
	public class SalesContext : DbContext
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Store> Stores { get; set; }
		public DbSet<Sale> Sales { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Data Source=. ; Initial Catalog = SalesDatabase ;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True");
		}
	}
}
