namespace Aula007;

class Program
{
    static void Main(string[] args)
    {
        Gatos gato1 = new Gatos();
        Cachorro cachorro1 = new Cachorro();
        Panda panda1 = new Panda();

        //Polimorfismo permite com que um objeto seja não apenas do
        //tipo da sua classe, mas também das suas classes herdadas
        Mamiferos[] animaisMamiferos = {cachorro1, gato1, panda1};
        
        //exemplo de erro:
        //Panda[] vetor = {cachorro1, gato1, panda1};
    }
}

class Mamiferos
{
    
}

class Gatos : Mamiferos
{
    
}

class Cachorro : Mamiferos
{
    
}

class Panda : Mamiferos
{
    
}