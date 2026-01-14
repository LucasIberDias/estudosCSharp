namespace Aula008;

class Program
{
    static void Main(string[] args)
    {
        //Static faz com que não precise de um objeto 
        System.Console.WriteLine(Felinos.ex1);
    }
}

public class Felinos
{
    static public int ex1 = 0;

    //private só usamos onde apenas usaremos ele na classe colocada
    static private int ex2 = 0;

}
