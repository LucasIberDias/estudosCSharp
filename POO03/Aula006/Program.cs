namespace Aula006;

class Program
{
    static void Main(string[] args)
    {
        Classe1 obj = new Classe1();
        System.Console.WriteLine(obj[2]);
        obj[0] = 47;
        System.Console.WriteLine(obj[0]);
    }
}

class Classe1
{
    private int[] nums = new int[3]{10,20,30};

    public int this[int i] //indexador (i = indice)
    {
        get{return nums[i];}
        set{nums[i] = value;}
    }
}
