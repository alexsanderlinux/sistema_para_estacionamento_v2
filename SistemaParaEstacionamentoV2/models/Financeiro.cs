using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaParaEstacionamentoV2.models
{
    public class Financeiro
    {
        Operacional operacional = new Operacional();
        public decimal ResgatarValorEntrada = 0;
        public decimal ResgatarValorPorHora = 0;
        public decimal ResgatarPermanencia = 0;
        public decimal TotalCalculado = 0;

        public bool validaSaida = false;

        public void ResgatarValores()
        {
            Console.WriteLine("Gentileza informar o valor da entrada:");
            string valEntrada  = Console.ReadLine();
            this.ResgatarValorEntrada = Convert.ToDecimal(valEntrada);
            //Console.WriteLine(ResgatarValorEntrada);
            


            
            Console.WriteLine("Gentileza informar o valor por hora:");
            string valorPorHora  = Console.ReadLine();
            this.ResgatarValorPorHora = Convert.ToDecimal(valorPorHora);
            //Console.WriteLine(ResgatarValorPorHora);

           
        }

        //todo: validacao se existe veiculos para calcular valores
        public void CalcularValorTotal()
        {
            Console.WriteLine("Gentileza informar a permanencia do veiculo:");
            string valPermanencia  = Console.ReadLine();
            ResgatarPermanencia = Convert.ToDecimal(valPermanencia);
            this.TotalCalculado = this.ResgatarValorEntrada + (this.ResgatarValorPorHora * this.ResgatarPermanencia); 
            Console.WriteLine(this.TotalCalculado);
            validaSaida = true; 
            
        }
    }   

}