namespace Aula009;

class Program
{
    static void Main(string[] args)
    {
        Felinos gato = new Felinos(100, "Siâmes");
        System.Console.WriteLine(gato.raca + " " + gato.vida);
    }
}

class Felinos
{
    public int vida;
    public String raca;

    public Felinos(int vida, String raca)
    {
        //this referencia a classe 
        this.vida = vida;
        this.raca = raca;
    }
}
