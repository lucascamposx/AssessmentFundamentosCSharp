using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentFundamentosCSharp.Exercicio06
{
    class CadastroDeAlunos
    {
        public string nome;
        public string matricula;
        public string curso;
        public double mediaNotas;

        // Metodo para Exibir dados do Aluno
        public void ExibirDados()
        {
            Console.WriteLine("Dados do Aluno:");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("matricula: " + matricula);
            Console.WriteLine("curso: " + curso);
            Console.WriteLine("mediaNotas: " + mediaNotas);
        }

        // Metodo para para verificar se o Aluno foi aprovado ou reprovado
        public string VeirificarAprovacao()
        {
            return mediaNotas >= 7 ? "Aprovado" : "Reprovado";
        }

        public void Main()
        {
            // Criando Objeto aluno da classe CadastroDeAlunos
            CadastroDeAlunos aluno = new CadastroDeAlunos
            {
                nome = "Lucas Campos de Franca",
                matricula = "L21492",
                curso = "Engenharia de Software",
                mediaNotas = 8.5
            };

            aluno.ExibirDados();

            Console.WriteLine("\nO Aluno foi " + aluno.VeirificarAprovacao());
        }
    }
}
