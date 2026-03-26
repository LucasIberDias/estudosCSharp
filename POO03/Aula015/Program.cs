namespace Aula015;

class Program
{
    static void Main(string[] args)
    {
        int n1 = 10;
        int n2 = 0;

        //tenta
        try
        {
            System.Console.WriteLine(n1/n2);
        }
        catch
        {
            System.Console.WriteLine("Houve um erro ");
        }
        finally
        {
            System.Console.WriteLine("Fim do tratamento");
        }
    }
}

