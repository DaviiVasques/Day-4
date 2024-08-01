using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Quantas pessoas você quer adicionar? ");
        int tamanho;

        while (!int.TryParse(Console.ReadLine(), out tamanho) || tamanho <= 0)
        {
            Console.Write("Numero invalido, digite um numero inteiro: ");
        }
        Pessoa[] pessoas = new Pessoa[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Digite o nome da {i + 1} pessoa: ");
            string nome = Console.ReadLine();
            Console.Write($"Digite a idade da {i + 1} pessoa: ");
            int idade = int.Parse(Console.ReadLine());

            pessoas[i] = new Pessoa(nome, idade);
        }
        foreach (Pessoa pessoa in pessoas)
        {
            Console.WriteLine(pessoa);
        }
    }
}