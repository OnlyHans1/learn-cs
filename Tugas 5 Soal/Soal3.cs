// using System;

// class menentukanPanggilan
// {
//     static string? gender = "";
//     static int umur = 0;
//     static string? pemeriksaan = "";

//     static void masukanGender()
//     {
//         Console.WriteLine("input gender: pria/wanita ");
//         gender = Console.ReadLine();
//         masukanUmur();
//     }
//     static void masukanUmur()
//     {
//         Console.WriteLine("input umur : ");
//         umur = Convert.ToInt32(Console.ReadLine());
//         cekPemeriksaan();
//     }
//     static void cekPemeriksaan()
//     {
//         if (gender == "pria" && umur < 17)
//         {
//             pemeriksaan = "Master";
//         }
//         else if (gender == "pria" && umur >= 17)
//         {
//             pemeriksaan = "Mr";
//         }
//         else if (gender == "wanita" && umur < 17)
//         {
//             pemeriksaan = "Miss";
//         }
//         else if (gender == "wanita" && umur >= 17)
//         {
//             pemeriksaan = "Ms";
//         }
//         else
//         {
//             masukanGender();
//         }

//         Console.WriteLine(pemeriksaan);
//     }

//     static void Main()
//     {
//         masukanGender();
//     }
// }