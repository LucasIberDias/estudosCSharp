namespace Aula005;

class Program
{
    static void Main(string[] args)
    {
        int[] lista = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int id = BuscaBinaria(lista, 4);
        System.Console.WriteLine(id);
    }
    static int BuscaBinaria(int[] lista, int val)
    {
        int inicio = 0;
        int fim = lista.Length - 1;

        while (inicio <= fim)
        {
            int meio = (inicio + fim) / 2;

            if (lista[meio] == val)
            {
                return meio;
            }
            else if (lista[meio] < val)
            {
                inicio = meio + 1;
            }
            else
            {
                fim = meio - 1;
            }
        }

        return -1;
    }
}