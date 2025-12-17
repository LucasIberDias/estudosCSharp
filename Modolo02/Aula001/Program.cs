namespace Aula001;

class Program
{
    static void Main(string[] args)
    {
        //Operadores Relacionais
        int n1 = 5;
        int n2 = 10;

        bool v1 = n1 == n2; //Igualdade
        bool v2 = n1 != n2; //Diferentes

        bool v3 = n1 > n2; //Maior que
        bool v4 = n1 < n2; //Menor que

        bool v5 = n1 >= n2; //Maior que ou igual
        bool v6 = n1 <= n2; //Menor que ou igual

        Console.WriteLine($"{v1} {v2} {v3} {v4} {v5} {v6}");
    }
}
