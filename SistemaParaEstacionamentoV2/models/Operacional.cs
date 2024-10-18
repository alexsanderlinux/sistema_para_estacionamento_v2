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
            string dono = Console.ReadLine();
            novoCarro.Dono = dono; 
            Console.WriteLine("2 - Inserir a marca:");
            string marca = Console.ReadLine();
            novoCarro.Marca = marca;
            Console.WriteLine("3 - Inserir a cor:");
            string cor = Console.ReadLine();
            novoCarro.Cor = cor;
            Console.WriteLine("4 - Inserir a placa: ");
            string placa = Console.ReadLine();
            novoCarro.Placa = placa.ToUpper();
            int cont2 = 0;

            while(string.IsNullOrEmpty(placa))
            {
                Console.WriteLine("4 - ** o campo placa é obrigatorio** - Inserir a placa: ");
                placa = Console.ReadLine();
                novoCarro.Placa = placa.ToUpper();
                cont2++;
            }
            
            //recupera indice do veiculo cadastrado
            int index = listaCarros.FindIndex(a => a.Contains(novoCarro.Placa));
            
            //varre a lista para verificar se existe o indice cadastrado com a mesma placa
            for(int i = 0; i < listaCarros.Count; i++)
            {
                //se existir o indice o laço repetira a coleta da placa ate que o usuário informe uma placa diferente para que o cadastro seja concluido.
                if(index == i)
                {      
                    int cont = 0;
                    while(index==i)
                    {
                        Console.WriteLine("Este veiculo já está estacionado aqui...");   
                        Console.WriteLine("4 - Inserir a placa: ");
                        placa = Console.ReadLine();
                        novoCarro.Placa = placa.ToUpper();
                        index = listaCarros.FindIndex(a => a.Contains(novoCarro.Placa));
                        cont++;
                    }
                }
                
            }
            

            Console.WriteLine("5 - Inserir o modelo: ");
            string modelo = Console.ReadLine();
            novoCarro.Modelo = modelo;
            Console.WriteLine("6 - Inserir o tipo: ");
            string tipo = Console.ReadLine();
            novoCarro.Tipo = tipo;
            Console.WriteLine("7 - Inserir o vaga: ");
            string vaga = Console.ReadLine();
            novoCarro.Vaga = vaga;
            listaCarros.Add($"{novoCarro.Dono},{novoCarro.Marca},{novoCarro.Cor},{novoCarro.Placa},{novoCarro.Modelo},{novoCarro.Tipo},{novoCarro.Vaga}");           
        }
            
        //todo: validacao se existem veiculos para listar

        public void ListarVeiculos()
        {
            if (listaCarros.Any())
            {
                for (int i = 0; i < listaCarros.Count; i++)
                {
                    Console.WriteLine($"Dados do carro: {listaCarros[i]}");
                    
                }
            }    
            else
            {
                Console.WriteLine("Não há veiculos estacionados.");
            }
        }

        public void RetiradaDeVeiculo()
        {
            if(listaCarros.Any())
            {
                
                Console.WriteLine("Baixa no financeiro.");
                Console.WriteLine("Gentileza digitar a placa do veiculo...");
                string placa = Console.ReadLine();

                int index = listaCarros.FindIndex(a => a.Contains(placa.ToUpper()));
            
                for(int i = 0; i < listaCarros.Count; i++)
                {
                    if(index == i)
                    {      
                        listaCarros.RemoveAt(index);
                        Console.WriteLine($"Veiculo com a placa {placa} removido com êxito!");                        
                    }
                    
                }
            }
             else
            {
                Console.WriteLine("Não há veiculos estacionados para retirar.");
            }
            
        }        
    }
}