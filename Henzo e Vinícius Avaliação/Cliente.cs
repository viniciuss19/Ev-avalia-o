using System;
using System.Collections.Generic;
using System.Text;

namespace Henzo_e_Vinícius_Avaliação
{
    class Cliente
    {
        private string _nome;
        public string Nome { get => _nome; set => _nome = value; }
        private string _cpf;
        public string Cpf { get => _cpf; set => _cpf = value; }
        private static List<Aluguel> _alugueis;
        public static List<Aluguel> Alugueis { get => _alugueis; set => _alugueis = value; }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public void Alugar(VeiculoAluguel v, string Locadora, DateTime inicio, DateTime final)
        {
            Alugueis.Add(new Aluguel(v.Id, this.Nome, Locadora, inicio, final));
        }
    }
}
