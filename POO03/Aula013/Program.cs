namespace Aula013;

class Program
{
    static void Main(string[] args)
    {
        op del1 = new op(Operations.Soma);

        int res = del1(10,20);

        System.Console.WriteLine(res);
    }
}

delegate int op(int n1, int n2);

class Operations{
    public static int Soma(int n1, int n2)
    {
        return n1 + n2;
    }

    public static int Sub(int n1, int n2)
    {
        return n1 - n2;
    }
}
