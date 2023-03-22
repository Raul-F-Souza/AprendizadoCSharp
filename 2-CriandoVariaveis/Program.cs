using System;
class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 2 - Criando Variáveis");

        int idade;

        idade = 27;

        Console.WriteLine("Daqui cinco anos eu terei essa idade aqui -> " + idade);

        idade = idade - 5;

        Console.WriteLine("Mas enquato isso não ocorre, eu continuo com " + idade);

        Console.WriteLine("Tecle enter para continuar...");
        Console.ReadLine();
    }
}