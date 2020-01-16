using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Veiculo.br.com.gft.model
{
    class veiculo
    {
        private string marca { get; set; }
        private string modelo { get; set; }
        private string placa { get; set; }
        private string cor { get; set; }
        private float km { get; set; }
        private bool isLigado { get; set; }
        private int listrosCombustivel { get; set; }
        private int velocidade { get; set; }
        private double preco { get; set; }


        public void Acelerar()
        {
            if (isLigado == true)
            {
                this.velocidade += 20;
                listrosCombustivel -= 1;
                Console.WriteLine("O Carro acelerou, Velocidade Atual: " + velocidade + " Kmp/H   #");

            } else
            {
                Console.WriteLine("O Carros está desligado                      #");
            }
                       
        }

        public void Abastecer(int qtnLitros)
        {
            if (this.listrosCombustivel <= 5)
            {
                this.listrosCombustivel += 5;
            } else
            {
                Console.WriteLine("Tanque cheio");
            }


        }

        public void Frear()
        {
            if (isLigado == true && this.velocidade > 0)
            {
                velocidade -= 20;
                Console.WriteLine("Você freou: " + velocidade + " Kmp/H                           #");
            } else
            {
                Console.WriteLine("Você está parado                              #");
            }
                       
        }

        public void Pintar(string cor)
        {
            Console.WriteLine("Azul");
        }

        public void Ligar()
        {
            if (isLigado == false)
            {
                isLigado = true;
                Console.WriteLine("O Carro ligou                                  #");
            } else
            {
                Console.WriteLine("o Carro ja está ligado");
            }
        }

        public void Desligar()
        {
            if (isLigado == true)
            {
                isLigado = false;
                Console.WriteLine("O Carro desligou                             #");
                Console.WriteLine("#############################################");
                velocidade = 0;
            }
            else
            {
                Console.WriteLine("O Carro já está Desligado");
            }
        }


    }
}
