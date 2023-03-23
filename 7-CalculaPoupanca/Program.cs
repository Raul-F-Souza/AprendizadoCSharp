using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Laços de repitações");

        int mes = 1;
        double investimento = 1000;

        //Calcular montante de investimento com juros de 0.5%

        while(mes <=12)
        {
            investimento = investimento + (investimento * 0.005) * mes;
            Console.WriteLine("No mês "+ mes + " você tem: " + investimento);
            mes++;
        }

        Console.WriteLine("Tecle enter para continuar...");
        Console.ReadLine();
    }
}
