namespace Aula009;

class Program
{
    static void Main(string[] args)
    {
        Classe2 obj = new Classe2();

        obj.M1();
    }
}

abstract class Classe1
{
    //Não pode ter objeto
    public int n1 = 10;
    abstract public void M1();
}

class Classe2 : Classe1
{
    public override void M1()
    {
        System.Console.WriteLine("Olá, Mundo!");
    }
}

