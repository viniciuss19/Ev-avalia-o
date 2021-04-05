using System;
using System.Collections.Generic;
using System.Text;

namespace Henzo_e_Vinícius_Avaliação
{
    class Aluguel
    {
        private string _id;
        public string Id { get => _id; set => _id = value; }
        private string _cliente;
        public string Cliente { get => _cliente; set => _cliente = value; }
        private string _locadora; 
        public string Locadora { get => _locadora; set => _locadora = value; }
        private DateTime _inicio;
        public DateTime Inicio { get => _inicio; set => _inicio = value; }
        private DateTime _final;
        public DateTime Final { get => _final; set => _final = value; }
        private bool desativado;
        public bool Desativado { get => desativado; set => desativado = value; }

        public Aluguel(string id, string cliente, string locadora, DateTime inicio, DateTime final)
        {
            Id = id;
            Cliente = cliente;
            Locadora = locadora;
            Final = final;
        }
        public bool Iniciar()
        {
            ConsoleLocadoras.IniciarAluguel();
            return true;
        }
        public bool Finalizar()
        {
            ConsoleLocadoras.DevolverVeiculo();
            return true;
        }

    }
}
