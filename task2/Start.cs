using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using task2.Model;
using task2.Repositories;

namespace task2
{
    public class Start
    {
        private readonly UnitOfWork _unitOfWork;
        public Start(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        private List<Category> _categories { get; set; }
        private List<Recipe> _recipes { get; set; }
        private List<Ingredient> _ingredients { get; set; }
        private static bool _exit { get; set; }
        private static bool _back { get; set; }
        public static void Back(bool answer)
        {
            _back = answer;
        }
        public static void Exit(bool answer)
        {
            _exit = answer;
        }
        public void GetAll(UnitOfWork unitOfWork)
        {
            _categories = unitOfWork.Categories.GetAll().ToList();
            _recipes = unitOfWork.Recipes.GetAll().ToList();
            _ingredients = unitOfWork.Ingredients.GetAll().ToList();
        }

        public void Go()
        {
            GetAll(_unitOfWork);
            int categoryId = -1;
            while (!_exit)
            {
                int ingredientsCount = _ingredients.Count;
                if (categoryId == -1)
                {
                    categoryId = CatalogExplorer.Choose(_categories);
                    if (categoryId == -1)
                        continue;
                }
                Recipe newRecipe = RecipeSelector.Chose(_recipes.Where(c => c.CategoryId == categoryId).ToList(), _ingredients);
                if (_back)
                    categoryId = -1;
                if (newRecipe != null)
                {
                    newRecipe = RecipeMaker.Create(_recipes);
                    if (newRecipe != null)
                    {
                        newRecipe.CategoryId = categoryId;
                        newRecipe.Id = _recipes.Count;
                        newRecipe.Ingredients = IngredientSelector.Choose(_ingredients);
                        for (int i = ingredientsCount -1; i < _ingredients.Count; i++)
                        {
                            _unitOfWork.Ingredients.Create(_ingredients[i]);
                        }
                        _unitOfWork.Recipes.Create(newRecipe);
                        _recipes.Add(newRecipe);
                        _unitOfWork.Save();
                        categoryId =-1;
                    }
                }
            }
        }
    }
}

