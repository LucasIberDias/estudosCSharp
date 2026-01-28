namespace Aula001;

class Program
{
    static void Main(string[] args)
    {
        Felinos Gato = new Felinos();
        Gato.ataque();
    }
}

class Animais
{
    public int vida = 100;
    public string raca;

    public void ataque()
    {
        System.Console.WriteLine("Ataque!");
    }
}

class Felinos:Animais
{
    //por ser herdade esa classe possui vida e raça
}
