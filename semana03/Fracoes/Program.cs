using System;

class Program
{
    static void Main(string[] args)
    {
        Fracao f1 = new Fracao();
        Fracao f2 = new Fracao(5);
        Fracao f3 = new Fracao(3, 4);
        Fracao f4 = new Fracao(1, 3);

        Console.WriteLine(f1.ObterFracaoEmTexto());
        Console.WriteLine(f1.ObterFracaoEmDecimal());

        Console.WriteLine(f2.ObterFracaoEmTexto());
        Console.WriteLine(f2.ObterFracaoEmDecimal());

        Console.WriteLine(f3.ObterFracaoEmTexto());
        Console.WriteLine(f3.ObterFracaoEmDecimal());

        Console.WriteLine(f4.ObterFracaoEmTexto());
        Console.WriteLine(f4.ObterFracaoEmDecimal());

        // Teste dos getters e setters
        Fracao teste = new Fracao();

        teste.DefinirNumerador(6);
        teste.DefinirDenominador(7);

        Console.WriteLine(teste.ObterNumerador());
        Console.WriteLine(teste.ObterDenominador());

        Console.WriteLine(teste.ObterFracaoEmTexto());
        Console.WriteLine(teste.ObterFracaoEmDecimal());
    }
}