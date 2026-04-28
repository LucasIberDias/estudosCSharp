namespace Aula009;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> pilha = new Stack<int>();

        pilha.Push(10);
        pilha.Push(30);
        pilha.Push(20);

        foreach (var item in pilha)
        {
            Console.WriteLine(item);
        }

        pilha.Pop();
        System.Console.WriteLine(" ");

        foreach (var item in pilha)
        {
            Console.WriteLine(item);
        }
    }
}
