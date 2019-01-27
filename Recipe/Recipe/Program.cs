using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    class Program
    {
        static void Main(string[] args)
        {
            var context2 = new RecipeContext();
            List<Recipe> Recipes = new List<Recipe>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Создать новый рецепт");
                Console.WriteLine("2. Получить список рецептов");
          
                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        using (var context = new RecipeContext())
                        {
                            Console.WriteLine("Введите имя первого ингридиента: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Введите количество ингридиента: ");
                            int amount;
                            Int32.TryParse(Console.ReadLine(), out amount);
                            Ingredient ingredient1 = new Ingredient
                            {
                                Name = name,
                                Amount = amount
                            };
                            Console.WriteLine("Введите второго первого ингридиента: ");
                            string name2 = Console.ReadLine();
                            Console.WriteLine("Введите количество ингридиента: ");
                            int amount2;
                            Int32.TryParse(Console.ReadLine(), out amount2);
                            Ingredient ingredient2 = new Ingredient
                            {
                                Name = name2,
                                Amount = amount2
                            };
                            Console.WriteLine("Введите имя третьего ингридиента: ");
                            string name3 = Console.ReadLine();
                            Console.WriteLine("Введите количество ингридиента: ");
                            int amount3;
                            Int32.TryParse(Console.ReadLine(), out amount3);
                            Ingredient ingredient3 = new Ingredient
                            {
                                Name = name3,
                                Amount = amount3
                            };

                            Console.WriteLine("Введите название рецепта");
                            string recipeName = Console.ReadLine();
                            Recipe recipe = new Recipe
                            {
                                Name = recipeName
                            };
                            recipe.Ingredients.Add(ingredient1);
                            recipe.Ingredients.Add(ingredient2);
                            recipe.Ingredients.Add(ingredient3);

                            context.Ingredients.Add(ingredient1);
                            context.Ingredients.Add(ingredient2);
                            context.Ingredients.Add(ingredient3);

                            context.Recipes.Add(recipe);

                            context.SaveChanges();
                        }

                        Console.ReadLine();
                        break;

                    case "2":
                        Recipes = context2.Recipes.ToList();
                        Console.Clear();
                        Console.WriteLine("Данные выгружены");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
