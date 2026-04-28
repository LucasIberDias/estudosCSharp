namespace Aula008;

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> dic1 = new Dictionary<string, string>();

        dic1.Add("Nome", "Pedro");

        System.Console.WriteLine(dic1["Nome"]);

        dic1.ContainsValue("Pedro");

        Dictionary<string, string> dic2 = new Dictionary<string, string>()
        {
          {"Nome", "Pedro"},
          {"País", "Portugal"}
        };

        foreach (KeyValuePair<string, string> item in dic2)
        {
            System.Console.WriteLine(item.Value, item.Key );
        }
    }
}
