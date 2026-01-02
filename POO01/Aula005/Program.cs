namespace Aula005;

class Program
{
    static void Main(string[] args)
    {
        int num1;
        Metodo1(out num1);
        System.Console.WriteLine(num1);
    }

    static void Metodo1(out int n1)
    {
        n1 = 20;
    }
}

//Out altera o valor do parametro sem precisar que a variavel tenha sido inicializada,
//enquanto o ref só consegue mudar o parametro se a variavel tiver sido inicializada