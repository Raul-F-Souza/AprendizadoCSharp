﻿using System;
class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 5 - Criando Variáveis");
        Console.WriteLine(string.Empty);

        //int serve para (e exclusivamente) números inteiros
        int idade = 27;

        //Double é a variável para números com decimais (mais utilizada comparada a float), maximo de 32bits
        //pode se converter double em int uilizando a sintaxe: double x = (int)123.4
        double salario = 3626.75 * 2.67;

        //Variavél short serve para pequenas quantidades de números
        short habitantes = 15000;

        //float é uma alternativa para números que contém decimais, mas pouco utilizada por questões de dados
        //e sempre é necessario o uso de "f" ao final do numero
        float minhaAltura = 1.78f;

        //long é utilizada para valores que necessitam de bastante dados (maximo de 64bits)
        long x = 2000000000000000000;

        //char é a variavel que declara apena um cacacter, não importa qual. Pode ser escrita no numero do caracater
        char virgula = ','; //e tambem pode ser com numero, como: char letra = (char)65; resultando em "A"

        //string é como declaramos uma variável dp tipo texto
        string listaGostos = @"Meus gostos: 
-Tons escuros e neutros 
-Gatos 
-Tranqulidade 
-Confiança";    //o "@" no inicio do valor faz com que a quebra de linha dentro da string seja possível

        Console.Write("Daqui cinco anos eu terei essa idade aqui -> " + idade
        + " e meu salario vai ser de R$" + salario + virgula);
        Console.WriteLine(string.Empty);

        idade = idade - 5;
        salario = 3626.75;

        Console.Write("mas enquato isso não ocorre, eu continuo com " + idade
        + " e com o salario de R$" + salario);
        Console.WriteLine(string.Empty);

        Console.WriteLine("Minha altura é " + minhaAltura);
        Console.WriteLine(string.Empty);

        Console.WriteLine("A quantidade de habitantes da minha cidade é: " + habitantes);
        Console.WriteLine(string.Empty);


        Console.WriteLine("Após começar esse curso de CSharp minha felicidade foi para " + x);
        Console.WriteLine(string.Empty);

        Console.WriteLine(listaGostos);
        Console.WriteLine(string.Empty);

        Console.WriteLine("Tecle enter para continuar...");
        Console.ReadLine();
    }
}