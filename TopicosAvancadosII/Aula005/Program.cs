namespace Aula005;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string file = @"C:\Users\Agrícola Andreis\Documents\estudosCSharp\TopicosAvancadosII\Testes\Texto.txt";
        string file2 = @"C:\Users\Agrícola Andreis\Documents\estudosCSharp\TopicosAvancadosII\Testes\Outro.txt";
        //File.Create(file);
        //File.Copy(file, file2);
        File.Delete(file2);
    }
}
