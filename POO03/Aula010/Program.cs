namespace Aula010;

class Program
{
    static void Main(string[] args)
    {
        Classe2 obj = new Classe2();

    }
}

public interface iClasse
{
    //Métodos não são impementados e não pode ter propriedades

    void Metodo1();
    void Metodo2();
}

class Classe1 : iClasse
{
    public void Metodo1()
    {
        System.Console.WriteLine("Olá, Mundo!");
    }

    public void Metodo2()
    {
        
    }
}
