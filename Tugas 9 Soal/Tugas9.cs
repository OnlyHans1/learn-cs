// // Tantangan 9

// int angkaAngka = Convert.ToInt32(Console.ReadLine());
// string [] satuan = {"Satu", "Dua", "Tiga", "Empat", "Lima", "Enam", "Tujuh", "Delapan", "Sembilan", "Sepuluh"};
// string [] belasan = {"Sebelas", "Duabelas", "Tigabelas", "Empatbelas", "Limabelas", "Enambelas", "Tujuhbelas", "Delapanbelas", "Sembilanbelas"};
// string [] puluhan = {" ", " ", "Dua puluh", "Tiga puluh", "Empat puluh", "Lima puluh", "Enam puluh", "Tujuh puluh", "Delapan puluh", "Sembilan puluh"};

// if (angkaAngka <= 10)
// {
//     Console.WriteLine (satuan[angkaAngka]);
// }
// else if (angkaAngka < 20)
// {
//     Console.WriteLine(belasan[angkaAngka - 11]);
// }
// else if (angkaAngka % 10 == 0)
// {
//     Console.WriteLine(puluhan[angkaAngka/10]);
// }
// else 
// {
//     Console.WriteLine (puluhan [angkaAngka/10] + " " + satuan[angkaAngka%10]);
// }