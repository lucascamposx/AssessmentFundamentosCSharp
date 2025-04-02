using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;

namespace AssessmentFundamentosCSharp.Exercicio09
{
    class ControleDeEstoque
    {
        public void Main()
        {
            string path = @"C:\Users\Lucas\source\repos\AssessmentFundamentosCSharp\AssessmentFundamentosCSharp\Exercicio09\estoque.txt";
            //string path = "estoque.txt";

            int quantidadeProdutos = 0;
            if (File.Exists(path))
            {
                quantidadeProdutos = File.ReadLines(path).Count();
            }

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Inserir Produto");
                Console.WriteLine("2. Listar Produtos");
                Console.WriteLine("3. Sair");
                Console.Write("\nEscolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        if (quantidadeProdutos < 5)
                        {
                            Console.Write("Nome do produto: ");
                            string nome = Console.ReadLine();
                            Console.Write("Quantidade em estoque: ");
                            int quantidade = int.Parse(Console.ReadLine());
                            Console.Write("Preço unitário: ");
                            double preco = double.Parse(Console.ReadLine());

                            string texto = $"{nome},{quantidade},{preco}"; ;

                            // Caso o Arquivo nao exista, cria e adiciona uma linha
                            if (!File.Exists(path))
                            {
                                try
                                {
                                    using (StreamWriter writer = new StreamWriter(path))
                                    {
                                        writer.WriteLine(texto);
                                    }
                                }
                                catch (IOException ioEx)
                                {
                                    Console.WriteLine($"Erro ao criar o arquivo: {ioEx.Message}");
                                }
                            }
                            else
                            {
                                // Adiciona uma linha em um arquivo existente
                                try
                                {
                                    using (StreamWriter writer = File.AppendText(path))
                                    {
                                        writer.WriteLine(texto);
                                    }
                                }
                                catch (IOException ioEx)
                                {
                                    Console.WriteLine($"Erro ao adicionar no arquivo: {ioEx.Message}");
                                }
                            }

                            quantidadeProdutos++;
                            Console.WriteLine("Produto adicionado com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Limite Maximo de Produtos Atingidos");
                        }
                        break;

                    case "2":
                        if (File.Exists(path) && File.ReadLines(path).Count() > 0)
                        {
                            using (StreamReader reader = new StreamReader(path))
                            {
                                string linha;
                                while ((linha = reader.ReadLine()) != null)
                                {
                                    string[] dados = linha.Split(',');
                                    Console.WriteLine($"Produto: {dados[0]} | Quantidade: {dados[1]} | Preço: {dados[2]:F2}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Arquivo de estoque não encontrado.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Encerrando programa...");
                        return;

                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;

                }
            }
                
        }
    }

}
