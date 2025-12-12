namespace exercicios;

class Program
{
    static void Main(string[] args)
    {
        /*Escreva um programa que leia uma temperatura em Celsius e exiba-a convertida para
        fahrenheit, com duas casas decimais.
        Fórmula: (celsius * 9 / 5) + 32
        */

        Console.WriteLine("Digite a temperatura que deseja transformar: (°C)");
        double grausCelsius =  Convert.ToDouble(Console.ReadLine());

        double grausFahrenheit = (grausCelsius * 9/5 ) + 32;

        Console.WriteLine($"{grausCelsius} °C é o mesmo que {grausFahrenheit:F2} °F ");
    }
}
