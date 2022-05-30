using System;

class EntradaCinema
{
	private int dia, horario;

	public void SetDia(int d){
		dia = d;
	}

	public void SetHorario(int h){
		horario = h;
	}

	public int GetDia(){
		int d = dia;
		return d;
	}
	public int GetHorario(){
		int h = horario;
		return h;
	}
	
	public int Inteira()
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

	public int MeiaEntrada()
	{
		int meiaentrada;
		if(dia == 4){
			meiaentrada = 8;
		}
		else{
			meiaentrada = Inteira()/2;
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
		
		Console.Write("Defina o Dia: ");
		int d = int.Parse(Console.ReadLine());
		
		Console.Write("Defina o Horário: ");
		int hr = int.Parse(Console.ReadLine());
		Console.WriteLine("-------------------");

		EntradaCinema entCinema = new EntradaCinema();

		entCinema.SetDia(d);
		entCinema.SetHorario(hr);
		
		Console.WriteLine("Valor da entrada Inteira: "+entCinema.Inteira());
		Console.WriteLine("Valor da Meia Entrada: "+entCinema.MeiaEntrada());

	}	
}
