namespace Aula006;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> Lista1 = new List<int>();
        //Adiciona os valores em série
        Lista1.Add(10);
        Lista1.Add(20);

        //insere o valor na posição que eu definir
        Lista1.Insert(1, 40);

        //Verifca se o dado existe
        bool ex = Lista1.Contains(20);

        //Pega o indice do valor
        Lista1.IndexOf(10);

        //Verificar quantos valores tem na lista
        Lista1.Count;

        foreach(var item in Lista1)
        {
           System.Console.WriteLine(item); 
        }        
    }
}
