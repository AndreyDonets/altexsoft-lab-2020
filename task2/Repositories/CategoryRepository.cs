using task2.Interfaces;
using task2.Model;
using System.Collections.Generic;
using System.Linq;

namespace task2.Repositories
{
	public class CategoryRepository
		: IRepository<Category>
	{
		private CatalogContext _context;

		public CategoryRepository(CatalogContext context)
		{
			_context = context;
		}

		public void Create(Category item)
		{
			_context.Categories.Add(item);
		}

		public Category Get(int id)
		{
			return _context.Categories.FirstOrDefault(item => item.Id == id);
		}

		public IEnumerable<Category> GetAll()
		{
			return _context.Categories.OrderBy(c => c.Id).ToList();
		}

		public IEnumerable<Category> GetAllFilled()
		{
			var categories = GetAll().ToList();

			categories
				.ForEach(category => category.Recipes
					.AddRange(_context.Recipes
						.Where(r => r.CategoryId == category.Id)));

			return categories.OrderBy(c => c.Id).ToList();
		}
	}
}
