using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        
        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        int numeroUsuario = -1;
        while (numeroUsuario != 0)
        {
            Console.Write("Insira o número: ");
            string respostaUsuario = Console.ReadLine();
            numeroUsuario = int.Parse(respostaUsuario);
            
            // Somente adicione o número à lista se ele não for 0
            if (numeroUsuario != 0)
            {
                numeros.Add(numeroUsuario);
            }
        }

        // Validação caso a lista esteja vazia
        if (numeros.Count == 0)
        {
            Console.WriteLine("Nenhum número foi inserido.");
            return;
        }

        // 1. Calcular a soma
        int soma = 0;
        foreach (int numero in numeros)
        {
            soma += numero;
        }
        Console.WriteLine($"A soma é: {soma}");

        // 2. Calcular a média
        // Convertemos a soma para float para garantir que a divisão decimal funcione corretamente
        float media = ((float)soma) / numeros.Count;
        Console.WriteLine($"A média é: {media}");

        // 3. Encontrar o maior número
        int maior = numeros[0];
        foreach (int numero in numeros)
        {
            if (numero > maior)
            {
                maior = numero;
            }
        }
        Console.WriteLine($"O maior número é: {maior}");

        // --- DESAFIOS ADICIONAIS (Opcionais) ---

        // Desafio 1: Encontrar o menor número positivo (mais próximo de zero)
        int menorPositivo = int.MaxValue;
        foreach (int numero in numeros)
        {
            if (numero > 0 && numero < menorPositivo)
            {
                menorPositivo = numero;
            }
        }

        if (menorPositivo != int.MaxValue)
        {
            Console.WriteLine($"O menor número positivo é: {menorPositivo}");
        }

        // Desafio 2: Ordenar e exibir a lista
        numeros.Sort();
        Console.WriteLine("A lista reordenada é:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}