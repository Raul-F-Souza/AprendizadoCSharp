using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 - Laços de repitações (for)");

        double investimento = 1000;

        for (int mes = 1;  mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem: " + investimento);
        }

        Console.WriteLine("Tecle enter para continuar...");
        Console.ReadLine();
    }
}
