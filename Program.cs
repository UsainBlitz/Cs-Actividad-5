using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor, ingrese su nombre:");
        var nombre = Console.ReadLine();

        var nombreInvertido = "";
        for (var i = nombre.Length - 1; i >= 0; i--)
        {
            nombreInvertido += nombre[i];
        }

        Console.WriteLine("¡Adiós " + nombreInvertido + "!");
    }
}
