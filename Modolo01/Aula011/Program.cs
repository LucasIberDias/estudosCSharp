namespace Aula011;

class Program
{
    static void Main(string[] args)
    {
        //Manipulação de String
        string texto = " Olá mundo ";

        //Maiusculas e minusculas
        Console.WriteLine(texto.ToUpper());
        Console.WriteLine(texto.ToLower());

        //Remover espaços
        Console.WriteLine(texto);
        Console.WriteLine(texto.Trim());

        //Obter e substituir
        Console.WriteLine(texto.Substring(1,3));
        Console.WriteLine(texto.Replace("mundo", "C#"));

        //Verificações bolleanas
        Console.WriteLine(texto.Contains("pão"));
        Console.WriteLine(texto.StartsWith(" O"));
        Console.WriteLine(texto.EndsWith(" "));
    }
}
