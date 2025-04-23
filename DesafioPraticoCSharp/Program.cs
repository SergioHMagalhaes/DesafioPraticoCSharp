namespace DesafioPraticoCSharp;

class Program {
    static void Main()
    {
        Person newPerson = new Person();
        newPerson.askName();
        newPerson.printWelcome();
        newPerson.askLastName();
        newPerson.printFullName();

    }
}