namespace DesafioFundamentos.Models
{
    public class Estacionamento
{
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("\nDigite a placa do veículo para estacionar:");

            string veiculoEstacionando = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == veiculoEstacionando.ToUpper()))
            {
                Console.WriteLine("\nJá existe um veículo com esta placa estacionado. "
                + "Digite uma placa diferente");
                return;
            }
            else if (veiculoEstacionando.Length != 7)
            {
                Console.WriteLine("\nPlaca inválida! \nDigite uma placa de carro válida.");
                return;
            }
            else
            {
                Console.WriteLine($"\nO veículo {veiculoEstacionando} foi estacionado.");
            veiculos.Add(veiculoEstacionando);
            }
        }

        public void RemoverVeiculo()
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            Console.WriteLine("\nDigite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("\nDigite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                int horas = 0;
                bool inputValido = false;

                do
                {
                    inputValido = int.TryParse(Console.ReadLine(), out horas);
                    
                    if(!inputValido)
                    {
                    Console.WriteLine("\nValor inválido.");
                    Console.WriteLine("\nDigite a quantidade de horas que o veículo permaneceu estacionado:");
                    } 
                } while(!inputValido);

                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                decimal valorTotal = precoInicial + precoPorHora * horas;
                
                // TODO: Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);
                Console.WriteLine($"\nO veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("\nDesculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("\nOs veículos estacionados são:\n");
                
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("\nNão há veículos estacionados.");
            }
        }
    }
}
