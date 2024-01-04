﻿using System;

class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Jogador( string nome, string nacionalidade, int idade, string posicao )
    {
        Nome = nome;
        Nacionalidade = nacionalidade;
        Idade = idade;
        Posicao = posicao;

        Console.WriteLine();
        Console.WriteLine("Jogador criado!");
        Console.WriteLine(Nome);
        Console.WriteLine(Nacionalidade);
        Console.WriteLine(Idade);
        Console.WriteLine($"Posição: {Posicao}");
        
    }
}

class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        string nacionalidade = Console.ReadLine();
        int idade = int.Parse(Console.ReadLine());
        string posicao = Console.ReadLine();

        Jogador jogador = new Jogador(nome, nacionalidade, idade, posicao);

    }
}