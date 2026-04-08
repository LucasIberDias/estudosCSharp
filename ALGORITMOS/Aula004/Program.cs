namespace Aula004;

class Program
{
    static void Main(string[] args)
    {
        int[] lista = {3,7,8,6,9,84,4,5,6,7,8,2,3,5,4,1,5,58};
        int id = BuscaSequencial(lista, 5);
        System.Console.WriteLine(id);
    }

    static int BuscaSequencial(int[] lista, int val)
    {
        for (int i = 0; i < lista.Length; i++)
        {
            if (lista[i] == val)
            {
                return i;
            }
        }
        return -1;  
    }
}
