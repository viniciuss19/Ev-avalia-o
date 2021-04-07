using System;
using System.Collections.Generic;
using System.Text;

namespace Henzo_e_Vinícius_Avaliação
{
    class VeiculoAluguel
    {
        private string _id;
        public string Id
        {
            get => _id;
            set => _id = value;
        }
        private string _cliente;
        public string cliente
        {
            get => _cliente;
            set => _cliente = value;
        }

        private string _tipo;
        public string Tipo { get => _tipo; set => _tipo = value; }

        private string _marca;
        public string Marca { get => _marca; set => _marca = value; }
        private string _modelo;
        public string Modelo { get => _modelo; set => _modelo = value; }
        private bool _alugado;
        public bool Alugado { get => _alugado; set => _alugado = value; }

        private string _placa;
        public string Placa { get => _placa; set => _placa = value; }

        private float _horasvoo;
        public float Horasvoo { get => _horasvoo; set => _horasvoo = value; }

        private float quilometragem;
        public float Quilometragem { get => quilometragem; set => quilometragem = value; }

        private string _locadora;
        public string Locadora { get => _locadora; set => _locadora = value; }

        public VeiculoAluguel (string id, string locadora, string tipo, float horasvoo, string placa, float quilometragem, string marca, string modelo, bool alugado)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Alugado = alugado;
            Tipo = tipo;
            Horasvoo = horasvoo;
            Quilometragem = quilometragem;
            Placa = placa;
            Locadora = locadora;
        }
    }
}
