using System;
using System.Collections.Generic;
using System.Text;
using Projeto_Veiculo.br.com.gft.model;
namespace Projeto_Veiculo.br.com.gft.main
{
    class main
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("#############################################");
            veiculo veiculo = new veiculo();
            veiculo.Acelerar();
            veiculo.Frear();
            veiculo.Ligar();
            veiculo.Acelerar();
            veiculo.Acelerar();
            veiculo.Frear();
            veiculo.Frear();
            veiculo.Desligar();
            Console.ReadLine();


        }
    }
}
