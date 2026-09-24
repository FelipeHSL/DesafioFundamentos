using System;
using System.Globalization;
using DesafioFundamentos.Entities;

namespace DesafioFundamentos;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o Preco Inicial: ");
        decimal PrecoInicial = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite o Preco Hora: ");
        decimal PrecoHora = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Estacionamento es = new Estacionamento(PrecoInicial, PrecoHora);
        
        while (true)
        {
            Console.WriteLine("1 - Adicionar Veiculos  \n2 - Remover Veiculos  \n3 - Listar Veiculos  \n4 - Encerrar");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.Write("Digite Quantos Carros Deseja Registrar: ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= n; i++)
                    {
                        es.AddVeiculos();
                    }
                    break;
                case "2":
                    es.RemoveVeiculos();
                    break;
                case "3":
                    
                    es.ListarVeiculos();
                   break;
                case "4":
                    Console.WriteLine("Obrigado por usar o nosso estacionamento!");
                    return;
            }
            ;
            
            
        }
    }
}