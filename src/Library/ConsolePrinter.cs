using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    // Clase que sigue el principio SRP
    public class ConsolePrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}