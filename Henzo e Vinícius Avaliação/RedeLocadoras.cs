using System;
using System.Collections.Generic;
using System.Text;

namespace Henzo_e_Vinícius_Avaliação
{
    class RedeLocadoras
    {
        private static string _nome;
        public static string Nome { get => _nome; set => _nome = value; }
        private static List<Cliente> _clientes = new List<Cliente>();
        public static List<Locadora> Locadoras { get => _locadoras; private set => _locadoras = value; }
        private static List<Locadora> _locadoras = new List<Locadora>();
        public static List<Cliente> Clientes { get => _clientes; private set => _clientes = value; }

        public static void AdicionarLocadora(Locadora loc)
        {
            Locadoras.Add(loc);
        }
        public static bool RemoverLocadora(string Nome)
        {
            foreach (Locadora loc in Locadoras)
            {
                if (loc.Nome.Equals(Nome))
                {
                    Locadoras.Remove(loc);
                    return true;
                }
            }
            return false;
        }
        public static void ListarLocadoras()
        {
            if (Locadoras.Count == 0)
            {
                
                Console.WriteLine("Voce ainda não adicionou nenhuma locadora");
                
            }
            else
            { 
                foreach (Locadora loc in Locadoras)
                {
                    
                    Console.WriteLine($"O Nome da locadora é: {loc.Nome} e o  endereço da locadora é : {loc.Endereço}");
                    
                }

                Console.WriteLine("");
            }
        }
    }
}
