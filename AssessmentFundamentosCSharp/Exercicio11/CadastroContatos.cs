using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentFundamentosCSharp.Exercicio11
{
    class CadastroContatos
    {
        public void Main()
        {
            string path = "contatos.txt";

            while (true)
            {
                Console.WriteLine("=== Gerenciador de Contatos ===");
                Console.WriteLine("1 - Adicionar novo contato");
                Console.WriteLine("2 - Listar contatos cadastrados");
                Console.WriteLine("3 - Sair");
                Console.Write("\nEscolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Telefone: ");
                        string telefone = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();

                        string contato = $"{nome},{telefone},{email}";

                        if (!File.Exists(path))
                        {
                            try
                            {
                                using (StreamWriter writer = new StreamWriter(path))
                                {
                                    writer.WriteLine(contato);
                                }
                            }
                            catch (IOException ioEx)
                            {
                                Console.WriteLine($"Erro ao criar o arquivo: {ioEx.Message}");
                            }
                        }
                        else
                        {
                            try
                            {
                                using (StreamWriter writer = File.AppendText(path))
                                {
                                    writer.WriteLine(contato);
                                }
                            }
                            catch (IOException ioEx)
                            {
                                Console.WriteLine($"Erro ao adicionar no arquivo: {ioEx.Message}");
                            }
                        }
                        Console.WriteLine("Contato cadastrado com sucesso!");
                        break;

                    case "2":
                        if (File.Exists(path) && File.ReadLines(path).Count() > 0)
                        {
                            using (StreamReader reader = new StreamReader(path))
                            {
                                Console.WriteLine("Contatos cadastrados:");
                                string linha;
                                while ((linha = reader.ReadLine()) != null)
                                {
                                    string[] dados = linha.Split(',');
                                    Console.WriteLine($"Nome: {dados[0]} | Telefone: {dados[1]} | Email: {dados[2]}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nenhum contato cadastrado.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Encerrando programa...");
                        return;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
