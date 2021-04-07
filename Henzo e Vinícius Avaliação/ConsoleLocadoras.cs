using System;
using System.Collections.Generic;
using System.Text;

namespace Henzo_e_Vinícius_Avaliação
{
    class ConsoleLocadoras
    {
        public static void main()
        {

            RedeLocadoras.AdicionarLocadora(new Locadora("Locadora vinao", "Av higienopolis 280"));
            RedeLocadoras.AdicionarLocadora(new Locadora("Locadora Henzo", "Av Juscelino Kubitscheck"));
            int keep = 0;
            while (keep == 0)
            {
                MostrarMenu();
            }
          
        }
        public static void MostrarMenu()
        {

            Console.WriteLine($"Console das Locadoras");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Digite os números para acessar os métodos");
            Console.WriteLine("1 - Criar uma Locadora");
            Console.WriteLine("2 - Remover uma Locadora");
            Console.WriteLine("3 - Listar as Locadoras");
            Console.WriteLine("4 - Selecionar Locadora");
            Console.WriteLine("5 - Adícionar Veículo");
            Console.WriteLine("6 - Listar os Veículos disponíveis");
            Console.WriteLine("----------------------------------------------");


            Console.WriteLine("7 - Listar os Carros disponíveis");
            Console.WriteLine("8 - Listar os Aviões disponíveis");
            Console.WriteLine("9 - Listar todos os tipos de veículos");
            Console.WriteLine("-------/--------------/-----");
            Console.WriteLine("10 - Cadastrar Cliente");
            Console.WriteLine("11 - Listar os Clientes");
            Console.WriteLine("12 - Selecionar um Cliente");
            Console.WriteLine("-------/------/-------/");
            Console.WriteLine("13 - Iniciar Aluguel");
            Console.WriteLine("14 - Devolver Veículo");
            Console.WriteLine("15 - Listar Alugueis");
            Console.WriteLine("16 - Listar Alugueis do Cliente");
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
                    ListarAviõesDisponíveis();
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
            Console.WriteLine($"A locadora {nome} que fica no endereço {endereço} foi criada com sucesso! $");
        }
        public static void ListarLocadoras()
        {
            RedeLocadoras.ListarLocadoras();
        }

        public static void RemoverLocadora()
        {
            string LocRemove;
            ListarLocadoras();
            Console.WriteLine("QUAL LOCADORA DESEJA REMOVER DO SISTEMA? :");
            LocRemove = Console.ReadLine();

            Console.WriteLine($"{LocRemove} foi removida do sistema");
        }

