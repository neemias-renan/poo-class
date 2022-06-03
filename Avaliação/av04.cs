using System;

class CartaBaralho
{
	private int valor;
	private string naipe;

	public CartaBaralho(int Valor, string Naipe)
	{
		if (Valor>=1 && Valor <= 13){
			valor = Valor;
			if(Naipe == "ouro" || Naipe == "copas" || Naipe == "espadas"|| Naipe == "paus"){
				naipe = Naipe;
			}
			else{
				Console.WriteLine("inválido");
			}
		}
		else{
			Console.WriteLine("inválido");
		}		
	}

	public void SetValor(int Valor)
	{
		if (Valor>=1 && Valor <= 13){
			valor = Valor;
		}
		else{
			Console.WriteLine("inválido");
		}	
	}

	public void SetNaipe(string Naipe)
	{
		if(Naipe == "ouro" || Naipe == "copas" || Naipe == "espadas"|| Naipe == "paus"){
				naipe = Naipe;
			}
			else{
				Console.WriteLine("inválido");
			}
	}

	public int GetValor()
	{
		return this.valor;
	}

	public string GetNaipe()
	{
		return this.naipe;
	}

	public override string ToString()
	{
    return valor.ToString()+":"+naipe.ToString();
  }

	public void CartasIguais(string primeiraCarta, string segundaCarta)
	{
		if(primeiraCarta == segundaCarta){
			Console.WriteLine("Valores Iguais");
		}
	}
}

class MainClass
{
	public static void Main(){
		int i = 0;
		while(i != 1){
			Console.WriteLine("Carta 1: ");
			Console.WriteLine("__________________");
			Console.WriteLine("Naipes: ");
			Console.WriteLine("-> ouro");
			Console.WriteLine("-> copas");
			Console.WriteLine("-> espada");
			Console.WriteLine("-> paus");
			Console.WriteLine("__________________");
			Console.Write("Digite um Naipes: ");
			string naipe1 = Console.ReadLine();
			if(naipe1 != ""){
				Console.Write("Digite o valor da carta entre 1 e 13: ");
				int valor1 = int.Parse(Console.ReadLine());
				CartaBaralho carta1 = new CartaBaralho(valor1,naipe1);
			}
			
	
			
		}
		
		
		Console.WriteLine("Carta 2: ");
		Console.WriteLine("__________________");
		Console.WriteLine("Naipes: ");
		Console.WriteLine("-> ouro");
		Console.WriteLine("-> copas");
		Console.WriteLine("-> espada");
		Console.WriteLine("-> paus");
		Console.WriteLine("__________________");
		Console.Write("Digite um Naipes: ");
		string naipe2 = Console.ReadLine();
		
		Console.Write("Digite o valor da carta entre 1 e 13: ");
		int valor2 = int.Parse(Console.ReadLine());

		CartaBaralho carta2 = new CartaBaralho(valor2,naipe2);

		if(carta1.GetValor() == carta2.GetValor() && carta1.GetNaipe() == carta2.GetNaipe()){
			Console.WriteLine("As cartas são iguais: ("+carta1+"/"+carta2+")");
		}else{
			Console.WriteLine("Cartas Diferentes ("+carta1+"/"+carta2+")");
		}
		
		
	}
}