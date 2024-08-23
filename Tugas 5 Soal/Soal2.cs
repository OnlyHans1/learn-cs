//  public static double kolam;
//     public static double pipa1;
//     public static double pipa2;
//     public static double lama;
 
//     public static double totalPipa;
//     public static double volumeTerisi;
 
//     public static void kolamRenang ()
//     {
//         Console.Write ("Volume kolam renang : " );
//         kolam = Convert.ToDouble(Console.ReadLine());
//     }
//     public static void Pipa1 ()
//     {
//         Console.Write ("Laju pipa 1 : ");
//         pipa1 = Convert.ToDouble(Console.ReadLine());
//     }
 
//     public static void Pipa2()
//     {
//         Console.Write("Kecepatan pipa 2 : ");
//         pipa2 = Convert.ToDouble(Console.ReadLine());
//     }
 
//     public static void lamaPekerjaan ()
//     {
//         Console.Write("Lama pekerjaan : " );
//         lama = Convert.ToDouble(Console.ReadLine());
//     }
 
//     public static void totalVolume ()
//     {
//         totalPipa = pipa1 + pipa2;
//         volumeTerisi = totalPipa * lama;
//     }
 
//     public static void perhitungan (double kolam, double pipa1, double pipa2)
//     {
//         if (volumeTerisi <= kolam)
//         {
//             double persenKolam = (volumeTerisi / kolam) * 100;
//             double persenPipa1 = pipa1 / totalPipa * 100;
//             double persenPipa2 = 100 - persenPipa1;
 
//             Console.WriteLine ($"Kolam terisi {persenKolam}% \t\tPipa 1 : {persenPipa1}% \t\tPipa 2 : {persenPipa2}%");
//         }
//         else
//         {
//             double kepenuhan = volumeTerisi - kolam;
//             Console.WriteLine($"Kolam kelebihan air sekitar {kepenuhan} liter");
//         }
//     }
//     static void Main ()
//     {
//         kolamRenang();
//         Pipa1();
//         Pipa2();
//         lamaPekerjaan();
//         totalVolume();
//         perhitungan(kolam, pipa1, pipa2);
//     }