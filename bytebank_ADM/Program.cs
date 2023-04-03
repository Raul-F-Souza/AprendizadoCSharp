using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitarios;

/* Testes para verificar o funcionamento
Funcionario pedro = new Funcionario("Pedro Malazartes", "123456789", 2000);

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor("Roberta Silva", "987654321");

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Resgistar(pedro);
gerenciador.Resgistar(roberta);

Console.WriteLine($"Total de bonificação de todos os funcionários: R${gerenciador.TotalBonificacao}");
Console.WriteLine($"Total de funcionarios na Bytebank: {Funcionario.TotalFuncionarios} Funcionários");

pedro.AumentarSalario();
roberta.AumentarSalario();

Console.WriteLine($"O novo salario de {pedro.Nome} após aumento é R${pedro.Salario}.");
Console.WriteLine($"O novo salario de {roberta.Nome} após aumento é R${roberta.Salario}."); */

/*void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Diretor paula = new Diretor("Paula Souza", "5453");
    Designer ulisses = new Designer("Ulisses Souza", "178634");
    Auxiliar igor = new Auxiliar("Igor Dias", "4231232");
    GerenteDeContas camila = new GerenteDeContas("Camila Oliveira", "12334");

    gerenciador.Resgistar(camila);
    gerenciador.Resgistar(igor);
    gerenciador.Resgistar(ulisses);
    gerenciador.Resgistar(paula);

    Console.WriteLine($"O total de bonificações da Bytebank desse ano: {gerenciador.TotalBonificacao}");
}

CalcularBonificacao(); */

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("Ingrid Oliveira", "123456789", "ingr1d@exemple.com", "123");
    GerenteDeContas ursula = new GerenteDeContas("Ursula Alcantara", "987654321", "Ursula37@exemple.com", "321");

    sistema.Logar(ingrid, "ingr1d@exemple.com", "123");
    sistema.Logar(ursula, "Ursula27@exemple.com", "143");

    ParceiroComercial caio = new ParceiroComercial("cai0@example.com", "999");

    sistema.Logar(caio, "cai0@example.com", "999");
}

UsarSistema();