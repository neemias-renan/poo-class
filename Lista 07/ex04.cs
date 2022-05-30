using System;

class MainClass
{
	public static int MMC(int x, int y)
	{
		int maior = 0;
		if(x>y){
			 maior = x;
		} else{
			maior = y;
		}
		    
		while true {
		    if(maior % x == 0 && maior % y == 0){
					Console.WriteLine(maior);
		      break;
				}
		    else{
		        maior += 1;
					}
		}
	}
	
	public static void Main()
	{
		double n1 = double.Parse(Console.ReadLine());
		Intervalo(n1);
	}

	
}