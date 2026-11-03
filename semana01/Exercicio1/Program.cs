using System;

class Program
{
    static void Main(string[] args)
    //pedir o nome do usuario
    {
        Console.Write("Qual é o seu primeiro nome? ");
        string primeiroNome = Console.ReadLine();

         Console.Write("Qual é o seu sobre nome? ");
        string sobreNome = Console.ReadLine();

        Console.WriteLine($"Seu nome é {sobreNome}, {primeiroNome} {sobreNome}");


    }
}