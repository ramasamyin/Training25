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
      Print ("Enter a non-negative number: ");
      int n;
      while (!int.TryParse (Console.ReadLine (), out n)) Print ("You have not entered a valid number.\nEnter a number: ");
      Print (Armstrong (n) ? "Armstrong Number" : "Not an Armstrong Number");
   }

   static bool Armstrong (int n) {
      string num = n.ToString ();
      var (sum, len) = (0, num.Length);
      foreach (char c in num) sum += (int)Math.Pow (c - '0', len);
      return n == sum;
   }

   static void Print (string str) => Console.Write (str);
}


