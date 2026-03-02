namespace Aula008;

class Program
{
    static void Main(string[] args)
    {
        Classe1 obj = new Classe1();
        Classe2 obj2 = new Classe2();

        obj.Metodo();
        obj2.Metodo();
    }
}

class Classe1
{
    public virtual void Metodo()
    {
        System.Console.WriteLine("Olá, mundo!");    
    }
}

class Classe2 : Classe1
{
    //Override permite redefinir oq tem dentro de virtual
    public override void Metodo()
    {
        System.Console.WriteLine("Outra coisa!");
    }
}