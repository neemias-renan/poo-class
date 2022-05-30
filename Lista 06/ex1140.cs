using System;

class ClassMain
{
    public static void Main()
		{
			for(int c = 0; c!=1;){
				string[] frase = Console.ReadLine().Split(' ');
				if(frase[0] != "*"){
					int cont = frase.Length;
					string anterior;
					
					for(int i = 0; i < cont; i++){
						string letra = frase[i].ToUpper();
						anterior = letra[0];
						
						if(letra[0] != anterior){
							Console.WriteLine('N');
						}						
					}
				}
				else{
					break;
				}
			}
		}
}