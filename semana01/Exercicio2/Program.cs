

using System;

class Program
{
    
        static void Main()
        //digitar nota
    {
        Console.Write("Digite sua nota numérica: ");
        int nota = Convert.ToInt32(Console.ReadLine());

        string letra;

        // Determina a letra da nota
        if (nota >= 90)
            letra = "A";
        else if (nota >= 80)
            letra = "B";
        else if (nota >= 70)
            letra = "C";
        else if (nota >= 60)
            letra = "D";
        else
            letra = "F";

        // Determina se foi aprovado
        if (nota >= 70)
            Console.WriteLine("Parabéns, você foi aprovado!");
        else
            Console.WriteLine("Não foi desta vez, continue tentando!");

        // Desafio adicional: adicionar + ou -
        string sinal = "";

        if (letra != "A" && letra != "F") // não existe A+ nem F+ ou F-
        {
            int ultimoDigito = nota % 10;

            if (ultimoDigito >= 7)
                sinal = "+";
            else if (ultimoDigito < 3)
                sinal = "-";
        }
        else if (letra == "A" && nota < 93) // só existe A-
        {
            sinal = "-";
        }

        // Exibe a nota final
        Console.WriteLine($"Sua nota conceitual é: {letra}{sinal}");
    }
}
