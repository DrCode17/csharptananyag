/*
	Short keys:
	alt + le/fel nyíl			sorok mozgatása
	alt + shift + le/fel nyíl	sorok duplikálása
	ctrl + f5					run
	alt + f5					debug
	f7							Check syntax
	crtl + c					másol
	ctrl + v					beilleszt
	ctrl + z					visszavon
	ctrl + y					visszavonja a visszavonást
	ctrl + s					ment
*/
using System;

namespace komenteles_kiiratas
{
	class Program
	{
		public static void Main(string[] args)
		{
            	
			Console.Write("Hello World!");					
			Console.Write("Hello");					        //A Console.Write-al egymás mellé írhatunk dolgokat
			Console.Write("World!");					    

			Console.WriteLine("Szeretem ");		            //Console.WriteLine gyakorlatilag üt egy entert a sor végén.
			Console.WriteLine("a sütit.");

            string s = Console.ReadLine();
            Console.WriteLine(s);
			
			/* Helloka.
			 Ez egy több soros komment
			 Nagyon hasznos ha például egy kódrészt egy ideig
			 nem szeretnénk futtatni, de később még szükségünk lehet rá.
			 Így nem veszik el de nem is fut le.
			*/
			
			Console.ReadKey(true); //ha terminálablakban futtatjuk, akkor megvárja, amíg leütünk egy gombot és csak utána zárja be magát, pl: Visual Studio
		}
	}
}