using task2.Interfaces;
using task2.Model;
using System.Collections.Generic;
using System.Linq;

namespace task2.Repositories
{
	public class IngredientRepository
		: IRepository<Ingredient>

	{
		private CatalogContext _context;

		public IngredientRepository(CatalogContext context)
		{
			_context = context;
		}
			public void Create(Ingredient item)
			{
				_context.Ingredients.Add(item);
			}

			public Ingredient Get(int id)
			{
				return _context.Ingredients.FirstOrDefault(item => item.Id == id);
			}

			public IEnumerable<Ingredient> GetAll()
			{
				return _context.Ingredients.OrderBy(c => c.Id).ToList();
			}
		}
}
