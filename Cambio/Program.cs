using System;

namespace Cambio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definição de variáveis 
            double valorParaConverter, conversao;
            int nomeMoeda1, nomeMoeda2;

            // Dólar, Iene, Euro, Real
            double[] fatoresConversaoInicio = {1, 0.0066, 1.06, 0.2};
            double[] fatoresConversaoFinal = {1, 151.35, 0.95, 5.04};

            //Entrada dos dados
            Console.WriteLine("Digite a primeira moeda:");
            nomeMoeda1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda moeda:");
            nomeMoeda2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor para conversão:");
            valorParaConverter = double.Parse(Console.ReadLine());

            // Verifica se a moeda é dólar e realiza as conversões
            conversao = (fatoresConversaoInicio[nomeMoeda1-1] 
                * valorParaConverter * fatoresConversaoFinal[nomeMoeda2-1]);

            // Saida
            Console.WriteLine("O resultado da conversão é: " + conversao);
        }
    }
}
