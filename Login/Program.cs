using System;
using System.Text.RegularExpressions;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * Programa que calcula a idade de uma pessoa e 
             * mostra se ela é maior de idade ou não
             */

            string senha;
            int quantidadeCaracteres;
            bool temLetraMaiuscula;
            bool temLetraMinuscula;
            bool temLetraCaractereEspecial;
            bool temNumero;

            // Entrada dos dados
            Console.WriteLine("Digite sua senha");
            senha = Console.ReadLine();

            // Verifica a quantidade e caracteres
            quantidadeCaracteres = senha.Length;

            // Verificação das regras de negócios
            temLetraMaiuscula = Regex.IsMatch(senha, "^(?=.*[A-Z])");
            temLetraMinuscula = Regex.IsMatch(senha, "^(?=.*[a-z])");
            temLetraCaractereEspecial = Regex.IsMatch(senha, "^(?=.*[!#@$%&])");
            temNumero = Regex.IsMatch(senha, "^(?=.*[0-9])");

            // Saída do programa
            if (quantidadeCaracteres >= 8) {
                if (!temLetraMaiuscula)
                {
                    Console.WriteLine("\nO programa precisa ter uma letra maiúscula\n");
                } else if (!temLetraMinuscula)
                {
                    Console.WriteLine("\nO programa precisa ter uma letra minúscula\n");
                } else if (!temLetraCaractereEspecial)
                {
                    Console.WriteLine("\nO programa precisa ter um caractere especial\n");
                } else if (!temNumero)
                {
                    Console.WriteLine("\nO programa precisa ter um número\n");
                } else
                {
                    Console.WriteLine("\nA senha foi aceita!\n");
                }
            } else {
                Console.WriteLine("\nA senha tem mais que 8 caracteres\n");
            }
        }
    }
}
