namespace Aula006;

class Program
{
    static void Main(string[] args)
    {
        int [] vetor = new int [10];

        vetor[0] = 2;
        vetor[4] = 56;

        for(int i = 0; i < vetor.Length; i++){
            if (vetor[i] != 0)
            {
                System.Console.WriteLine(vetor[i]);
            }
        }
    }
}
