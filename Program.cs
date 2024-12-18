using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Estacionamento estacionamento = new Estacionamento(5); // Valor fixo de 5 reais por hora
        string opcao;

        do
        {
            Console.WriteLine("\n--- Sistema de Gerenciamento de Estacionamento ---");
            Console.WriteLine("1 - Adicionar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    estacionamento.AdicionarVeiculo();
                    break;
                case "2":
                    estacionamento.RemoverVeiculo();
                    break;
                case "3":
                    estacionamento.ListarVeiculos();
                    break;
                case "4":
                    Console.WriteLine("Encerrando o sistema. Obrigado!");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        } while (opcao != "4");
    }
}

class Estacionamento
{
    private decimal precoPorHora;
    private Dictionary<string, DateTime> veiculos;

    public Estacionamento(decimal precoPorHora)
    {
        this.precoPorHora = precoPorHora;
        this.veiculos = new Dictionary<string, DateTime>();
    }

    public void AdicionarVeiculo()
    {
        Console.Write("Digite a placa do veículo para estacionar: ");
        string placa = Console.ReadLine();

        if (veiculos.ContainsKey(placa))
        {
            Console.WriteLine("Este veículo já está estacionado.");
        }
        else
        {
            veiculos.Add(placa, DateTime.Now);
            Console.WriteLine($"Veículo de placa {placa} adicionado com sucesso!");
        }
    }

    public void RemoverVeiculo()
    {
        Console.Write("Digite a placa do veículo para remover: ");
        string placa = Console.ReadLine();

        if (veiculos.ContainsKey(placa))
        {
            DateTime horarioEntrada = veiculos[placa];
            TimeSpan tempoEstacionado = DateTime.Now - horarioEntrada;
            decimal valorCobrado = (decimal)Math.Ceiling(tempoEstacionado.TotalHours) * precoPorHora;

            veiculos.Remove(placa);
            Console.WriteLine($"Veículo de placa {placa} removido com sucesso!");
            Console.WriteLine($"Tempo estacionado: {tempoEstacionado.Hours}h {tempoEstacionado.Minutes}min");
            Console.WriteLine($"Valor cobrado: R$ {valorCobrado:F2}");
        }
        else
        {
            Console.WriteLine("Desculpe, este veículo não está estacionado aqui. Confira a placa e tente novamente.");
        }
    }

    public void ListarVeiculos()
    {
        if (veiculos.Count > 0)
        {
            Console.WriteLine("\nVeículos estacionados:");
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine($"Placa: {veiculo.Key} | Entrada: {veiculo.Value}");
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}
