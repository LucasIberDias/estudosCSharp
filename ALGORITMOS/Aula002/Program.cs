namespace Aula002;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[5]{5,7,4,15,1};
        InSort(vetor);
        foreach (var item in vetor)
        {
            System.Console.WriteLine(item);
        }
    }

    static void InSort(int[] arr)
    {
        for(int i=1; i< arr.Length; i++)
        {
            int key = arr[i];
            int j = i-1;

            while (j>=0 && arr[j] > key)
            {
                arr[j+1] = arr[j];
                j = j-1;
            }
            arr[j+1] = key;
        }
    }
}
