using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        if (!int.TryParse(Console.ReadLine(), out int idade))
        {
            Console.WriteLine("Idade inválida. Tente novamente.");
            return;
        }

        Console.Write("Digite seu telefone: ");
        string telefone = Console.ReadLine();

        Console.Write("Digite seu e-mail: ");
        string email = Console.ReadLine();

        Console.WriteLine("\n---- Dados Cadastrados ----");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade} anos");
        Console.WriteLine($"Telefone: {telefone}");
        Console.WriteLine($"E-mail: {email}");
    }
}