        public static int idveiculo = 0;
        public static string clienteselecionado = "";
        public static string locadoraselecionada = "";
        public static string carroselecionado = "";
        public static string veiculoselecionado = "";
        public static void SelecionarLocadora()
        {
            locadoraselecionada = "";
            string locselecionar;
            ListarLocadoras();
            Console.WriteLine("Digite a locadora que você quer selecionar: ");
            locselecionar = Console.ReadLine();
            foreach (Locadora l in RedeLocadoras.Locadoras)
            {
                if (l.Nome.Equals(locselecionar))
                {
                    locadoraselecionada = l.Nome;
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

            tipoCA = Console.ReadLine();
            if (tipoCA != "Avião")
            {
                Console.WriteLine("O SISTEMA SÓ SUPORTA CARROS E AVIÕES");
                
            }
            else if (tipoCA != "Carro")
            {
                Console.WriteLine("O SISTEMA SÓ SUPORTA CARROS E AVIÕES");
                
            }
            if (tipoCA == "Avião")
            {
                Console.WriteLine("Digite as horas de voo do avião: ");
                    TipoVeic = "Aviao";
                HorasVoo = float.Parse(Console.ReadLine());

            }
            if (tipoCA == "Carro")
            {
                TipoVeic = "Carro";
                Console.WriteLine("Digite a placa do carro: ");
                placa = Console.ReadLine();
                Console.WriteLine("Digite a quilometragem do carro: ");
                    quilometragem = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite a marca do veículo : ");
            marca = Console.ReadLine();
            Console.WriteLine("Agora digite o modelo do veículo: ");
            modelo = Console.ReadLine();

            foreach (Locadora l in RedeLocadoras.Locadoras)
            {
                if (l.Nome.Equals(locadoraselecionada))
                {
                    l.AdicionarVeiculoAluguel(new VeiculoAluguel(idveiculo.ToString(), locadoraselecionada, TipoVeic, HorasVoo, placa, quilometragem, marca, modelo, false));
                    idveiculo += 1;
                }
            }


        }

        public static void ListarVeiculosDisponíveis()
        {
            if (locadoraselecionada == "")
            {
                Console.WriteLine("VOCE DEVE SELECIONAR UMA LOCADORA PRIMEIRO");
            }
            else
            {
                foreach (Locadora loc in RedeLocadoras.Locadoras)
                {
                    if (loc.Nome == locadoraselecionada)
                    {
                        Locadora.ListarVeiculosDisponiveis(locadoraselecionada);
                    }
                }
            }
        }
            public static void ListarCarrosDisponíveis()
            {
                if (locadoraselecionada == "")
                {
                    Console.WriteLine("Selecione uma locadora primeiro");
                }
                else
                {
                    foreach (Locadora loc in RedeLocadoras.Locadoras)
                    {

                        if (loc.Nome == locadoraselecionada)
                        {
                            Locadora.ListarCarrosDisponiveis(locadoraselecionada);
                        }
                    }
                }
            }

            public static void ListarAviõesDisponíveis()
            {
                if (locadoraselecionada == "")
                {
                    Console.WriteLine("VOCE PRECISA SELECIONAR UMA LOCADORA!");
                }
                else
                {
                    foreach (Locadora loc in RedeLocadoras.Locadoras)
                    {

                        if (loc.Nome == locadoraselecionada)
                        {
                            Locadora.ListarAviõesDisponiveis(locadoraselecionada);
                        }
                    }
                }
            }

        public static void ListarTodosOsVeiculos()
        {
            if (locadoraselecionada == "")
            {
                Console.WriteLine("VOCE PRECISA SELECIONAR UMA LOCADORA!");
            }
            else
            {
                foreach (Locadora loc in RedeLocadoras.Locadoras)
                {
                    if (loc.Nome == locadoraselecionada)
                    {
                        Locadora.ListarTodosOsVeículos(locadoraselecionada);
                    }
                }
            }
        }

        public static void CadastrarCliente()
        {
            string ncliente;
            string cpf;
            Console.WriteLine("Digite o nome do cliente: ");
            ncliente = Console.ReadLine();
            Console.WriteLine("Digite o cpf do cliente");
            cpf = Console.ReadLine();
            RedeLocadoras.Clientes.Add(new Cliente(ncliente, cpf));
            Console.WriteLine($"O cliente {ncliente} foi adicionado ao sistema");
        }
        public static void ListarClientes()
        {
            Console.WriteLine("-");
            Console.WriteLine("Clientes cadastrados: ");
            foreach (Cliente c in RedeLocadoras.Clientes)
            {
                Console.WriteLine($"O Nome do cliente é: {c.Nome} e o CPF é :{c.Cpf}");
            }

        }
        public static void SelecionarCliente()
        {
            clienteselecionado = "";
            string reset = clienteselecionado;

            ListarClientes();
            Console.WriteLine("Digite o cliente que você deseja selecionar");
            string selecao = Console.ReadLine();
            foreach (Cliente c in RedeLocadoras.Clientes)
            {
                if (c.Nome.Equals(selecao))
                {
                    clienteselecionado = c.Nome;
                    Console.WriteLine($"{c.Nome} foi selecionado com sucesso.");
                }

            }
            if (clienteselecionado == "")
            {
                Console.WriteLine($"Esse cliente: {selecao} não foi encontrado ou não existe!");
                clienteselecionado = reset;
            }
        }


         public static void IniciarAluguel()
        {
            bool search = false;

            string idveicalug;
            if(clienteselecionado == "")
            {
                Console.WriteLine("VOCE NECESSITA SELECIONAR UM CLIENTE");
                return;
            }
            if(locadoraselecionada ==  "")
            {
                Console.WriteLine("VOCE NECESSITA SELECIONAR UMA LOCADORA");
                return;
            }
            Lista:
            Locadora.ListarVeiculosDisponiveis(locadoraselecionada);

            Console.WriteLine("Digite o ID do veículo que você deseja alugar");
            idveicalug = Console.ReadLine();
            

            foreach(VeiculoAluguel veic in Locadora.VeiculosAluguel)
            {


                if (veic.Id.Equals(idveicalug))
                {
                    if (veic.Alugado == false)
                    {
                        search = true;
                        if (veic.Tipo == "Carro")
                        {
                            Console.WriteLine($"ID DO carro é: {veic.Id}" +
                                $" a placa dele é {veic.Placa}" +
                                $" ele é do tipo: {veic.Tipo}" +
                                $" sua quilometragem é de : {veic.Quilometragem}" +
                                $" é da marca: {veic.Marca}" +
                                $" é do modelo: {veic.Modelo}" +
                                $" ele está disponivel para ser alugado");
                        }
                        if (veic.Tipo == "Avião")
                        {
                            Console.WriteLine($"O ID do veículo é: {veic.Id}" +
                                $"Ele é do tipo: {veic.Tipo}" +
                                $"Horas de voo: {veic.Horasvoo}" +
                                $"Ele é da marca: {veic.Marca}" +
                                $"Ele é do modelo: {veic.Modelo}" +
                                $"E ele está disponivel para ser alugado");
                        }
                        veiculoselecionado = veic.Id;
                        Console.WriteLine("Por quantos dias deseja alugar o veículo");
                        int diasalug = int.Parse(Console.ReadLine());
                        var today = DateTime.Now;
                        var DiasDoAluguel = today.AddDays(diasalug);
                        Locadora.AlugueisAtuais.Add(new Aluguel(veic.Id, clienteselecionado, locadoraselecionada, today, DiasDoAluguel));

                        Console.WriteLine($"---------------------" +
                            $"O aluguel foi finalizado!" +
                            $"O aluguel foi feito pelo {clienteselecionado}" +
                            $"na locadora {locadoraselecionada}" +
                            $"ele começa na data {today}" +
                            $"e tem que ser devolvido na data {DiasDoAluguel}");
                        veic.Alugado = true;
                    }
                
                }
                if (search == false)
                {
                    Console.WriteLine($"NÃO FOI ENCONTRADO OU NÃO EXISTE ESSE VEÍCULO NA {locadoraselecionada}");
                    goto Lista;
                        
                }
            }

        }
        public static void DevolverVeiculo()
        {
            ListarAlugueis();
            Devolução:
            string iddevolucao = "";

            Console.WriteLine("Digite o ID do aluguel que você que devolver: ");
            iddevolucao = Console.ReadLine();
            bool search = false;

            foreach (Aluguel alu in Locadora.AlugueisAtuais)
            {
                if (alu.Id.Equals(iddevolucao))
                {
                    Console.WriteLine($"O Aluguel de id: {alu.Id} foi devolvido para a {alu.Locadora}");
                    foreach (VeiculoAluguel v in Locadora.VeiculosAluguel)
                    {
                        if (v.Id.Equals(iddevolucao))
                        {
                            v.Alugado = false;
                            alu.Desativado = true;
                            alu.Id = "0";
                        }
                    }
                    search = true;
                }

            }
            if (search == false)
            {
                Console.WriteLine($"Nenhum aluguel com esse ID foi encontrado");
                goto Devolução;
            }
        }
        public static void ListarAlugueis()
        {
            Console.WriteLine("Esses são os alugueis cadastrados no momento");
            foreach(Aluguel alu in Locadora.AlugueisAtuais)
            {
                foreach(VeiculoAluguel veic in Locadora.VeiculosAluguel)
                {
                    if (veic.Id.Equals(alu.Id))
                    {
                        if(veic.Alugado = true | alu.Desativado == false)
                        {
                            Console.WriteLine($"O id do aluguel é : {alu.Id}\n" +
                                $"Veículo: {veic.Marca} {veic.Modelo}\n" +
                                $"O cliente que alugou foi: {alu.Cliente}\n" +
                                $"Foi locado pela locadora: {alu.Locadora}\n" +
                                $"---------------------------------------" +
                                $"O aluguel começa no dia: {alu.Inicio}\n" +
                                $"e tem que ser devolvido no dia: {alu.Final}");
                        }
                    }
                }
            }
        }

        public static void AluguelPorCliente()
        {
            
            ListarClientes();
            Console.WriteLine("Qual dos clientes você deseja listar");
            string cselecionado = Console.ReadLine();
            int cont = 0;
            bool search = false;

            foreach (Cliente c in RedeLocadoras.Clientes)
            {
                if (c.Nome.Equals(cselecionado))
                {
                    search = true;
                }
            }
            foreach (Aluguel a in Locadora.AlugueisAtuais)
            {
                if (a.Cliente.Equals(cselecionado))
                {
                    search = true;
                    Console.WriteLine($"ID Aluguel: {a.Id}" +
                        $"Foi alugado pelo cliente: {a.Cliente}" +
                        $"Começa no dia: {a.Inicio}" +
                        $"Finaliza no dia: {a.Final}");
                    cont++;
                }
            }
            if (search = false)
            {
                Console.WriteLine("Esse cliente não foi encontrado no sistema");
                return;
            }
            if (cont == 0)
            {
                Console.WriteLine($"Não foi encontrado nenhum aluguel no nome {cselecionado}");
            }
        }

    }


        




    }

