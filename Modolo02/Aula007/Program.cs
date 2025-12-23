namespace Aula007;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("[1] Opção 1");
        Console.WriteLine("[2] Opção 2");
        Console.WriteLine("[3] Opção 3");

        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
            Console.WriteLine("Você escolheu a opção 1");
            break;

            case 2:
            Console.WriteLine("Você escolheu a opção 2");
            break;

            case 3:
            Console.WriteLine("Você escolheu a opção 3");
            break;

            default:
            Console.WriteLine("Isto não é uma opção");
            break;
        }
    }
}
