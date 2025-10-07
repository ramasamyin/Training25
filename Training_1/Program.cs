// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T07 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_1;

internal class Program {
   static void Main (string[] args) {
      Write ("Enter the number of rows upto which you wish to print the Pascal's triangle: ");
      int.TryParse (ReadLine (), out int r);
      for (int i = 0; i < r; i++) {
         Write (new string (' ', r - i - 1));
         for (int j = 0; j <= i; j++) Write ($"{Combination (i, j)} ");
         WriteLine ();
      }
   }

   //Each element in the pascal's triangle is calculated using the combination formula (nCr)
   //where,n is the row number and r is the position of the element within the row
   static int Combination (int n, int r) {
      if (r > n) return 0;
      if (r == 0 || r == n) return 1;
      int result = 1;
      for (int i = 1; i <= r; i++) result = result * (n - i + 1) / i;
      return result;
   }
}
