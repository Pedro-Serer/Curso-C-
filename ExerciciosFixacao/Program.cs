using System;

namespace ExerciciosFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Programa que calcula a idade de uma pessoa e 
             * mostra se ela é maior de idade ou não
             */

            int anoAtual = DateTime.Now.Year;
            int? anoNascimento, idade;
            
            // Entrada de dados
            Console.WriteLine("Digite o seu ano de nascimento");
            anoNascimento = int.Parse(Console.ReadLine());

            idade = anoAtual - anoNascimento;

            //Saida
            Console.WriteLine("Você tem " + idade + " anos");

            // Verifica a idade
            if (idade < 18) {
                Console.WriteLine("e é de menor\n");
            } else {
                Console.WriteLine("e é de maior\n");
            }
        }
    }
}
