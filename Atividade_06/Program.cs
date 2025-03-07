using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu peso (kg): ");
        if (double.TryParse(Console.ReadLine(), out double peso) && peso > 0)
        {
            Console.Write("Digite sua altura (m): ");
            if (double.TryParse(Console.ReadLine(), out double altura) && altura > 0)
            {
                double imc = peso / (altura * altura);
                string classificacao;

                if (imc < 18.5)
                    classificacao = "Abaixo do peso";
                else if (imc < 24.9)
                    classificacao = "Peso normal";
                else if (imc < 29.9)
                    classificacao = "Sobrepeso";
                else if (imc < 34.9)
                    classificacao = "Obesidade Grau I";
                else if (imc < 39.9)
                    classificacao = "Obesidade Grau II";
                else
                    classificacao = "Obesidade Grau III (mórbida)";

                Console.WriteLine("\n=== Cálculo do IMC ===");
                Console.WriteLine($"Seu IMC: {imc:F2}");
                Console.WriteLine($"Classificação: {classificacao}");
            }
            else
            {
                Console.WriteLine("Altura inválida. Digite um valor válido.");
            }
        }
        else
        {
            Console.WriteLine("Peso inválido. Digite um valor válido.");
        }
    }
}
