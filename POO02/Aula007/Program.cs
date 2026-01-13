namespace Aula007;

class Program
{
    static void Main(string[] args)
    {
        Classe1 objeto = new Classe1();
        objeto.Metodo();
    }
}

class Classe1
{
    public Clase2 Metodo()
    {
        return new Clase2();
    }
}

class Clase2
{
    public int numero1 = 20;
    public Clase2()
    {
        System.Console.WriteLine("Objeto criado!");
    }
}
