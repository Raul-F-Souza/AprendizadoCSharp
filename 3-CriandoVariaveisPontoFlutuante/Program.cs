using System;
class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 3 - Criando Variáveis");

        int idade;
        double salario;

        idade = 27;
        salario = 3626.75 * 2.67;

        Console.Write("Daqui cinco anos eu terei essa idade aqui -> " + idade );
        Console.WriteLine(" e meu salario vai ser de R$" + salario );

        idade = idade - 5;
        salario = 3626.75;

        Console.Write(", mas enquato isso não ocorre, eu continuo com " + idade);
        Console.WriteLine(" e com o salario de R$" + salario);

        Console.WriteLine("Tecle enter para continuar...");
        Console.ReadLine();
    }
}