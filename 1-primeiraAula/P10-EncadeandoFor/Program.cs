using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Laços de repitações (for)");

        //*
        //**
        //***
        //****

        for(int linhas = 1; linhas <= 10; linhas++)
        {
            for (int colunas = 1; colunas <= 10; colunas++)
            {
                Console.Write("*");
                if (colunas >= linhas) break;
            }
            Console.WriteLine();
        }

        Console.WriteLine("Tecle enter para continuar...");
        Console.ReadLine();
    }
}
