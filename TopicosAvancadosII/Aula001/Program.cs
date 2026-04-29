namespace Aula001;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var os = Environment.OSVersion;

        System.Console.WriteLine(os.Platform);
        System.Console.WriteLine(os.Version.Major);
        System.Console.WriteLine(os.Version.Minor);
        System.Console.WriteLine(os.ServicePack);

        System.Console.WriteLine(os.VersionString);
    }
}
