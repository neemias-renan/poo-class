using System;

class Data
{
	private int dia;
	private int mes;
	private int ano;

	public Data(int Dia, int Mes, int Ano){
		dia = Dia;
		mes = Mes;
		ano = Ano;
	}
	
	public Data(string data){
		string[] dataStr = data.Split("/");
		int d = int.Parse(dataStr[0]);
		if(d>0 && d<=31){
			dia = d;
		}
		
		int m = int.Parse(dataStr[1]);
		if(m>0 && m<=12){
			mes = m;
		}
		
		int a = int.Parse(dataStr[2]);
		if(a>0){
			ano = a;
		}
		
	}
	
	public void SetData(int Dia, int Mes, int Ano){
		if(Dia>0 && Dia<=31){
			dia = Dia;
		}

		if(Mes>0 && Mes<=12){
			mes = Mes;
		}
		if(Ano>0){
			ano = Ano;
		}
		
	}

	public int GetDia(){
		int Dia = dia;
		return Dia;
	}

	public int GetMes(){
		int Mes = mes;
		return Mes;
	}

	public int GetAno(){
		int Ano = ano;
		return Ano;
	}
	
 
	public override string ToString(){
		
    return String.Format("{0:00}", dia)+"/"+String.Format("{0:00}", mes)+"/"+String.Format("{0:0000}", ano);
  }
	
}

class MainClass
{
	public static void Main(){

		Data dt = new Data("05/01/2011");
		Console.WriteLine(dt);
	}
}