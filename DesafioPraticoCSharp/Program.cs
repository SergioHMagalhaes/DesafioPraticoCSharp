namespace DesafioPraticoCSharp;

class Program {
    static void Main()
    {
        Person newPerson = new Person();
        newPerson.AskName();
        newPerson.PrintWelcome();
        newPerson.AskLastName();
        newPerson.PrintFullName();

        Console.WriteLine("\n3. Calculadora");

        Calculator calculator = new Calculator();
        calculator.AskNumber1();
        calculator.AskNumber2();
        calculator.Add();
        calculator.Subtract();
        calculator.Multiply();
        calculator.Divide();
        calculator.Average();

        Console.WriteLine("============================");

    }
}