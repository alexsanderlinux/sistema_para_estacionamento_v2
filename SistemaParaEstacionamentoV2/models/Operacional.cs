using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaParaEstacionamentoV2.models
{
    public class Operacional
    {
        public List<string> listaCarros = new List<string>();

        public Carro novoCarro = new Carro();
        
        public class Carro
        {
            public string Dono { get; set; }
            public string Marca { get; set; }
            public string Cor {get; set; }
            public string Placa { get; set; }
            public string Modelo { get; set; }
            public string Tipo { get; set; }  
            public string Vaga { get; set; }
               
        }

        public void CadastrarNovoVeiculo()
        {
                     
            Console.WriteLine("1 - Inserir nome do dono:");
            novoCarro.Dono = Console.ReadLine();
            Console.WriteLine("2 - Inserir a marca:");
            novoCarro.Marca = Console.ReadLine();
            Console.WriteLine("3 - Inserir a cor:");
            novoCarro.Cor = Console.ReadLine();
            Console.WriteLine("4 - Inserir a placa: ");
            novoCarro.Placa = Console.ReadLine();
            Console.WriteLine("5 - Inserir o modelo: ");
            novoCarro.Modelo = Console.ReadLine();        
            Console.WriteLine("6 - Inserir o tipo: ");
            novoCarro.Tipo = Console.ReadLine();
            Console.WriteLine("7 - Inserir o vaga: ");
            novoCarro.Vaga = Console.ReadLine();
            listaCarros.Add($"{novoCarro.Dono},{novoCarro.Marca},{novoCarro.Cor},{novoCarro.Placa},{novoCarro.Modelo},{novoCarro.Tipo},{novoCarro.Vaga}");

        }



        public void ListarVeiculos()
        {
            for (int i = 0; i < listaCarros.Count; i++)
            {
                Console.WriteLine($"Dados do carro: {listaCarros[i]}");
                
            }
        }

        public void RetiradaDeVeiculo()
        {
            

            Console.WriteLine("Digite o codigo de referencia do veiculo...");
            string recVaga = Console.ReadLine();
            int convRecuperaVaga = Convert.ToInt32(recVaga);
            


                for (int i = 0; i < listaCarros.Count; i++)
                {
                    if(i == convRecuperaVaga)
                    {
                        listaCarros.RemoveAt(convRecuperaVaga);
                    }
                }
            
            
            
        }

        
    }
}