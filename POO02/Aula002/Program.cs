namespace Aula002;

class Program
{
    static void Main(string[] args)
    {
        Felinos Gato1 = new Felinos();
        Felinos Gato2 = new Felinos();

        Gato1.Ataque();

        System.Console.WriteLine(Gato1.vida);
    }

    public class Felinos
    {
        public int vida = 100;

        public void Ataque()
        {
            vida = vida - 10;
        }   
    }
}
