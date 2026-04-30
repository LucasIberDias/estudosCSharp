namespace Aula006;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string file = @"C:\Users\Agrícola Andreis\Documents\estudosCSharp\TopicosAvancadosII\Testes\Texto.txt";
        System.Console.WriteLine(File.ReadAllText(file));;

        string []linhas = File.ReadAllLines(file);

        //Write
        StreamWriter escritor = new StreamWriter(file);

        escritor.WriteLine("Qualquer coisa fih");

        escritor.Close();

    }

}
