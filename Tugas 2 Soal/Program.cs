using System;
					
public class Program
{
	public static void Main()
	{
		//Tugas No 1

		Random random = new Random();

		int kocokan1 = random.Next(400);
		int kocokan2 = random.Next(500);
		int kocokan3 = random.Next(600);

		int angka = Math.Max(kocokan1,kocokan2);
		int angka1 = Math.Max(angka,kocokan3);
		Console.WriteLine($"nilai 1 : {kocokan1}, nilai 2 : {kocokan2}, nilai 3 : {kocokan3}, nilai terbesar dari ketiga diatas adalah : {angka1}");

		//Tugas No 2

		Random random = new Random();

		int kocokan = random.Next(10,100);
		Console.WriteLine($"Ini Nilai kamu {kocokan}");

		if (kocokan <= 50)
		{
			Console.WriteLine("Nilai Kamu F!");
		}
		else if (kocokan <= 75)
		{
			Console.WriteLine("Nilai Kamu C!");
		}
		else if (kocokan <= 90)
		{
			Console.WriteLine("Nilai Kamu B!");
		}
		else 
		{
			Console.WriteLine("Nilai Kamu A!");
		}

		
	}
}