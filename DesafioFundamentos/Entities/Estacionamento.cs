using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Globalization;

namespace DesafioFundamentos.Entities;

public class Estacionamento
{
    public decimal PrecoInicial { get; set; }
    public decimal PrecoHora { get; set; }
    public List<Veiculo> Veiculos = new List<Veiculo>();


    public Estacionamento(decimal precoInicial, decimal precoHora)
    {
        PrecoInicial = precoInicial;
        PrecoHora = precoHora;
        
    }


    public void AddVeiculos()
    {
        try
        {
            Console.Write("Digite a Placa Para Adicionar o Veiculo: ");
            string placa = Console.ReadLine();
            Console.Write("Digite o Modelo do Veiculo: ");
            string modeloVeiculo = Console.ReadLine();
            Console.Write("Digite a marca do Veiculo: ");
            string marcaVeiculo = Console.ReadLine(); 
            Console.Write("Digite a cor do Veiculo: ");
            string corVeiculo = Console.ReadLine();

            Veiculo novoCarro = new Veiculo
            {
                Placa = placa.ToUpper(),
                Modelo = modeloVeiculo,
                Marca = marcaVeiculo,
                Cor = corVeiculo
            };

           Veiculos.Add(novoCarro);
            Console.WriteLine("Veiculos adicionados com sucesso!");
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }

    public void RemoveVeiculos()
    {
        try
        {
            Console.Write("Digite a Placa Para Remover o veiculo: ");
            string placa = Console.ReadLine();

            if (Veiculos.Any(x => x.Placa.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Quantas Horas o Veiculo Ficou estacionado?");
                int horasEstacionadas = int.Parse(Console.ReadLine());

                decimal precoTotal = PrecoInicial + PrecoHora * horasEstacionadas;

                // 2. Encontra o objeto veículo exato para poder remover da lista
                var carroParaRemover = Veiculos.First(x => x.Placa.ToUpper() == placa.ToUpper());
                Veiculos.Remove(carroParaRemover);

                Console.WriteLine($"O Preço Total: R$ {precoTotal.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Veiculo {placa.ToUpper()},removido com sucesso!");
            
            }
            else
            {
                Console.WriteLine("Veiculo Inexistente!");
            }
        }
        catch (Exception e) 
        {
            Console.WriteLine(e.Message);
        }
       

        

    }

    public void ListarVeiculos()
    {
        try
        {
            Console.WriteLine("Veiculos Estacionados: ");
            if (Veiculos.Any())
                foreach (var carro in Veiculos)
                {
                    Console.WriteLine($"Placa: {carro.Placa} | Modelo: {carro.Modelo} | Marca: {carro.Marca} | Cor: {carro.Cor} \n");                }
            else
            {
                Console.WriteLine("Nenhum veiculo foi encontrado!");

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
}
