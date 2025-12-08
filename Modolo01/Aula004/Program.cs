using System;

class Program
{
    static void Main(string[] args)
    {
        //Tipos de dados inteiros
        //3 tipos: short -> int -> long | Estes possuem sinais + - 
        //3 tipos: ushort -> uint -> ulong | Não possuem sinais + -

        short n1 = -20;
        int n2 = 30;
        long n3 = 40l;

        ushort n4 = 20;
        uint n5 = 30u;
        ulong n6 = 40ul;

        int tamanho = sizeof(int);//retorna o tamanho em bytes
        Console.WriteLine(tamanho);
    }
}