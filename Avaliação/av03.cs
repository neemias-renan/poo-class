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
		if(Naipe == "ouro" || Naipe == "copas" || Naipe == "espada"|| Naipe == "paus"){
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
    return valor.ToString()+" de "+naipe.ToString();
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
			Console.WriteLine("__________________");
			Console.WriteLine("Naipes: ");
			Console.WriteLine("-> ouro");
			Console.WriteLine("-> copas");
			Console.WriteLine("-> espada");
			Console.WriteLine("-> paus");
			Console.WriteLine("__________________");
			Console.Write("Digite um Naipes: ");
			string naipe = Console.ReadLine();
			if(naipe == "ouro" || naipe == "copas" || naipe == "espada"|| naipe == "paus"){
				Console.Write("Digite o valor da carta entre 1 e 13: ");
				int valor = int.Parse(Console.ReadLine());
				if (valor>=1 && valor <= 13){
					CartaBaralho carta1 = new CartaBaralho(valor,naipe);
					Console.WriteLine(carta1);
					i++;
				}
				else{
					Console.WriteLine("dados inválidos");
				}
			}
			else{
					Console.WriteLine("dados inválidos");
				}
			}

	}
}