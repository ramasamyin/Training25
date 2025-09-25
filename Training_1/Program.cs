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
      DisplayResult ("Give an input number");
      if (!int.TryParse (Console.ReadLine (), out int n)) DisplayResult ("You have not entered a valid number");
      else if (n < 0) DisplayResult ("Enter a non-negative number");
      else DisplayResult (Armstrong (n) ? "Armstrong Number" : "Not an Armstrong Number");
   }
   static void DisplayResult (string message) { Console.WriteLine (message); }
   static bool Armstrong (int n) {
      var (sum, len) = (0, n.ToString ().Length);
      foreach (char c in n.ToString ()) {
         sum += (int)Math.Pow (c - '0', len);
      }
      return n == sum;
   }
}

