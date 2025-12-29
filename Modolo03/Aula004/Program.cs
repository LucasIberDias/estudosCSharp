namespace Aula004;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        //do while é uma estrutura de repetição que primeiro realiza a sua função e depois faz o teste lógico
        //enquanto os outros primeiro realizar o teste logico
        do
        {
            i++;
            System.Console.WriteLine(i);
        }while(i < 10);
    }
}
