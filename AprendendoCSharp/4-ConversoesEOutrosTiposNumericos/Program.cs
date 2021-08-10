using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;

            Console.WriteLine(salario);

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            
            Console.WriteLine(salarioEmInteiro);

            // O long é uma variável 64 bits
            long idade;
            idade = 13000000000000000;

            Console.WriteLine(idade);

            // O short é um tipo de variável de 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 150;

            Console.WriteLine(quantidadeProdutos);
            
            // O f acrescentado ao final da variável é para indicar que realmente se trata de um float.
            float altura;
            altura = 1.80f;
            
            Console.WriteLine(altura);


            Console.ReadLine();
        }
    }
}
