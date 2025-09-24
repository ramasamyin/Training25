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
      int number = 0;
      Console.WriteLine ("Give an input number");
      if (!int.TryParse (Console.ReadLine (), out number)) Console.WriteLine ("You have not entered a valid number");
      else if (number < 0) Console.WriteLine ("Enter a non-negative number");
      else {
         if (Armstrong (number)) Console.WriteLine ($"\nArmstrong Number ");
         else Console.WriteLine ($"\nNot an Armstrong number");
      }
   }
   static bool Armstrong (int n) {
      int sum = 0;
      int length = n.ToString ().Length;
      foreach (char c in n.ToString ()) {
         int digit = c - '0';
         sum += (int)Math.Pow (digit, length);
      }
      return n == sum;
   }
}

