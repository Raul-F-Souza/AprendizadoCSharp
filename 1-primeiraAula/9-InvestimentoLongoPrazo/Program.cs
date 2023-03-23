using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 - Laços de repitações (for)");

        double investimento = 1000;
        double fatorRendimento = 1.005;

        for (int ano = 1; ano <= 5; ano++)
        {

            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }

            fatorRendimento += 0.001;
        }

        Console.WriteLine("Depois de cinco anos com R$1000,00 investidos você terá R$" + investimento);

        Console.WriteLine("Tecle enter para continuar...");
        Console.ReadLine();
    }
}
