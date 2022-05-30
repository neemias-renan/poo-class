// A classe deve ter atributos para 
// armazenar o dia e o horário de uma sessão de cinema
// e métodos para calcular o valor da entrada inteira e da meia-entrada.

// O valor das entradas deve ser calculado com base nas seguintes regras:
// • Segunda, terça e quinta, o valor base do ingresso é R$ 16,00.
// • Nas quartas todos pagam meia-entrada no valor de R$ 8,00, em qualquer horário.
// • Sexta, sábado e domingo, o valor base do ingresso é R$ 20,00.
// • Das 17h à meia-noite, há acréscimo de 50% no valor base do ingresso.

using System;

class EntradaCinema
{
	public int Inteira(int dia,int horario)
	{
		int inteira;
		if(dia == 2 || dia == 3 || dia == 5){
			inteira = 16;
		}
		else if(dia == 4){
			inteira = 8;
		}
		else{
			inteira = 20;
		}
		
		if(horario>=17 && horario<=24){
			double porcentagem = 0.5*(double)inteira;
			int p = (int)porcentagem;
			inteira = inteira + p;
		}
		return inteira;
	}

	public int MeiaEntrada(int dia, int horario)
	{
		int meiaentrada;
		if(dia == 4){
			meiaentrada = 8;
		}
		else{
			meiaentrada = Inteira(dia,horario)/2;
		}
		return meiaentrada;
	}
}

class MainClass
{
	public static void Main()
	{
		Console.WriteLine("-------------------");
		Console.WriteLine("Dias disponíveis:");
		Console.WriteLine("1 | Domingo");
		Console.WriteLine("2 | Segunda");
		Console.WriteLine("3 | Terça");
		Console.WriteLine("4 | Quarta");
		Console.WriteLine("5 | Quinta");
		Console.WriteLine("6 | Sexta");
		Console.WriteLine("7 | Sábado");
		Console.WriteLine(" ");
		
		Console.Write("Defina o dia: ");
		int d = int.Parse(Console.ReadLine());
		
		Console.Write("Horário: ");
		int hr = int.Parse(Console.ReadLine());
		Console.WriteLine("-------------------");

		EntradaCinema entCinema = new EntradaCinema();

		
		Console.WriteLine("Valor da entrada Inteira: "+entCinema.Inteira(d,hr));
		Console.WriteLine("Valor da Meia Entrada: "+entCinema.MeiaEntrada(d,hr));

	}	
}
