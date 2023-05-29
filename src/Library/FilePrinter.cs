using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(ITextContent textContent)
        {
            File.WriteAllText("Recipe.txt", textContent.GetTextToPrint());
        }
    }
}