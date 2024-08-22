using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

bool input1 = true;
bool input2 = true;
bool valorInvalido = false;

do
{
    Console.Clear();
    Console.WriteLine("\n\tSeja bem vindo ao sistema de estacionamento!\n");

    Console.WriteLine("Digite o preço inicial:");
    input1 = Decimal.TryParse(Console.ReadLine(), out precoInicial);
    
    Console.WriteLine("Agora digite o preço por hora:");
    input2 = Decimal.TryParse(Console.ReadLine(), out precoPorHora);

    if (!input1 || !input2) 
    {
        valorInvalido = true;
        Console.WriteLine("Entrada de dados inválidos. Tente novamente.");
        Console.Read();
    }
    else
    {
        valorInvalido = false;
    }
    
} while(valorInvalido);

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("\nDigite a sua opção:\n");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("\nOpção inválida");
            break;
    }

    Console.WriteLine("\nPressione uma tecla para continuar");
    Console.Read();
}
Console.WriteLine("O programa se encerrou.\n");
