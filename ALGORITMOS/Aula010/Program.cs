namespace Aula010;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> fila = new Queue<int>();

        fila.Enqueue(10);
        fila.Enqueue(20);
        fila.Enqueue(30);
        fila.Dequeue();

        foreach (var item in fila)
        {
            System.Console.WriteLine(item);
        }
    }
}
