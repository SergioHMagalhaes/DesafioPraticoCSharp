using System.Globalization;

namespace DesafioPraticoCSharp;

public class Utils
{
    public static void CountCharacter()
    {
        Console.Write("Digite o texto: ");
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

    public static void ValidatePlate()
    {
        Console.Write("Digite a placa: ");
        string? plate = Console.ReadLine();

        if (plate != null)
        {
            string plateWithoutSpace = plate.Replace(" ", "");
            int plateLength = plateWithoutSpace.Length;
            bool firstThreeCharactersAreString = 
                Char.IsLetter(plateWithoutSpace[0]) &&
                Char.IsLetter(plateWithoutSpace[1]) &&
                Char.IsLetter(plateWithoutSpace[2]);
            bool lastFourCharactersAreNumbers =
                Char.IsNumber(plateWithoutSpace[plateLength - 1]) &&
                Char.IsNumber(plateWithoutSpace[plateLength - 2]) &&
                Char.IsNumber(plateWithoutSpace[plateLength - 3]) &&
                Char.IsNumber(plateWithoutSpace[plateLength - 4]);

            if (plateWithoutSpace.Length == 7 && firstThreeCharactersAreString && lastFourCharactersAreNumbers)
            {
                Console.WriteLine($"Placa valida :).");
            } else
            {
                Console.WriteLine($"Placa invalida.");
            }
        } else
        {
            Console.WriteLine("Placa não informada");
        }
    }

    public static void DateNow() 
    {
        DateTime now = DateTime.Now;
        Console.WriteLine(now);
        Console.WriteLine(now.ToString("d/MM/yyyy"));
        Console.WriteLine(now.Hour);
        Console.WriteLine(now.ToString("d 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
    }


}
