namespace Aula003;

class Program
{
    static void Main(string[] args)
    {
        int resposta = Soma(10,25);
        System.Console.WriteLine(resposta);
    }

    static int Soma(int valor1, int valor2)
    {
        int soma = valor1 + valor2;
        return soma;
    }
}
