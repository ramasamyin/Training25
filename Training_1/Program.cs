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
         Console.WriteLine ("Give an input for which the digital root has to be found");
         while (!int.TryParse (Console.ReadLine (), out number)) {
            Console.WriteLine ("Please enter a valid number");
         }
         while (number >= 10) {
            int sum = 0;
            foreach (char n in number.ToString ()) {
               int digit = n - '0';
               sum += digit;
            }
            number = sum;
         }
         Console.WriteLine ($"\nThe digital root is {number}");
      }
   }
}
