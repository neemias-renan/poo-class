using System;

class MainClass
{
	public static string FormatarTexto(string texto)
	{	
		string[] txt = texto.Split(" ");
		for(int i=0; i>txt.Length;i++){
			if(txt[i] != ""){
				Console.Write(txt[i]+"-");
			}
		}
		// string c = txt[0]+"-"+txt[1]+"-"+txt[2]+"-"+txt[3];
		return "";
	}
	
	public static void Main()
	{
		string txt = Console.ReadLine();
		Console.WriteLine(FormatarTexto(txt));
	}

	
}