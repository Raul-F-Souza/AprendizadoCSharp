using bytebank.Conta;
using bytebank.Titular;

/*  Testes e execicios para aprender fundamentos da orientacão a objetos. 
 *  
 *  
 *  
ContaCorrente contaAndre = new ContaCorrente();
//contaAndre.titular = "André Silva";
//contaAndre.numero_agencia = 15;
//contaAndre.conta = "1010-x";
//contaAndre.saldo = 100;

//Console.WriteLine($"saldo do André: R${String.Format("{0:0.00}", contaAndre.saldo)}");


// contaAndre.depositar(100);

//Console.WriteLine($"O saldo do André após deposito: R${String.Format("{0:0.00}", contaAndre.saldo)}");

//if (contaAndre.sacar(300) == true)
//{
//    Console.WriteLine($"O saldo do André após saque: R${String.Format("{0:0.00}", contaAndre.saldo)}");

//}
//else
//{
//    Console.WriteLine("Saldo insuficiente para saque.");
//}

//ContaCorrente contaMaria = new ContaCorrente();
//contaMaria.titular = "Maria Souza";
//contaMaria.numero_agencia = 17;
//contaMaria.conta = "1010-5";
//contaMaria.saldo = 350;



//Console.WriteLine($"saldo da Maria: R${String.Format("{0:0.00}", contaMaria.saldo)}");

//contaAndre.Transferir(50, contaMaria);

//Console.WriteLine($"saldo do André: R${String.Format("{0:0.00}", contaAndre.saldo)}");
//Console.WriteLine($"saldo da Maria: R${String.Format("{0:0.00}", contaMaria.saldo)}");
//Console.WriteLine(string.Empty);

//ContaCorrente contaPedro = new ContaCorrente();
//contaPedro.titular = "Pedro silva";
//Console.WriteLine(contaPedro.titular);
//Console.WriteLine(contaPedro.numero_agencia);
//Console.WriteLine(contaPedro.conta);
//Console.WriteLine(contaPedro.saldo);

//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista";

ContaCorrente conta = new ContaCorrente();
conta.titular = new Cliente();
conta.conta = "1010-X";
conta.numero_agencia = 15;
conta.SetSaldo(100);

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("Cpf = " + conta.titular.cpf);
//Console.WriteLine("Profissao = " + conta.titular.profissao);
//Console.WriteLine("Nº Conta = " + conta.conta);
//Console.WriteLine("Saldo = " + conta.saldo);
//Console.WriteLine("Nº Agência = " + conta.numero_agencia);

//Console.WriteLine(string.Empty);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.Titular = new Cliente();
//conta2.Titular.Nome = "José Souza";
//conta2.Titular.Profissao = "Tester";
//conta2.Titular.Cpf = "987654321";
//conta2.Conta = "9999-X";
//conta2.Numero_agencia = 18;
//Console.WriteLine(conta2.Numero_agencia);


//Console.WriteLine(conta2.Titular.Nome);
//Console.WriteLine(conta2.Titular.Profissao);
//Console.WriteLine(conta2.Titular.Cpf);
//Console.WriteLine(conta2.Conta); */

/* Aprendendo ctor e entendo a manipular
 * ContaCorrente conta4 = new ContaCorrente(18, "1010-x");
conta4.SetSaldo(500);
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta5 = new ContaCorrente(18, "9876-c");
conta4.SetSaldo(500);
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta7 = new ContaCorrente(148, "2309-x");
conta4.SetSaldo(500);
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);



Cliente sarah = new Cliente();
sarah.Nome = "Sarah Silva";
sarah.Profissao = "Professora";
sarah.Cpf = "11111111-12";

Cliente ester = new Cliente();
ester.Nome = "Ester Almeida";
ester.Profissao = "Advogada";
ester.Cpf = "868524125-32";

Console.WriteLine("Total de clientes: "+ Cliente.TotalClientesCadastrados);

ContaCorrente contaAndre = new ContaCorrente(159,"152869-x");
contaAndre.Titular = new Cliente();
contaAndre.Titular.Nome = " André Pereira";
contaAndre.Titular.Profissao = "Auxiliar Administrativo";
contaAndre.SetSaldo(100);

Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados); */

/* desafio Alura
 * Fazer todos os campos declarados nos objetos "ContaCorrente" e "Cliente" passsarem a ser obrigatorios
 * 
ContaCorrente contaAndre = new ContaCorrente(159, "152869-x", 150, new Cliente("Andre Pereira", "Auxiliar Administrativo", "123456789"));
ContaCorrente contaMaria = new ContaCorrente(187, "123456-x", 170, new Cliente("Maria Pereira", "Gerente","987654321"));

Console.WriteLine(contaAndre.Conta);
Console.WriteLine(contaAndre.GetSaldo());
Console.WriteLine(contaAndre.Titular.Nome);
Console.WriteLine(string.Empty);

Console.WriteLine(contaMaria.Conta);
Console.WriteLine(contaMaria.GetSaldo());
Console.WriteLine(contaMaria.Titular.Nome); */

Console.ReadLine();


