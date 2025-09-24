// ---
---------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
namespace Training_1 {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Type in a number");
         int.TryParse (Console.ReadLine (), out int n1);
         Console.WriteLine ("Type in the second number");
         int.TryParse (Console.ReadLine (), out int n2);
         if (n1 == 0 || n2 == 0) {
            Console.WriteLine ("GCD: 0");
            Console.WriteLine ("LCM: 0");
         } else {
            var (num1, num2) = (n1, n2);
            int remainder;
            do {
               remainder = n1 % n2;
               n1 = n2;
               n2 = remainder;
            } while (remainder != 0);
            Console.WriteLine ($"\nGCD: {n1}");
            Console.WriteLine ($"LCM: {(num1 * num2) / n1}");
         }
      }
   }
}
