using System;

namespace task2
{
    class RecipeExplorer
    {
        public static void Overview(string path)
        {
            var reader = new Reader<Models.Recipe>();
            reader.Path(path);
            var recipe = reader.Read();
            while (true)
            {
                Console.Clear();
                Console.WriteLine(recipe.Name);
                Console.WriteLine($"\nОписание");
                Console.WriteLine(recipe.Description);
                Console.WriteLine($"\nИнгридиенты:");
                int i = 0;
                foreach (var item in recipe.Ingredients)
                {
                    i++;
                    Console.WriteLine(i + " " + item);
                }
                Console.WriteLine($"\nШаги приготовления:");
                foreach (var item in recipe.Cooking)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\nexit для выбора другого рецепта");
                string s = Console.ReadLine();
                if (s == "exit")
                {
                    break;
                }
            }
            Console.Clear();
        }
    }
}
