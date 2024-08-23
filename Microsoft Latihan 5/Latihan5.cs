// int hero = 10;
//       int monster = 10;
//       Random r = new Random();

//       do 
//       {
//         int roll = r.Next (1,11);
//         monster -= roll;
//         Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//         if (monster <= 0) continue;

//         roll = r.Next (1,11);
//         hero -= roll;
//         Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
//       }
//       while (hero > 0 && monster > 0);
//       Console.WriteLine (hero>monster?"Hero Wins!" : "Monster Wins!");