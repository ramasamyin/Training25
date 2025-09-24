// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
namespace Training_1;
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter a number (must be 2 digits) for which the digital root has to be found");
      int n;
      while (!int.TryParse (Console.ReadLine (), out n)) Console.WriteLine ("Please enter a valid number");
      while (n >= 10) {
         int sum = 0;
         foreach (char c in n.ToString ()) {
            sum += c - '0';
         }
         n = sum;
      }
      Console.WriteLine ($"\nThe digital root is {n}");
   }
}

