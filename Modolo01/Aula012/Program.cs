namespace Aula012;

class Program
{
    static void Main(string[] args)
    {
        // Classe math

        //Constantes
        Console.WriteLine(Math.PI);
        Console.WriteLine(Math.E);

        //Valor absoluto / módulo
        Console.WriteLine(Math.Abs(-10));

        //Valor máximo e minimo
        Console.WriteLine(Math.Max(10,20));
        Console.WriteLine(Math.Min(10,20));

        //Potencias e Raizes
        Console.WriteLine(Math.Pow(2,3));
        Console.WriteLine(Math.Sqrt(81));

        //Arredondamentos
        Console.WriteLine(Math.Round(3.5));
        Console.WriteLine(Math.Ceiling(3.5));
        Console.WriteLine(Math.Floor(3.5));

        //Logaritmo e exponencial
        Console.WriteLine(Math.Log(10));
        Console.WriteLine(Math.Log10(100));
        Console.WriteLine(Math.Exp(1));
    }
}
