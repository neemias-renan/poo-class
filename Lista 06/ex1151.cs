using System;

class ClassMain
{
    public static void Main()
		{
			int quant = int.Parse(Console.ReadLine());
			int p0 = 0;
			int p1 = 1;
			int p2 = 0;
			
			for(int i=0; i <= (quant-3);i++){
				if(p0 == 0 || p1 == 1){
					Console.Write(p0+" ");
				}
	
				p2 = p0+p1;
				p0 = p1;
				p1 = p2;
				
				if(i==(quant-3)){
					Console.Write(p2);
					break;
				}
				else{
					Console.Write(p2+" ");
				}
			}
		}
}