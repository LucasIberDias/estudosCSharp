namespace Aula002;

class Program
{
    static void Main(string[] args)
    {
        //Operadores lógicos
        bool exp = true && true; //AND e
        Console.WriteLine(exp);

        exp = true || false; //or ou
        Console.WriteLine(exp);


        exp = !true; //not não
        Console.WriteLine(exp);
    }
}
