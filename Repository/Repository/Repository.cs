using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;




namespace Repository.Repository
{
	public class Repository<TEntity>: IRepository<TEntity> where TEntity : class
	{
		protected ApplicationContext Context;

		public Repository(ApplicationContext context)
		{
			Context = context;
		}

		public TEntity Add(TEntity entity)
		{
			Context.Set<TEntity>().Add(entity);
			Context.SaveChanges();
			return entity;
		}

		public TEntity Get(int id)
		{
			return Context.Set<TEntity>().Find(id);
		}

		public ICollection<TEntity> GetAll()
		{
			return Context.Set<TEntity>().ToList();
		}

		public void Remove(int id)
		{
			var entity =  Context.Set<TEntity>().Find(id);
			Context.Set<TEntity>().Remove(entity);
			Context.SaveChanges();
		}
	}
}
