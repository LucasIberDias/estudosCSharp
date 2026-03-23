namespace Aula014;

class Program
{
    static void Main(string[] args)
    {
        Metodo(10);
    }
    static void Metodo(int n1)
    {
        if(n1 > 0)
        {
            System.Console.WriteLine(n1);
            n1--;
            
            Metodo(n1);
        }
    }
}
