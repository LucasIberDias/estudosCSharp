namespace Aula004;

class Program
{
    static void Main(string[] args)
    {
        string pastas = @"C:\Users\Agrícola Andreis\Documents\estudosCSharp\TopicosAvancadosII\Aula001";
        var files = Directory.GetFiles(pastas, "*", SearchOption.TopDirectoryOnly);

        foreach(string file in files)
        {
            var info = new FileInfo(file);
            System.Console.WriteLine(file.Length);
        }

        System.Console.WriteLine();

        bool existencia = Directory.Exists(pastas);
        System.Console.WriteLine(existencia);
    }
}
