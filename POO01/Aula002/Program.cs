using System.Runtime.InteropServices;

namespace Aula002;

class Program
{
    static void Main(string[] args)
    {
        Soma(10,10);
        Subtracao(10,10);
    }

    static void Soma(int valor1, int valor2)
    {
        int soma = valor1 + valor2;
        System.Console.WriteLine($"A soma de {valor1} com {valor2} é igual á {soma}");
    }

    static void Subtracao(int valor1, int valor2)
    {
        int subtracao = valor1 - valor2;
        System.Console.WriteLine($"A subtração de {valor1} pelo valor {valor2} é igual á {subtracao}");
    }
}
