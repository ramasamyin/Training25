// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
namespace Training_1 {
   internal class Program {
      static void Main (string[] args) {
         int n1; int n2;
         Console.Write ("Enter the first number: ");
         while (!int.TryParse (Console.ReadLine (), out n1)) Console.Write ("The input is not valid.\nEnter another number: ");
         Console.Write ("Enter the second number: ");
         while (!int.TryParse (Console.ReadLine (), out n2)) Console.Write ("The input is not valid.\nEnter another number: ");
         if (n1 == 0 || n2 == 0) {
            Console.WriteLine ("GCD: 0");
            Console.WriteLine ("LCM: 0");
         } else {
            var (num1, num2) = (n1, n2);
            int rem;
            do {
               rem = n1 % n2;
               (n1, n2) = (n2, rem);
            } while (rem != 0);
            Console.WriteLine ($"\nGCD: {n1}\nLCM: {(num1 * num2) / n1}");
         }
      }
   }
}

