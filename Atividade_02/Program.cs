using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento))
        {
            DateTime hoje = DateTime.Today;
            DateTime proximoAniversario = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);

            if (proximoAniversario < hoje)
            {
                proximoAniversario = proximoAniversario.AddYears(1);
            }

            int diasParaAniversario = (proximoAniversario - hoje).Days;
            Console.WriteLine($"Faltam {diasParaAniversario} dias para o seu próximo aniversário.");
        }
        else
        {
            Console.WriteLine("Data inválidaa. Tente novamente.");
        }
    }
}
