using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");

            int idade = 35;
            int idadeDiogo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeDiogo);

            Console.ReadLine();
        }
    }
}
