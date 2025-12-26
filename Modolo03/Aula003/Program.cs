namespace Aula003;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        while (i <= 10)
        {
            if (i == 9)
            {
                break;
            }
            if (i % 2 == 1)
            {
                i++;
                continue;
            }
            System.Console.WriteLine(i);
            i++;
        }
    }
}
