using System;
using System.Collections.Generic;
using System.Text;

namespace Henzo_e_Vinícius_Avaliação
{
    class ConsoleLocadoras
    {
        public static void MostrarMenu()
        {
            
            Console.WriteLine($"Console das Locadoras\n" +
                $"----------------------------------------------" +
                $"Digite os números para acessar os métodos" +
                $"1 - Criar uma Locadora" +
                $"2 - Remover uma Locadora" +
                $"3 - Listar as Locadoras" +
                $"4 - Selecionar Locadora" +
                $"5 - Adícionar Veículo" +
                $"6 - Listar os Veículos disponíveis" +
                $"---/-------------/---------/----" +
                

                $"7 - Listar os Carros disponíveis" +
                $"8 - Listar os Aviões disponíveis" +
                $"9 - Listar todos os tipos de veículos" +
                $"-------/--------------/-----" +
                $"10 - Cadastrar Cliente" +
                $"11 - Listar os Clientes" +
                $"12 - Selecionar um Cliente" +
                $"-------/------/-------/" +
                $"13 - Iniciar Aluguel" +
                $"14 - Devolver Veículo" +
                $"15 - Listar Alugueis" +
                $"16 - Listar Alugueis do Cliente");
            int comando = int.Parse(Console.ReadLine());
            switch (comando)
            {
                case 1:
                    CriarLocadora();
                    break;
                case 2:
                    RemoverLocadora();
                    break;
                case 3:
                    ListarLocadoras();
                    break;
                case 4:
                    SelecionarLocadora();
                    break;
                case 5:
                    AdicionarVeiculo();
                    break;
                case 6:
                    ListarVeiculosDisponíveis();
                    break;
                case 7:
                    ListarCarrosDisponíveis();
                    break;
                case 8:
                    ListaAviõesDisponíveis();
                    break;
                case 9:
                    ListarTodosOsVeiculos();
                    break;
                case 10:
                    CadastrarCliente();
                    break;
                case 11:
                    ListarClientes();
                    break;
                case 12:
                    SelecionarCliente();
                    break;
                case 13:
                    IniciarAluguel();
                    break;
                case 14:
                    DevolverVeiculo();
                    break;
                case 15:
                    ListarAlugueis();
                    break;
                case 16:
                    AluguelPorCliente();
                    break;
                default:
                    Console.WriteLine("O comando que você está tentando chamar não existe");
                    break;    
            }
        }
        public static void CriarLocadora()
        {
            string nome;
            string endereço;
            Console.WriteLine("Digite o nome da locadora que você deseja criar: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o endereço da locadora que você deseja criar: ");
            endereço = Console.ReadLine();
            RedeLocadoras.AdicionarLocadora(new Locadora(nome, endereço));
        }
        public static void ListarLocadoras()
        {
            RedeLocadoras.ListarLocadoras();
        }

        public static void RemoverLocadora()
        {
            string LocRemove;
            ListarLocadoras();
            Console.WriteLine("QUAL LOCADORA DESEJA REMOVER DO SISTEMA? :")
            LocRemove = Console.ReadLine();

            Console.WriteLine($"{LocRemove} foi removida do sistema");
        }

        public static int idveiculo = 0;
        public static string locadoraselecionada = "";
        public static string carroselecionado = "";
        public static string veículoselecionado = "";
        public static void SelecionarLocadora()
        {
            locadoraselecionada = "";
            string locselecionar;
            ListarLocadoras();
            Console.WriteLine("Digite a locadora que você quer adicionar: ")
            locselecionar = Console.ReadLine();
            foreach (Locadora l in RedeLocadoras.Locadoras)
            {
                if (l.Nome.Equals(locselecionar))
                {
                    locadoraselecionada = l.nome;
                    Console.WriteLine($"{locselecionar} foi selecionada");
                }
                if (locadoraselecionada == "")
                {
                    Console.WriteLine("Essa locadora não foi encontrada no nosso sistema");
                }
            }
        }

        public static void AdicionarVeiculo()
        {
            string marca = "";
            string modelo = "";
            string tipoCA = "";
            string TipoVeic = "";
            string placa = "";
            float HorasVoo = 0;
            float quilometragem = 0;
            if (locadoraselecionada == "")
            {
                Console.WriteLine("ESSE COMANDO SÓ FUNCIONA SE UMA LOCADORA ESTIVER SELECIONADA!");
                return;
            }
            Console.WriteLine($"Você está prestes a adicionar um veículo na Locadora : {locadoraselecionada}" +
                $"O veículo é um carro ou um avião? ");

            tipoCA: tipoCA = Console.ReadLine();
            if (tipoCA != "Avião")
            {
                Console.WriteLine("O SISTEMA SÓ SUPORTA CARROS E AVIÕES");
                goto tipoCA;
            }
            else if (tipoCA != "Carro")
            {
                Console.WriteLine("O SISTEMA SÓ SUPORTA CARROS E AVIÕES");
                goto tipoCA;
            }
            if (tipoCA == "Avião")
            {
                Console.WriteLine("Digite as horas de voo do avião: ")
                    TipoVeic = "Aviao";
                HorasVoo = float.Parse(Console.ReadLine());

            }
            if (tipoCA == "Carro")
            {
                TipoVeic = "Carro";
                Console.WriteLine("Digite a placa do carro: ");
                placa = Console.ReadLine();
                Console.WriteLine("Digite a quilometragem do carro: ")
                    quilometragem = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite a marca do veículo : ");
            marca = Console.ReadLine();
            Console.WriteLine("Agora digite o modelo do veículo: ");
            modelo = Console.ReadLine();

            foreach (Locadora l in RedeLocadoras.Locadoras)
            {
                if (l.nome.Equals(locadoraselecionada))
                {
                    l.AdicionarVeiculoAluguel(new VeículoAluguel(idveiculo.ToString(), locadoraselecionada, TipoVeic, HorasVoo, placa, quilometragem, marca, modelo, false));
                    idveiculo += 1;
                }
            }


        }
        
        public static void ListarVeiculosDisponíveis()
        {
            if (locadoraselecionada = "")
            {
                Console.WriteLine("VOCE DEVE SELECIONAR UMA LOCADORA PRIMEIRO")
            }

        }

    }
}
