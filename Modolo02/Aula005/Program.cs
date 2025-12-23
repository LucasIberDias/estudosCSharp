namespace Aula005;

class Program
{
    static void Main(string[] args)
    {
        inicio:
        Console.WriteLine("Digite um número: (0-10)");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero >= 0 && numero <= 10)
        {
            Console.WriteLine("Valor entregue");
        }
        else
        {
            Console.WriteLine("ERRO: VALOR INVÁLIDO");
            goto inicio;
        }
    }
}
