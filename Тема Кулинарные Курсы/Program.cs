using System;
using static HomeWork2.Classes.CookingClasses;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кулинарные классы");
            ItalianRecipe italianRecipe = new ItalianRecipe("Спагетти", 40, 2, "Итальянская", "пшеничная");
            JapanRecipe japanRecipe = new JapanRecipe("Онигири", 25, 3, new List<string> { "рис", "огурцы", "тунец", "листы нори" });

            italianRecipe.ShowInfo();
            italianRecipe.Prepare();

            italianRecipe.ChangePastaType("цельнозерновая"); // изменение типа
            Console.WriteLine($"Тип пасты изменен на: {italianRecipe.PastaType}");
            italianRecipe.Prepare();

            Console.WriteLine();

            japanRecipe.ShowInfo();
            japanRecipe.Prepare();
        }

    }
}