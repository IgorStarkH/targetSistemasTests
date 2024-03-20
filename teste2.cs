using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sequência de Fibonacci");
        Console.Write("Insira um número: ");
        int numero = int.Parse(Console.ReadLine());

        int n1 = 0;
        int n2 = 1;

        for (int i = 0; n2 < numero; i++)
        {
            int valorTemporario = n1 + n2;
            n1 = n2;
            n2 = valorTemporario;
        }

        if (n2 == numero || numero == 0 || numero == 1)
            Console.WriteLine($"{numero} pertence à sequência");
        else
            Console.WriteLine($"{numero} não pertence à sequência");
    }
}
