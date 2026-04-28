namespace Aula007;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        LinkedList listaEncadeada = new LinkedList();
        listaEncadeada.AddFirst(10);
        listaEncadeada.AddFirst(20);
        listaEncadeada.AddLast(30);

        foreach (var item in listaEncadeada)
        {
            System.Console.WriteLine(item);
        }
    }
}
