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
            this.veiculos = new List<string>();
        }

        public void AdicionarVeiculo()
        {
            Console.Clear();
            // Solicita ao usuário a placa do veículo que será estacionado
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            // Verifica se a placa foi digitada
            if (placa == "")
            {
                Console.WriteLine("Por favor, digite uma placa válida");
            }
            else
            {
                // Adiciona a placa à lista de veículos
                veiculos.Add(placa);
                Console.WriteLine("Veículo adicionado com sucesso");
            }
        }

        public void RemoverVeiculo()
        {
            Console.Clear();
            // Solicita a placa que será removida do sistema
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // Pede ao usuário as horas totais em que o veículo permaneceu estacionado
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());

                // Realiza o cálculo para saber o valor total que deverá ser pago pelo cliente
                decimal valorTotal = precoInicial + precoPorHora * horas;

                // Remove a placa da lista de veículos
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            Console.Clear();
            int contador = 0;

            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são\n");

                // Loop criado para exibir os veículos que estão presentes na lista
                foreach (var veiculo in veiculos)
                {
                    contador++;
                    Console.WriteLine($"{contador}. Veículo com a Placa: {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}