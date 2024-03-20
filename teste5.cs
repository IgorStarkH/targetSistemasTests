/*5) Escreva um programa que inverta os caracteres de um string.


IMPORTANTE:

a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

b) Evite usar funções prontas, como, por exemplo, reverse;
*/

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        string inverter = "";
        Console.WriteLine("Teste 5 - Target Sistemas");
        Console.Write("Digite um texto para inverter: ");
        inverter = Console.ReadLine();

        string invertido = "";
        for (int i = inverter.Length - 1; i >= 0; i--)
        {
            invertido += inverter[i];
        }
        Console.WriteLine(invertido);
    }
}