using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma nota de 0 a 10: ");
        if (double.TryParse(Console.ReadLine(), out double nota) && nota >= 0 && nota <= 10)
        {
            string classificacao;

            if (nota < 5)
                classificacao = "Insuficiente";
            else if (nota < 7)
                classificacao = "Regular";
            else if (nota < 9)
                classificacao = "Bom";
            else
                classificacao = "Excelente";

            Console.WriteLine($"Classificação: {classificacao}");
        }
        else
        {
            Console.WriteLine("Nota inválida. Digite um valor entre 0 e 10.");
        }
    }
}
