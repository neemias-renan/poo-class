// Leia 4 valores inteiros A, B, C e D.
// A seguir, se B for maior do que C e se D for maior do que A, 
// e a soma de C com D for maior que a soma de A e B
// e se C e D, ambos, forem positivos e se a variável A for par
// escrever a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".

using System;

class ClassMain
{
    public static void Main()
		{
			int a,b,c,d;
			string[] entrada = Console.ReadLine().Split(' ');
			
			a = int.Parse(entrada[0]);
			b = int.Parse(entrada[1]);
			c = int.Parse(entrada[2]);
			d = int.Parse(entrada[3]);

			if(b>c && d>a && (c+d)>(a+b) && c>0 && d>0 && a%2==0){
				Console.WriteLine("Valores aceitos");
			}else{
				Console.WriteLine("Valores nao aceitos");
			}
		}
}