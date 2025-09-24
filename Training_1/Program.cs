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
      Console.WriteLine ("Give an input number");
      if (!int.TryParse (Console.ReadLine (), out int number)) Console.WriteLine ("You have not entered a valid number");
      else if (number < 0) Console.WriteLine ("Enter a non-negative number");
      else Console.WriteLine (Armstrong (number) ? "Armstrong Number" : "Not an Armstrong Number");
   }
   static bool Armstrong (int n) {
      (int sum, int length) = (0, n.ToString ().Length);
      foreach (char c in n.ToString ()) {
         sum += (int)Math.Pow (c - '0', length);
      }
      return n == sum;
   }
}

