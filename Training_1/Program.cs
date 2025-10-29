// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
namespace Training_1 {
   internal class Program {
      static void Main () {
         int n;
         Console.Write ("Enter a number: ");
         while (!int.TryParse (Console.ReadLine (), out n)) Console.WriteLine ("Please enter a valid input");
         List<int> even = [];
         List<int> odd = [];
         int digit;
         while (n > 0) {
            digit = n % 10;
            if (digit % 2 == 0) even.Add (digit);
            else odd.Add (digit);
            n /= 10;
         }
         Console.Write (String.Join ("", even.OrderBy (x => x)));
         Console.Write (String.Join ("", odd.OrderBy (x => x)));
      }
   }
}
