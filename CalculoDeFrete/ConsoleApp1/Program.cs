//Vamos criar um programa que receba a distância entre o distribuidor e o local de entrega e calcule o valor do frete, sendo que para km é cobrado R$ 0,10
//A cada 200 km, deve adicionar uma taxa de R$ 1,00
//A cada 1000 km, deve adicionar uma taxa de R$ 10,00
//Agora precisamos calcular o frete baseado no preço da encomenda
//O valor do frete não altera para produtos com até 5kg
//Multiplicar o valor do frete para produtos entre 5kg até 25kg em 5x
//Multiplicar o valor do frete para produtos entre 25kg até 75kg em 3x

using System;

namespace CalcularFrete
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual a distância que o produto percorrerá (em KM):");
            int distancia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o peso do produto (em kg):");
            int peso = Convert.ToInt32(Console.ReadLine());

            double valorFrete = CalcularFrete(distancia, peso);

            Console.WriteLine($"O valor do frete para a distância de {distancia} km é de R$ {valorFrete:F2}.");
        }

        public static double CalcularFrete(int distancia, int peso)
        {
            double valorFrete = distancia * 0.10;
            valorFrete += (distancia / 200) * 1.00;
            valorFrete += (distancia / 1000) * 10.00;

            if (peso >= 5 && peso <= 25)
                valorFrete *= 5;
            else if (peso > 25 && peso <= 75)
                valorFrete *= 3;

            return valorFrete;
        }
    }
}