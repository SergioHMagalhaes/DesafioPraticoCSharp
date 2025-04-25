using System.Xml.Linq;

namespace DesafioPraticoCSharp;

public class Utils
{
    public static void countCharacter()
    {
        Console.Write("Digite o seu nome: ");
        string? text = Console.ReadLine();
        if (text != null)
        {
            string textWithoutSpace = text.Replace(" ", "");
            Console.WriteLine($"Esse texto tem {text.Length} " +
                $"caracteres. Se não considerarmos os espaços, ele terá {textWithoutSpace.Length} caracteres.");
        }
        else
        {
            Console.WriteLine("Texto invalido");
        }
        
    }

}
