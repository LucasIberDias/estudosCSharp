namespace Aula005;

class Program
{
    static void Main(string[] args)
    {
        Classe1 obj = new Classe1();
        obj.Num = 30;
        System.Console.WriteLine(obj.Num);
    }
}

class Classe1
{
    private int num = 50;

    public int Num
    {
        get {return num;} //Chama o valor privado
        set { num = value;} //Altera o valor privado
    }
}

class Classe2
{
    private int vlr = 30;

    //Funciona da mesma maneira, mas sem deixar explicito 
    public int Vlr{get; set;}
}
