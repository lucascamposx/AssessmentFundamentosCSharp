using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentFundamentosCSharp.Exercicio03
{
    class Calculadora
    {
        public void Main()
        {
            double num1;
            double num2;

            while (true)
            {
                Console.Write("Digite o primeiro numero: ");
                if (double.TryParse(Console.ReadLine(), out num1))
                    break;
                Console.WriteLine("\nErro: Insira um numero valido.");
            }

            while (true)
            {
                Console.Write("Digite o segundo numero: ");
                if (double.TryParse(Console.ReadLine(), out num2))
                    break;
                Console.WriteLine("\nErro: Insira um numero valido.");
            }

            Console.WriteLine("\nEscolha uma operação matematica: ");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");

            string opcao = Console.ReadLine();

            double Resultado;

            switch (opcao)
            {
                case "1" :
                    Resultado = num1 + num2;
                    Console.WriteLine("\nResultado: " + Resultado);
                    break;
                case "2":
                    Resultado = num1 - num2;
                    Console.WriteLine("\nResultado: " + Resultado);
                    break;
                case "3":
                    Resultado = num1 * num2;
                    Console.WriteLine("\nResultado: " + Resultado);
                    break;
                case "4":
                    if(num2 == 0)
                    {
                        Console.WriteLine("\nErro: Divisao por zero");
                        break;
                    }
                    Resultado = num1 / num2;
                    Console.WriteLine("\nResultado: " + Resultado);
                    break;
                default:
                    Console.WriteLine("\nDigito invalido, Digite um numero entre 1 e 4");
                    break;
            }

        }
    }
}
