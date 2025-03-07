using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento))
        {
            DateTime hoje = DateTime.Today;
            int anos = hoje.Year - dataNascimento.Year;
            int meses = hoje.Month - dataNascimento.Month;
            int dias = hoje.Day - dataNascimento.Day;

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(hoje.Year, (hoje.Month == 1 ? 12 : hoje.Month - 1));
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            Console.WriteLine($"Idade: {anos} anos, {meses} meses e {dias} dias.");
        }
        else
        {
            Console.WriteLine("Formato de data inválido. Tente novamente.");
        }
    }
}
