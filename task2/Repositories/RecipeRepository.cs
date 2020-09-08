using task2.Interfaces;
using task2.Model;
using System.Collections.Generic;
using System.Linq;

namespace task2.Repositories
{
	public class RecipeRepository
				: IRepository<Recipe>
	{
		private CatalogContext _context;

		public RecipeRepository(CatalogContext context)
		{
			_context = context;
		}

		public void Create(Recipe item)
		{
			_context.Recipes.Add(item);
		}

		public Recipe Get(int id)
		{
			return _context.Recipes.FirstOrDefault(item => item.Id == id);
		}

		public IEnumerable<Recipe> GetAll()
		{
			return _context.Recipes.OrderBy(c => c.Id).ToList();
		}
	}
}
