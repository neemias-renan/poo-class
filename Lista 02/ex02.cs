using System;

class ClassMain
{
    public static void Main()
    {
        Console.WriteLine("Digite seu nome completo: ");
        string nomecompleto = Console.ReadLine();
        string[] primeironome = nomecompleto.Split(" ");
        Console.WriteLine("Bem-vindo ao C#, " + primeironome[0]);
    }
}