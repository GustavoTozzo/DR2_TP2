using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número para exibir sua tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}
