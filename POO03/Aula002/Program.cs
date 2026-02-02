namespace Aula002;

class Program
{
    static void Main(string[] args)
    {
        Classe2 objeto = new Classe2();
    }
}

class Classe1
{
    public Classe1(int valor)
    {
        Console.WriteLine($"Construtor C1");
    }
}

class Classe2 : Classe1
{
    public Classe2() : base(10)
    {
        Console.WriteLine("Construtor C2");
    }
}
