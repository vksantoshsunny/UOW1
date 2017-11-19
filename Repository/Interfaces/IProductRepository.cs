﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Repository.Interfaces
{
	public interface IProductRepository : IRepository<Product>
	{
		List<Product> Search(string name);
	}
}
