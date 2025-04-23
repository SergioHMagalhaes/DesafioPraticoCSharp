namespace DesafioPraticoCSharp;

public class Person
{
    private string? name;
    private string? lastName;

    public void askName ()
    {
        Console.WriteLine("============================");
        Console.Write("Digite o seu nome: ");
        name = Console.ReadLine();
    }

    public void askLastName()
    {
        Console.Write("Digite o seu sobrenome: ");
        lastName = Console.ReadLine();
    }

    public void printWelcome()
    {
        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
    }

    public void printFullName()
    {
        Console.WriteLine($"Seu nome completo é {name} {lastName}");
        Console.WriteLine("============================");
    }
}
