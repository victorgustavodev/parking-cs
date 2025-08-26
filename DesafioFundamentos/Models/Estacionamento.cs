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
            // Implementado!!!!!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string Placa = Console.ReadLine();

            veiculos.Add(Placa);
            Console.WriteLine("Carro adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string Placa = Console.ReadLine();
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == Placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());

                decimal calculo = precoInicial + precoPorHora * horas;

                decimal valorTotal = calculo;

                veiculos.Remove(Placa);

                Console.WriteLine($"O veículo {Placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {

            int contador = 1;

            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine($"{contador} - {veiculo}");
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
