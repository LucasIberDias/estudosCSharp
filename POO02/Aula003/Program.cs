namespace Aula003;

class Program
{
    static void Main(string[] args)
    {
        Felinos gato1 = new Felinos("Siames");
        System.Console.WriteLine(gato1.raca);
    }

    public class Felinos
    {
        public int vida;
        public string raca;

        public Felinos(string entradaRaca)
        {
            vida = 100;
            raca = entradaRaca;
        }
    }
}
