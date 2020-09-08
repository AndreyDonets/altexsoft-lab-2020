using task2.Repositories;
using System;

namespace task2
{
  public class UnitOfWork 
    : IDisposable
  {
    private CatalogContext _context;

    private CategoryRepository _categoryRepository;
    private RecipeRepository _recipeRepository;
    private IngredientRepository _ingredientRepository;

    public UnitOfWork()
    {
      _context = new CatalogContext();
    }

    public CategoryRepository Categories
    {
      get
      {
        if (_categoryRepository == null)
          _categoryRepository = new CategoryRepository(_context);
        return _categoryRepository;
      }
    }

    public RecipeRepository Recipes
    {
      get
      {
        if (_recipeRepository == null)
          _recipeRepository = new RecipeRepository(_context);
        return _recipeRepository;
      }
    }

    public IngredientRepository Ingredients
    {
      get
      {
        if (_ingredientRepository == null)
          _ingredientRepository = new IngredientRepository(_context);
        return _ingredientRepository;
      }
    }

    public void Save()
    {
      _context.SaveChanges();
    }

    private bool disposed = false;

    public virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        if (disposing)
        {
          _context.Dispose();
        }
        disposed = true;
      }
    }

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }
  }
}
