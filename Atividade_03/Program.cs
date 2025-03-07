using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a primeira data (dd/mm/aaaa): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime data1))
        {
            Console.Write("Digite a segunda data (dd/mm/aaaa): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime data2))
            {
                if (data1 > data2)
                {
                    (data1, data2) = (data2, data1);
                }

                int anos = data2.Year - data1.Year;
                int meses = data2.Month - data1.Month;
                int dias = data2.Day - data1.Day;

                if (dias < 0)
                {
                    meses--;
                    dias += DateTime.DaysInMonth(data2.Year, data2.Month == 1 ? 12 : data2.Month - 1);
                }

                if (meses < 0)
                {
                    anos--;
                    meses += 12;
                }

                Console.WriteLine($"A diferença entre as datas é de {anos} anos, {meses} meses e {dias} dias.");
            }
            else
            {
                Console.WriteLine("Formato de data inválido para a segunda data. Tente novamente.");
            }
        }
        else
        {
            Console.WriteLine("Formato de data inválido para a primeira data. Tente novamente.");
        }
    }
}
