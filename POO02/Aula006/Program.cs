namespace Aula006;

class Program
{
    static void Main(string[] args)
    {
        classe2 objeto = new classe2();
        System.Console.WriteLine(objeto.soma(20, 30));
        System.Console.WriteLine(objeto.soma(20, 30, 50));
    }
}

class classe2
{
    public int soma(int n1, int n2)
    {
        return n1 + n2;
    }

        public int soma(int n1, int n2, int n3)
    {
        return n1 + n2 + n3;
    }
}