namespace DesafioPraticoCSharp;

public class Calculator
{
    private double number1;
    private double number2;

    public void AskNumber1()
    {
        Console.Write("Digite o primeiro valor: ");
        string? number = Console.ReadLine();
        if (double.TryParse(number, out number1))
            return;
        else
            AskNumber1();

    }
    public void AskNumber2()
    {
        Console.Write("Digite o segundo valor: ");
        string? number = Console.ReadLine();
        if (double.TryParse(number, out number2))
            return;
        else
            AskNumber2();
    }

    public void Add()
    {
        var result = number1 + number2;
        Console.WriteLine($"A soma entre {number1} e {number2} é igual a {result}");
    }

    public void Subtract()
    {
        var result = number1 - number2;
        Console.WriteLine($"A subtração entre {number1} e {number2} é igual a {result}");
    }

    public void Multiply()
    {
        var result = number1 * number2;
        Console.WriteLine($"A multiplicação entre {number1} e {number2} é igual a {result}");
    }

    public void Divide()
    {
        if (number2 == 0)
        {
            Console.WriteLine("Não é possível dividir por zero");
        }

        var result = number1 / number2;
        Console.WriteLine($"A divisão entre {number1} e {number2} é igual a {result}");
    }

    public void Average()
    {
        var result = (number1 + number2) / 2;
        Console.WriteLine($"A média de {number1} e {number2} é igual a {result}");
    }
}
