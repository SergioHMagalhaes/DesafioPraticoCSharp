namespace DesafioPraticoCSharp;

public class Person
{
    private string? name;
    private string? lastName;

    public void AskName ()
    {
        Console.Write("Digite o seu nome: ");
        name = Console.ReadLine();
    }

    public void AskLastName()
    {
        Console.Write("Digite o seu sobrenome: ");
        lastName = Console.ReadLine();
    }

    public void PrintWelcome()
    {
        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
    }

    public void PrintFullName()
    {
        Console.WriteLine($"Seu nome completo é {name} {lastName}");
    }
}
