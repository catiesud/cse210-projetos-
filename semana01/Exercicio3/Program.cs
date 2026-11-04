using System;

class Program
{
    static void Main()
    {
        Console.Write("Qual é o número mágico? ");
        int numeroMagico = 42;
        Random geradorAleatorio = new Random();

        int palpite = -1;
        while (palpite != numeroMagico)
        {
            Console.Write("Qual é o seu palpite? ");
            palpite = int.Parse(Console.ReadLine());

            if (palpite < numeroMagico)
            {
                Console.WriteLine("Muito baixo!");
            }
            else if (palpite > numeroMagico)
            {
                Console.WriteLine("Muito alto!");
            }
        }
        
        Console.WriteLine("Parabéns! Você acertou!");
    }
}
