using System;
using System.Collections.Generic;
using System.Text;

namespace Henzo_e_Vinícius_Avaliação
{
    class Locadora
    {
        private string _nome;
        public string Nome { get => _nome; set => _nome = value; }
        private string _endereço;
        public string Endereço { get => _endereço; set => _endereço = value; }
        private static List<VeiculoAluguel> _veiculosAluguel = new List<VeiculoAluguel>();
        public static List<VeiculoAluguel> VeiculosAluguel { get => _veiculosAluguel; set => _veiculosAluguel = value; }
        private static List<Aluguel> _AlugueisAtuais = new List<Aluguel>();
        public static List<Aluguel> AlugueisAtuais { get => _AlugueisAtuais; set => _AlugueisAtuais = value; }





        public Locadora (string nome, string endereço)
        {
            Nome = nome;
            Endereço = endereço;
        }

        public static void ListarTodosOsVeículos(string Locadora)
        {
            Console.WriteLine("");
            Console.WriteLine($"Todos os veículos em {Locadora}");
            Console.WriteLine("");
            foreach (VeiculoAluguel v in VeiculosAluguel)
            {
                if (v.Locadora == Locadora)
                {
                    if (v.Tipo == "Carro")
                    {
                        string AlugadoCarro = "";
                        if (v.Alugado) AlugadoCarro = "Alugado"; else AlugadoCarro = "Disponível";
                        Console.WriteLine($"ID: {v.Id} | Tipo: {v.Tipo} | Placa: {v.Placa} | Quilometragem: {v.Quilometragem} | Marca: {v.Marca} | Modelo: {v.Modelo} | Situação: {AlugadoCarro}");
                    }
                    if (v.Tipo == "Avião")
                    {
                        string AlugadoAvião = "";
                        if (v.Alugado) AlugadoAvião = "Alugado"; else AlugadoAvião = "Disponível";
                        Console.WriteLine($"ID: {v.Id} | Tipo: {v.Tipo} | Horas de Voo: {v.Horasvoo} | Marca: {v.Marca} | Modelo: {v.Modelo} | Situação: {AlugadoAvião}");
                    }
                }

            }
        }

        public static void ListarVeiculosDisponiveis(string Locadora)
        {
            Console.WriteLine("");
            Console.WriteLine($"Veiculos diponíveis em {Locadora}");
            Console.WriteLine("");

            foreach (VeiculoAluguel v in VeiculosAluguel)
            {
                if (v.Locadora == Locadora)
                {
                    if (v.Tipo == "Carro")
                    {
                        if (!v.Alugado) Console.WriteLine($"ID: {v.Id} | Tipo: {v.Tipo} | Placa: {v.Placa} | Quilometragem: {v.Quilometragem} | Marca: {v.Marca} | Modelo: {v.Modelo} | Situação: Disponível");
                    }
                    if (v.Tipo == "Avião")
                    {
                        if (!v.Alugado) Console.WriteLine($"ID: {v.Id} | Tipo: {v.Tipo} | Horas de Voo: {v.Horasvoo} | Marca: {v.Marca} | Modelo: {v.Modelo} | Situação: Disponível");
                    }
                }

            }

            
           

            

        }
        public static void ListarCarrosDisponiveis(string Locadora)
        {
            Console.WriteLine("");
            Console.WriteLine($"Carros disponíveis em: {Locadora}");
            Console.WriteLine("");
            foreach (VeiculoAluguel v in VeiculosAluguel)
            {
                if (v.Locadora == Locadora)
                {
                    if (v.Tipo == "Carro")
                    {
                        if (!v.Alugado) Console.WriteLine($"ID: {v.Id} | Tipo: {v.Tipo} | Placa: {v.Placa} | Quilometragem: {v.Quilometragem} | Marca: {v.Marca} | Modelo: {v.Modelo} | Situação: Disponível");
                    }
                }
            }
        }
        public static void ListarAviõesDisponiveis(string Locadora)
        {
            Console.WriteLine("");
            Console.WriteLine($"Aviões disponíveis em: {Locadora}");
            Console.WriteLine("");
            foreach (VeiculoAluguel v in VeiculosAluguel)
            {
                if (v.Locadora == Locadora)
                {
                    if (v.Tipo == "Avião")
                    {
                        if (!v.Alugado) Console.WriteLine($"ID: {v.Id} | Tipo: {v.Tipo} | Horas de Voo: {v.Horasvoo} | Marca: {v.Marca} | Modelo: {v.Modelo} | Situação: Disponível");
                    }
                }

            }
        }
        public void AdicionarVeiculoAluguel(VeiculoAluguel a)
        {
            VeiculosAluguel.Add(a);
        }


    }
}
