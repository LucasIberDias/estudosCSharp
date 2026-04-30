namespace Aula003;

class Program
{
    static void Main(string[] args)
    {
        string pastas = @"C:\Users\Agrícola Andreis\Documents\estudosCSharp";

        string[] dirs = Directory.GetDirectories(pastas, "*", SearchOption.All);

        foreach(var dir in dirs)
        {
            System.Console.WriteLine(dir);
        }
    }
}
