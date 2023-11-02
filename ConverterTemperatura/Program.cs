using System;

namespace ConverterTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Programa que calcula a idade de uma pessoa e 
             * mostra se ela é maior de idade ou não
             */

            double temperatura, conversao;
            int estaEmGrau = 1;
            string temperaturaIda, temperaturaVolta;

            // Entrada de dados
            Console.WriteLine("Digite a temperatura");
            temperatura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ela esta em graus?");
            estaEmGrau = int.Parse(Console.ReadLine());

            // Verificação da temperatura
            if (estaEmGrau == 1) {
                conversao = (temperatura * 9 / 5) + 32;
                temperaturaIda = "Cº";
                temperaturaVolta = "Fº";
            } else {
                conversao = (temperatura - 32) * 5 / 9;
                temperaturaIda = "Fº";
                temperaturaVolta = "Cº";
            }

            // Saida do programa
            Console.WriteLine(
                "A temperatura " + temperatura + temperaturaIda 
                + " é " + conversao + temperaturaVolta
            );
        }
    }
}
