using System;

class ClassMain
{
    public static void Main()
		{
			int i= 0;
			while(i==0){
				float n1 = float.Parse(Console.ReadLine());
				double valor_decimal = n1 - (int)(n1);
				if(n1>=0 && n1<=10 && valor_decimal == 0){
					float n2 = float.Parse(Console.ReadLine());
					valor_decimal = n2 - (int)(n2);
					if(n2>=0 && n2<=10 && valor_decimal == 0){
						float media = (n1+n2)/2;
						Console.WriteLine("media = "+media);
						i++;
					}
				}else{
					Console.WriteLine("nota invalida");
					
				}
			}
		}
}