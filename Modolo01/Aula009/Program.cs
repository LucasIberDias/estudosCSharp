namespace Aula009;

class Program
{
    static void Main(string[] args)
    {
        //Conversões

        //Classe converte
        string texto = "123";
        int numero = Convert.ToInt32(texto);
        Console.WriteLine(numero);

        //Metodo Parse
        string texto2 = "456";
        int numero2 = int.Parse(texto2);

        //Entradas do usuario
        Console.WriteLine("Insira um número:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O número inserido + 10 é: {n+10}");
    }
}
