using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um valor em graus Celsius: ");
        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            double fahrenheit = celsius * 9 / 5 + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine("\n--- Conversão de Temperatura --");
            Console.WriteLine($"Celsius: {celsius:F2} °C");
            Console.WriteLine($"Fahrenheit: {fahrenheit:F2} °F");
            Console.WriteLine($"Kelvin: {kelvin:F2} K");
        }
        else
        {
            Console.WriteLine("Valor inválido. Digite um número válido.");
        }
    }
}
