using System;

class ClassMain
{
    public static void Main()
    {
        Console.WriteLine("Digite o intervalo de tempo no formato “HH:MM:SS”");
        string tempo = Console.ReadLine();
        string[] time = tempo.Split(":");
        int hh = int.Parse(time[0]) * 60 * 60;
        int mm = int.Parse(time[1]) * 60;
        int ss = int.Parse(time[2]);

        int segundos = hh + mm + ss;
        ulong distancia = 300000UL*(ulong)segundos;


        Console.WriteLine($"A luz percorreu {distancia} km nesse intervalo");
    }
}
