using System;

namespace valtozok
{
	class Program
	{
		public static void Main(string[] args)
		{
			//betűk
			//char
			char a = 'a';
			Console.WriteLine(a);
			char b = 'z';
			Console.WriteLine(b);
			
			//string konverzió
			string c = a.ToString() + b.ToString();
			Console.WriteLine(c);
			
			//string
			string szoveg = "alma";
			Console.WriteLine(szoveg);

			string banan = "banan";
			Console.WriteLine(banan);
			Console.WriteLine("Vegyel " + szoveg + "t es " + banan + "t a boltban legyszi.");
			Console.WriteLine( szoveg + "\t" + banan );	//tabulátor
			Console.WriteLine( szoveg + "\n" + banan );	//sortörés
			
			//számok
			//byte: 0 -> 255
			Console.WriteLine("Byte:\t " + byte.MinValue + " -> " + byte.MaxValue);

			//int16:-32768 -> 32767
			Console.WriteLine("Int16:\t" + Int16.MinValue + " -> " + Int16.MaxValue);

			//int32:-2147483648 -> 2147483647
			Console.WriteLine("Int32:\t" + Int32.MinValue + " -> " + Int32.MaxValue);

			//int64:-9223372036854775808 -> 9223372036854775807
			Console.WriteLine("Int64:\t" + Int64.MinValue + " -> " + Int64.MaxValue);

			int d = 1;
			Console.WriteLine(d);//1

			d = d+1;
			Console.WriteLine(d);//2
			
			d++;
			Console.WriteLine(d);//3
			
			d +=2;
			Console.WriteLine(d);//5

			int D = 7;
			Console.WriteLine(D);

			int e = d + D;
			Console.WriteLine(e); //12

			int f = d - D;
			Console.WriteLine(f); //-2
			
			int g = d * D;
			Console.WriteLine(g); //35

			int h = d / D;
			Console.WriteLine(h); //0

			//double: -1,7976931348623157E+308 -> 1,7976931348623157E+308
			Console.WriteLine("Double:\t" + Double.MinValue + " -> " + Double.MaxValue);

			double doub = d / D;
			Console.WriteLine(doub);//0

			//double konverzió
			double osztott = (double)d / D;
			Console.WriteLine(osztott);  //0,7142857142857143

			double osztott2 = d / (double)D;
			Console.WriteLine(osztott2); //0,7142857142857143

			double tort = 2.15;
			Console.WriteLine(tort); //2,15

			//float: -3,4028235E+38 -> 3,4028235E+38
			Console.WriteLine("Float:\t" + float.MinValue + " -> " + float.MaxValue);
			
			float osztott3 = (float)d / D;
			Console.WriteLine(osztott3);  //0,7142857142857143

			float osztott4 = d / (float)D;
			Console.WriteLine(osztott4); //0,7142857142857143

			float pi = 3.14159265f;
			Console.WriteLine(pi); //3.14159265
		}
	}
}