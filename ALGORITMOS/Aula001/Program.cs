namespace Aula001;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[5]{3,7,1,3,9};
        BubbleSort(vetor);

        foreach(var item in vetor)
        {
            System.Console.WriteLine(item);
        }
    }

    static void BubbleSort(int[] arr)
    {
        for(int i =0; i < arr.Length-1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j+1])
                {
                    int t = arr[j];
                    arr [j] = arr[j+1];
                    arr[j+1] = t;
                }
            }
        }
    }
}
