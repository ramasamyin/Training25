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
      if (r <= 5) {
         for (int i = 0; i < r; i++) {
            Write (new string (' ', r - i - 1));
            for (int j = 0; j <= i; j++) Write ($"{GetPosValue (i, j)} ");
            WriteLine ();
         }
      } else {
         for (int i = 0; i < r; i++) {
            for (int j = 0; j <= i; j++) Write ($"{GetPosValue (i, j)} ");
            WriteLine ();
         }
      }

      // Each element in the pascal's triangle is calculated using the combination formula (nCr)
      // where,r is the row number and n is the position of the element within the row
      static int GetPosValue (int r, int n) {
         int result = 1;
         for (int i = 1; i <= n; i++) result = result * (r - i + 1) / i;
         return result;
      }
   }
}
