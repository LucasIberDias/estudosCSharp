namespace Aula004;

class Program
{
    static void Main(string[] args)
    {
        Classe2 obj = new Classe2();
        obj.Metodo();
    }
}

class Classe1
{
    public int n1 = 10;
    //private pode ser acessada apenas nela mesma
    private int n2 = 20;

    //protected faz com que a informação possa ser acesada apenas nela mesma, e em classes herdadas
    protected int n3 = 30;
}

class Classe2 : Classe1
{
    public void Metodo()
    {
        System.Console.WriteLine(n3);
    }
}

//Uma classe Sealed não pode ter herança e não pode ser derivada
sealed class Classe3{

}

class Classe3 : Classe1
{
    
}