using csharp_exception.Titular;
using csharp_exception.Contas;
using csharp_exception.Exeptions;
using csharp_exception.Utilitarios;
using System.Runtime.CompilerServices;

/*
try
{
    ContaCorrente andre = new ContaCorrente(0, "1234-X", new Cliente("André Bessa", "123456789", "Gerente Geral"));

    /*
    andre.Sacar(50);
    Console.WriteLine($"Seu saldo: R${andre.GetSaldo()}.");
    andre.Sacar(150);
    Console.WriteLine($"Seu saldo: R${andre.GetSaldo()}.");
    
}
catch (ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro: " + ex.ParamName);
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero.");
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Message);

}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine("Ação negada por saldo insuficiente.");
    Console.WriteLine(ex.Message);
    Console.WriteLine(string.Empty);
}

try
{
    ContaCorrente andre = new ContaCorrente(277, "1234-X", new Cliente("André Bessa", "123456789", "Gerente Geral"));
    ContaCorrente pedro = new ContaCorrente(123, "1010-y", new Cliente("Pedro Ferreira", "987654321", "Cientista"));
    pedro.SetSaldo(500);
    Console.WriteLine($"Saldo de pedro: R${pedro.GetSaldo()},00");
    pedro.Transferir(1500, andre);
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine("Ação negada");
    Console.WriteLine(ex.Message);
}

*/

LeitorDeArquivo leitor = new LeitorDeArquivo("Contas.txt");

try
{

    leitor.LerProximaLinha();
    leitor.LerProximaLinha();

}
catch (IOException)
{
    Console.WriteLine("Leitura de arquivo interrompida.");
}
finally
{
    leitor.Dispose();
}