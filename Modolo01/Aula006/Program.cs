namespace Aula006;

class Program
{
    static void Main(string[] args)
    {
        //Operadores Aritméticos:
        // + - / * %
        int n1 = 5;
        int n2 = 5;

        int som = n1 + n2;
        int sub = n1 - n2;
        int div = n1 / n2;
        int mul = n1 * n2;
        int mod = n1 % n2;

        //Concatenação
        Console.WriteLine("Valor soma: "+som);

        //Placeholders
        Console.WriteLine("Divisão Inteira: {0} Resto de divisão: {1}",div,mod);

        //Interpolação de strings
        Console.WriteLine($"Valor Subtração: {sub}  Valor Multiplicação: {mul}");

    }
}
