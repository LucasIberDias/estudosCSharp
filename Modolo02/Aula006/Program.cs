namespace Aula006;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite algo:");
        string valorPassado = Convert.ToString(Console.ReadLine());

        if (valorPassado.GetType() == typeof(String))
        {
            Console.WriteLine("É uma string");
        }
        else
        {
            Console.WriteLine("Não é uma string");
        }
    }
}
