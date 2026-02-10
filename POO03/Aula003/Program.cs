using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using Microsoft.VisualBasic;

namespace Aula003;

class Program
{
    static void Main(string[] args)
    {
        Classe3 obj = new Classe3();
    }

    class Classe1
    {
        public Classe1()
        {
            System.Console.WriteLine("Construtor Classe 1");
        }
    }

    class Classe2 : Classe1
    {
        public Classe2()
        {
            System.Console.WriteLine("Construtor Classe 2");
        }
    }

    class Classe3 : Classe2
    {
        public Classe3()
        {
            System.Console.WriteLine("Construtor Classe 3");
        }
    }
}
