using System;

class JogoAdivinhacao
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int palpite;
        int tentativas = 0;

        Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

        do
        {
            Console.Write("Digite seu palpite: ");
            palpite = int.Parse(Console.ReadLine());
            tentativas++;

            if (palpite < numeroSecreto)
            {
                Console.WriteLine("Muito baixo! Tente novamente.");
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine("Muito alto! Tente novamente.");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você acertou o número em {tentativas} tentativas.");
            }
        } while (palpite != numeroSecreto);
    }
}
