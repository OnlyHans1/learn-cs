// using System;

// public class Program 
// {
//     public static void Main()
//     {
//        int angkaAngka = Convert.ToInt32(Console.ReadLine());
//     string[] satuan = {"Nol", "Satu", "Dua", "Tiga", "Empat", "Lima", "Enam", "Tujuh", "Delapan", "Sembilan", "Sepuluh"};
//     string[] belas = {"Sebelas", "Dua belas", "Tiga belas", "Empat belas", "Lima belas", "Enam belas", "Tujuh belas", "Delapan belas", "Sembilan belas"};
//     string[] puluh = {"", "", "Dua puluh", "Tiga puluh", "Empat puluh", "Lima puluh", "Enam puluh", "Tujuh puluh", "Delapan puluh", "Sembilan puluh", "seratus"};


//     if (angkaAngka <= 10)
//     {
//         Console.WriteLine(satuan[angkaAngka]);
//     }
//     else if (angkaAngka < 20)
//     {
//         Console.WriteLine(belas[angkaAngka - 11]);
//     }
//     else if (angkaAngka % 10 == 0)
//     {
//         Console.WriteLine(puluh[angkaAngka / 10]);
//     }
//     else
//     {
//         Console.WriteLine(puluh[angkaAngka / 10] + " " + satuan[angkaAngka % 10]);
//     }

//     }   
// }