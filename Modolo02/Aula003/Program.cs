namespace Aula003;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua idade:");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("Você já pode tirar carteira de motorista");
        }else
        {
            Console.WriteLine("Você não pode tirar carteira de motorista");
        }
        
    }
}
