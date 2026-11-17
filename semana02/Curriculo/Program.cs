using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Criação e configuração do primeiro emprego
        Emprego emprego1 = new Emprego();
        emprego1._cargo = "Engenheiro de Software";
        emprego1._empresa = "Microsoft";
        emprego1._anoInicio = 2019;
        emprego1._anoFim = 2022;

        // 2. Criação e configuração do segundo emprego
        Emprego emprego2 = new Emprego();
        emprego2._cargo = "Gerente";
        emprego2._empresa = "Apple";
        emprego2._anoInicio = 2022;
        emprego2._anoFim = 2023;

        // 3. Criação e configuração do currículo
        Curriculo meuCurriculo = new Curriculo();
        meuCurriculo._nomePessoa = "José Carlos";

        // Adicionando os empregos à lista do currículo
        meuCurriculo._empregos.Add(emprego1);
        meuCurriculo._empregos.Add(emprego2);

        // 4. Exibindo o currículo completo usando o método Exibir
        meuCurriculo.Exibir();
    }
}
