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
         int number = 0;
         Console.WriteLine ("Give an input number");
         bool validity = int.TryParse (Console.ReadLine (), out number);
         if (!validity) {
            Console.WriteLine ("You have not entered a valid number");
         } else if (number < 0) {
            Console.WriteLine ("Enter a non-negative number");
         } else {
            if (Armstrong (number)) { Console.WriteLine ($"Yes. {number} is an Armstrong Number "); } else { Console.WriteLine ($"No. {number} is not an Armstrong number"); }
         }
      }
      static bool Armstrong (int n1) {
         int sum = 0;
         int length = n1.ToString ().Length;
         foreach (char c in n1.ToString ()) {
            int digit = c - '0';
            sum += (int)Math.Pow (digit, length);
         }
         return n1 == sum;
      }
   }
}
