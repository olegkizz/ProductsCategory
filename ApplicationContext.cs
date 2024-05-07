using System;
using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
{
	public ApplicationContext()
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}
