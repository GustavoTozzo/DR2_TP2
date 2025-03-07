using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número para iniciar a contagem regressiva: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = numero; i >= 0; i--)
        {
            if (i > 0)
            {
                Console.Write(i + ", ");
            }
            else
            {
                Console.Write(i);
            }
        }
    }
}
