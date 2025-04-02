using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentFundamentosCSharp.Exercicio10
{
    class JogoAdivinhacao
    {
        public void Main()
        {
            Random random = new Random();
            int numSecreto = random.Next(1, 51);  // Gera numero aleatório entre 1 e 50
            int tentativas = 5;

            Console.WriteLine("Tente adivinha um numero entre 1 e 50");
            while (tentativas > 0)
            {
                Console.WriteLine($"Voce tem {tentativas} tentativas");
                int num;
                while (true)
                {
                    Console.Write("\nDigite um numero: ");

                    if (!int.TryParse(Console.ReadLine(), out num))
                    {
                        Console.WriteLine("Entrada inválida, insira um numero válido.");
                        continue; 
                    }
                    break; 
                }

                if (num < 1 || num > 50)
                {
                    Console.WriteLine("O numero deve ser entre 1 e 50");
                    continue;
                }

                if (num == numSecreto)
                {
                    Console.WriteLine("Parabens! Voce adivinhou o numero!");
                    break;
                }

                else if (num < numSecreto)
                {
                    Console.WriteLine("O numero secreto é maior. Tente novamente.");
                }
                else
                {
                    Console.WriteLine("O nnmero secreto é menor. Tente novamente.");
                }

                tentativas --;

            }

            if (tentativas == 0)
            {
                Console.WriteLine("Suas tentativas acabaram. O numero secreto era " + numSecreto);
            }
        }
    }
}
