using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o salário bruto: ");
        if (double.TryParse(Console.ReadLine(), out double salarioBruto) && salarioBruto > 0)
        {
            double imposto;

            if (salarioBruto <= 1903.98)
                imposto = 0;
            else if (salarioBruto <= 2826.65)
                imposto = salarioBruto * 0.075;
            else if (salarioBruto <= 3751.05)
                imposto = salarioBruto * 0.15;
            else if (salarioBruto <= 4664.68)
                imposto = salarioBruto * 0.225;
            else
                imposto = salarioBruto * 0.275;

            double salarioLiquido = salarioBruto - imposto;

            Console.WriteLine("\n- Cálculo do Salário -");
            Console.WriteLine($"Salário Bruto: R$ {salarioBruto:F2}");
            Console.WriteLine($"Desconto de Imposto: R$ {imposto:F2}");
            Console.WriteLine($"Salário Líquido: R$ {salarioLiquido:F2}");
        }
        else
        {
            Console.WriteLine("Valor inválido. Digite um salário válido.");
        }
    }
}
