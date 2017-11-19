using System.Data.Entity;


namespace Data
{
	public class ApplicationContext : DbContext
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductType> ProductTypes { get; set; }

		public ApplicationContext() : base("Name=ProductsEntities")
		{

		}
	}

}
