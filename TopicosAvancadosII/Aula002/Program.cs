namespace Aula002;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            System.Console.WriteLine("SO: Windows");
        }else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            System.Console.WriteLine("SO: MacOS");
        }else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            System.Console.WriteLine("SO: Linux");
        }
    }
}
