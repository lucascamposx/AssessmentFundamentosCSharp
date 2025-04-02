using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentFundamentosCSharp.Exercicio05
{
    class TempoParaConclusaoDoCurso
    {
        public void Main()
        {
            DateTime dataAtual;

            while (true)
            {
                Console.WriteLine("Digite a Data Atual: (dd/mm/aaaa)");

                if (DateTime.TryParse(Console.ReadLine(), out dataAtual))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nData Invalida, Tente Novamente");
                }
            };
           
            DateTime dataFormatura = new DateTime(2026, 12, 15);


            // Verifica se a data informada é no futuro
            if (dataAtual > DateTime.Now)
            {
                Console.WriteLine("Erro: A data informada não pode ser no futuro!");
                return;
            }

            // Verifica se a data de formatura ja passou
            if (dataAtual > dataFormatura)
            {
                Console.WriteLine("Parabéns! Você já deveria estar formado!");
                return;
            }

            int anos = dataFormatura.Year - dataAtual.Year;
            int meses = dataFormatura.Month - dataAtual.Month;
            int dias = dataFormatura.Day - dataAtual.Day;


            if ((dataFormatura.Month < dataAtual.Month) ||
                (dataFormatura.Month == dataAtual.Month && dataFormatura.Day < dataAtual.Day))
            {
                anos--;
            }

            if (meses < 0)
            {
                meses += 12;
            }

            if (dias < 0)
            {
                meses--;
                var ultimoMes = dataFormatura.AddMonths(-1);
                dias += DateTime.DaysInMonth(ultimoMes.Year, ultimoMes.Month);
            }

            Console.Write("Diferença: ");
            Console.Write(anos != 0 ? anos + " Anos " : "");
            Console.Write(meses != 0 ? meses + " Meses " : "");
            Console.Write(dias != 0 ? dias + " Dias" : "");
            Console.Write(" para sua formatura");

            // Verifica se falta menos de 6 meses para a formatura
            if (meses < 6 && anos == 0)
            {
                Console.WriteLine("\nA reta final chegou! Prepare-se para a formatura!");
            }

        }
    }
}

