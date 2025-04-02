using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentFundamentosCSharp.Exercicio12
{
    class GerenciadorContatos
    {
        public void Main()
        {
            string path = "contatos.txt";

            List<Contato> contatos = new List<Contato>();
            //CarregarContatos(contatos);

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Adicionar novo contato");
                Console.WriteLine("2. Listar contatos cadastrados");
                Console.WriteLine("3. Sair");
                Console.Write("\nEscolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarContato(path);
                        break;
                    case "2":
                        ExibirContatos(path);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }


        }

        private void AdicionarContato(string path) {

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
        }

        private void ExibirContatos(string path)
        {
            List<Contato> contatos = CarregarContatos(path);
            if (!contatos.Any())
            {
                Console.WriteLine("Nenhum contato cadastrado.");
                return;
            }

            Console.WriteLine("Escolha o formato de exibição:");
            Console.WriteLine("1. Markdown");
            Console.WriteLine("2. Tabela");
            Console.WriteLine("3. Texto Puro");
            Console.Write("Opção: ");
            string opcao = Console.ReadLine();

            ContatoFormatter formatter;

            switch (opcao)
            {
                case "1":
                    formatter = new MarkdownFormatter();
                    break;
                case "2":
                    formatter = new TabelaFormatter();
                    break;
                case "3":
                    formatter = new RawTextFormatter();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    return;
            }

            formatter.ExibirContatos(contatos);
        }

        private List<Contato> CarregarContatos(string path)
        {
            List<Contato> contatos = new List<Contato>();
            if (File.Exists(path) && File.ReadLines(path).Any())
            {
                foreach (var linha in File.ReadLines(path))
                {
                    var dados = linha.Split(',');
                    if (dados.Length == 3)
                    {
                        contatos.Add(new Contato(dados[0], dados[1], dados[2]));
                    }
                }
            }
            return contatos;
        }

    }
}
