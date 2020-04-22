using System;
using System.Globalization;

namespace ExFixacaoAula18
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 550.50;
            double medida = 53.234567;
            double conta = Math.Pow(5, 2);

            System.Console.WriteLine("Produtos:");
            System.Console.WriteLine($"{produto1} cujo preco e ${preco1:F2}");
            System.Console.WriteLine($"{produto2} cujo preco e ${preco2:F2}");
            System.Console.WriteLine();
            System.Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            System.Console.WriteLine();
            System.Console.WriteLine($"Medida com oito casas decimais: {medida}");
            System.Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            System.Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
            System.Console.WriteLine();
            System.Console.WriteLine($"CONTA: {conta}");

            System.Console.WriteLine("Testando o git para realização de versionamentos");

        }
    }
}