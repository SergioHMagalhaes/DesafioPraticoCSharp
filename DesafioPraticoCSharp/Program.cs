namespace DesafioPraticoCSharp;

class Program {
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine(@"  _____                   __ _                         _   _           ");
        Console.WriteLine(@" |  __ \                 / _(_)                       | | (_)          ");
        Console.WriteLine(@" | |  | | ___  ___  __ _| |_ _  ___    _ __  _ __ __ _| |_ _  ___ ___  ");
        Console.WriteLine(@" | |  | |/ _ \/ __|/ _` |  _| |/ _ \  | '_ \| '__/ _` | __| |/ __/ _ \ ");
        Console.WriteLine(@" | |__| |  __/\__ \ (_| | | | | (_) | | |_) | | | (_| | |_| | (_| (_) |");
        Console.WriteLine(@" |_____/ \___||___/\__,_|_| |_|\___/  | .__/|_|  \__,_|\__|_|\___\___/ ");
        Console.WriteLine(@"                                      | |                              ");
        Console.WriteLine(@"                                      |_|                              ");

        Console.ResetColor();

        Console.WriteLine("Escolha uma opção");
        Console.WriteLine("[1] - Dasafio 1" +
            "\n[2] - Dasafio 2" +
            "\n[3] - Dasafio 3" +
            "\n[4] - Dasafio 4" +
            "\n[5] - Dasafio 5" +
            "\n[6] - Dasafio 6" +
            "\nDigite qualquer outra tecla para sair.");
        string? option = Console.ReadLine();

        if (option != null)
        {
            if (option.Equals("1"))
            {
                Console.WriteLine("====== Bem Vindo ======");
                Person newPerson = new Person();
                newPerson.AskName();
                newPerson.PrintWelcome();;
            } else if (option.Equals("2"))
            {
                Console.WriteLine("====== Nome Completo ======");
                Person newPerson = new Person();
                newPerson.AskName();
                newPerson.AskLastName();
                newPerson.PrintFullName();
            } else if (option.Equals("3"))
            {
                Console.WriteLine("====== Calculadora ======");
                Calculator calculator = new Calculator();
                calculator.AskNumber1();
                calculator.AskNumber2();
                calculator.Add();
                calculator.Subtract();
                calculator.Multiply();
                calculator.Divide();
                calculator.Average();
            } else if (option.Equals("4"))
            {
                Console.WriteLine("====== Contantador de palavras ======");
                Utils.CountCharacter();
            } else if (option.Equals("5"))
            {
                Console.WriteLine("====== Validador de placa ======");
                Utils.ValidatePlate();
            } else if (option.Equals("6"))
            {
                Console.WriteLine("====== Data Atual ======");
                Utils.DateNow();
            }
        }
    }
}