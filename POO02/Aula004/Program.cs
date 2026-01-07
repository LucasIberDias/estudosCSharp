namespace Aula004;

class Program
{
    static void Main(string[] args)
    {
        Felinos gato1 = new Felinos("Siames");
        System.Console.WriteLine(gato1.raca + " " + gato1.vida);

        Felinos gato2 = new Felinos("Laranja", 150);
        System.Console.WriteLine(gato2.raca + " " + gato2.vida);
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

        public Felinos(string entradaRaca, int entradaVida)
        {
            vida = entradaVida;
            raca = entradaRaca;
        }
    }
}
