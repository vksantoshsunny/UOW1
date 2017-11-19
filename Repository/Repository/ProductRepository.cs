using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Repository.Repository
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{

		public ProductRepository(ApplicationContext context)
			: base(context)
		{

		}
		

		public List<Product> Search(string name)
		{
			throw new NotImplementedException();
		}
	}
}
