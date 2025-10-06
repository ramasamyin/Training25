// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_1;

internal class Program {
   static void Main (string[] args) {
      Write ("Enter the number of rows upto which you wish to print the Pascal's triangle: ");
      int.TryParse (ReadLine (), out int r);
      for (int i = 0; i < r; i++) {
         for (int j = 0; j < r - i - 1; j++) Write (" ");
         for (int k = 0; k <= i; k++) Write ($"{Combination (i, k)} ");
         WriteLine ("");
      }
   }

   //Returns the combination value C(n, r)
   static long Combination (int n, int r) {
      if (r > n) return 0;
      if (r == 0 || r == n) return 1;
      long result = 1;
      for (int i = 1; i <= r; i++) result *= (n - i + 1) / i;
      return result;
   }
}
