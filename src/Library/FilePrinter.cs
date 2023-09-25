using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    // Clase que sigue el principio de responsabilidad SRP
    public class FilePrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}

