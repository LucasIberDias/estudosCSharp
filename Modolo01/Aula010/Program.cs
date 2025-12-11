namespace Aula010;

class Program
{
    enum Dias{segunda, terça, quarta, quinta, sexta}
    enum StatusPedido{espera = 0, pago = 1, cancelado = 2}
    static void Main(string[] args)
    {
        //Enumeradores e dados dynamic
        Dias dia_atual = Dias.sexta;
        Console.WriteLine((int)dia_atual);

        StatusPedido status = StatusPedido.pago;
        Console.WriteLine(status);
        Console.WriteLine((int)status);

        //Dynamic é um dado sem tipo pode mudar durante execução
        dynamic valor = 100;
        Console.WriteLine(valor);
        valor = "Agora é um texto";
        Console.WriteLine(valor);
        valor = true;
        Console.WriteLine(valor);
    }
}
