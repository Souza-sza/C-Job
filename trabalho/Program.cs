using System.Globalization;
using System;
using System.Collections.Generic;
using trabalho.Entidades;

namespace trabalhador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o departamento: ");
            string dept = Console.ReadLine();

            Console.WriteLine("Dados do Trabalhador");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Nivel (Junior/Medio/Senior): ");
            TrabalhoNivel nivel = Enum.Parse<TrabalhoNivel>(Console.ReadLine());

            Console.Write("Salario base: ");
            double salario= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento d = new Departamento(dept);
            Trabalhador trabalhador = new Trabalhador(nome, nivel, salario, d);

            Console.Write("Quantos contratos vai ter ? ");
            int n = int.Parse(Console.ReadLine());  
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Dados #" + (i + 1) + " Digite: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor da hora: ");
                double ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());

                HoraContrato contrato = new HoraContrato(data, ValorHora, horas);
                trabalhador.AdicionarContrato(contrato);

            }
            Console.WriteLine("");
            Console.Write("Entre com o mes e ano pra caulcular os ganhos(MM/YYYY): ");
            string MesAno  = Console.ReadLine();
            int mes = int.Parse(MesAno.Substring(0, 2));
            int ano = int.Parse(MesAno.Substring(3));
            Console.WriteLine("Nome: "+ trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.Nome);
            Console.WriteLine("Salario total: " + MesAno + " : "+
                trabalhador.ganho(ano, mes).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}

