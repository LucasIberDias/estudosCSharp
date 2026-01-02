namespace Aula006;

class Program
{
    static void Main(string[] args)
    {
        Metodo1(10,20,30,40,50);
    }

    static void Metodo1(params int [] numeros)
    {
        foreach (int n1 in numeros)
        {
            System.Console.WriteLine(n1);
        }
    }
}