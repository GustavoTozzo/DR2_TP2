﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero % 2 == 0)
                Console.WriteLine("O número é par.");
            else
                Console.WriteLine("O número é ímpar.");
        }
        else
        {
            Console.WriteLine("Valor inválido.");
        }
    }
}
