// See https://aka.ms/new-console-template for more information
//importação para por o ponto como separador decimal
using System.Globalization;
namespace SaidaDeDados {
    class Program
    {
        static void Main(string[] args) {
            // saida com quebra de linhas
            Console.WriteLine("Bom Dia");
            Console.WriteLine("Boa Tarde");
            Console.WriteLine("Boa Noite");

            //como imprimir variaveis
            char genero = 'f';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            //controlando casas decimais com double
            Console.WriteLine(saldo.ToString("F2"));
            // para por ponto
            Console.WriteLine(saldo.ToString("F2",CultureInfo.InvariantCulture));
            //placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais",nome,idade,saldo);
            //interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            //concatenação
            Console.WriteLine(nome + " tem " + idade + " anos " +" e tem saldo igual a " + saldo.ToString("F2",CultureInfo.InvariantCulture) + " reais " );


        }
    }

}

