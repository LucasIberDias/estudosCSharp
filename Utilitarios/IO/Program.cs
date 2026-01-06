namespace IO;

class Program
{
    static void Main(string[] args)
    {
    }

    static int LerValorInteiro()
    {
        int valor = Convert.ToInt32(Console.ReadLine());
        return valor;
    }

    static void ImprimirVetor(int [] vetor)
    {
        foreach (int valores in vetor)
        {
            System.Console.WriteLine(valores);
        }
    }
}
