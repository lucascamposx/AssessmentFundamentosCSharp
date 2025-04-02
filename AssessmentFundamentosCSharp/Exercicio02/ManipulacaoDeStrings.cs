using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentFundamentosCSharp.Exercicio02
{
    class ManipulacaoDeStrings
    {
        public void Main()
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            char[] nomeArray = nome.ToCharArray();

            foreach (char letra in nomeArray)
            {
                // Verifica se é letra, caso nao seja imprime o caractere
                if (Char.IsLetter(letra))
                {
                    // Verifica se a letra é maiúscula ou minúscula
                    if (Char.IsUpper(letra))
                    {
                        // Desloca a letra maiúscula
                        char letraDeslocada = (char)((letra - 'A' + 2) % 26 + 'A');
                        Console.Write(letraDeslocada);
                    }
                    else if (Char.IsLower(letra))
                    {
                        // Desloca a letra minúscula
                        char letraDeslocada = (char)((letra - 'a' + 2) % 26 + 'a');
                        Console.Write(letraDeslocada); 
                    }
                }
                else
                {
                    Console.Write(letra);
                }
            }
        }
    }
}
