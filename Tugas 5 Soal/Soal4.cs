//  using System;
 
// class Program
// {
//     static string? produk;
//     static string? lokasi;
//     static int jumlah = 0;
//     static int harga = 0;
   
 
//     public static void keputusan ()
//     {
//         if (produk == "air mineral")
//         {
//             airMineral();
//         }
//         else if (produk == "roti")
//         {
//             roti();
//         }
//         else if (produk == "jus")
//         {
//             jus();
//         }
//         else if (produk == "kopi")
//         {
//             kopi();
//         }
//         else if (produk == "cake")
//         {
//             cake();
//         }
//     }
//     public static void airMineral ()
//     {
//         switch (lokasi)
//         {
//             case "surabaya":
//                 harga = 5000;
//                 break;
//             case "bandung":
//                 harga = 6000;
//                 break;
//             case "jakarta":
//                 harga = 7000;
//                 break;
//         }
//     }
 
//     public static void roti ()
//     {
//         switch (lokasi)
//         {
//             case "surabaya":
//                 harga = 6000;
//                 break;
//             case "bandung":
//                 harga = 7000;
//                 break;
//             case "jakarta":
//                 harga = 8000;
//                 break;
//         }
//     }    
//     public static void jus ()
//     {
//         switch (lokasi)
//         {
//             case "surabaya":
//                 harga = 7500;
//                 break;
//             case "bandung":
//                 harga = 9000;
//                 break;
//             case "jakarta":
//                 harga = 10000;
//                 break;
//         }
//     }    
 
//     public static void kopi ()
//     {
//         switch (lokasi)
//         {
//             case "surabaya":
//                 harga = 10000;
//                 break;
//             case "bandung":
//                 harga = 12000;
//                 break;
//             case "jakarta":
//                 harga = 15000;
//                 break;
//         }
//     }
 
//     public static void cake ()
//     {
//         switch (lokasi)
//         {
//             case "surabaya":
//                 harga = 15000;
//                 break;
//             case "bandung":
//                 harga = 17000;
//                 break;
//             case "jakarta":
//                 harga = 20000;
//                 break;
//         }
//     }  
//     public static void Main()
//     {
//         Console.Write("Masukkan nama produk : ");
//          produk = Console.ReadLine()?.ToLower();
 
//         Console.Write("Masukkan nama kota : ");
//          lokasi = Console.ReadLine()?.ToLower();
 
//         Console.Write("Masukkan jumlah pembelian : ");
//          jumlah = Convert.ToInt32(Console.ReadLine());
 
//         keputusan();
//         Console.WriteLine("Harga total untuk produk " + produk + " sebanyak " + jumlah + " buah di kota " + lokasi + " adalah Rp" + (harga * jumlah));
//     }  
// }
