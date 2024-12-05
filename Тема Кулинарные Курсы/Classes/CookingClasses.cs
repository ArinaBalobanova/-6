using System;

namespace HomeWork2.Classes
{
    class CookingClasses
    {
        public abstract class Recipe
        {
            public string Name {get; set;}
            public int CookingTime {get; set;}
            public int Servings {get; set;}
            public string Cuisine {get; set;}
            public Recipe(string name, int cookingTime, int servings, string cuisine)
            {
                Name = name;
                CookingTime = cookingTime;
                Servings = servings;
                Cuisine = cuisine;
            }
            public abstract void Prepare();

            public void ShowInfo()
            {
                Console.WriteLine($"Рецепт: {Name}, Время приготовления: {CookingTime} мин., Порции: {Servings}, Кухня: {Cuisine}");
            }
        }
        public class ItalianRecipe : Recipe
        {
            public string PastaType {get; set;}

            public ItalianRecipe(string name, int cookingTime, int servings, string cuisine, string pastaType)
                : base(name, cookingTime, servings, cuisine)
            {
                PastaType = pastaType;
            }

            public override void Prepare()
            {
                Console.WriteLine($"Готовим итальянское блюдо {Name} с {PastaType} пастой.");
            }
            public void ChangePastaType(string newType)
            {
                PastaType = newType;
            }
        }
        public class JapanRecipe : Recipe
        {
            public List<string> Ingredients { get; set; } = new List<string>();
            public JapanRecipe() : base("Без названия", 0, 0, "Вегетарианская") // Пустой конструктор
            {
            }
            public JapanRecipe(string name, int cookingTime, int servings, List<string> ingredients)
                : base(name, cookingTime, servings, "Японская")
            {
                Ingredients = ingredients;
            }

            public override void Prepare()
            {
                Console.WriteLine($"Готовим японское блюдо {Name} с ингредиентами: {string.Join(", ", Ingredients)}.");
            }
        }

    }
}
