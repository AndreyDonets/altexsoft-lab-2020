using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using task2.Model;
using task2.Repositories;

namespace task2
{
    class Start
    {
        private static List<Category> _categories { get; set; }
        private static List<Recipe> _recipes { get; set; }
        private static List<Ingredient> _ingredients { get; set; }
        private static List<Ingredient> _ingredient = new List<Ingredient>();
        private static bool _exit { get; set; }
        private static bool _back { get; set; }
        public static void GetAll(UnitOfWork unitOfWork)
        {
            _categories = unitOfWork.Categories.GetAll().ToList();
            _recipes = unitOfWork.Recipes.GetAll().ToList();
            _ingredients = unitOfWork.Ingredients.GetAll().ToList();
        }
        public static void Back(bool answer)
        {
            _back = answer;
        }
        public static void Exit(bool answer)
        {
            _exit = answer;
        }
        public static void AddIngredient(Ingredient item)
        {
            _ingredient.Add(item);
        }


        public static void Go()
        {
            var unitOfWork = new UnitOfWork();
            GetAll(unitOfWork);
            int categoryId = -1;
            while (!_exit)
            {
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
                        int ingredientId = _ingredients.Count();
                        foreach (var item in _ingredient)
                        {
                            item.Id = ingredientId;
                            unitOfWork.Ingredients.Create(item);
                            ingredientId++;
                        }
                        unitOfWork.Recipes.Create(newRecipe);
                        _recipes.Add(newRecipe);
                        unitOfWork.Save();
                        categoryId =-1;
                    }
                }
            }
        }
    }
}

