namespace Aula007;

class Program
{
    static void Main(string[] args)
    {
        //Conversões (Implicitas / Explicitas)

        //Conversões Implicitas(menor -> maior)
        int x = 10;
        long y = x;

        float f = 3.15f;
        double z = f;

        //Conversões Explicitas(maior -> menor)
        double a = 3.18;
        int b = (int)a;
    }
}
