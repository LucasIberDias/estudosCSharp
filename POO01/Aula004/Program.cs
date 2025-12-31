namespace Aula004;

class Program
{
    static void Main(string[] args)
    {
        int n1 = 20;
        Somar(ref n1);
        System.Console.WriteLine(n1);
    }

    static void Somar(ref int valor)
    {
        valor++;
    }
}
