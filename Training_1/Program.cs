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
      Console.Write ("Enter the number of rows upto which you wish to print the Pascal's triangle: ");
      int.TryParse (Console.ReadLine (), out int rows);
      Console.WriteLine ($"\nPascal's Triangle for {rows} rows: ");
      for (int x = 0; x < rows; x++) {
         for (int s = 0; s < rows - x - 1; s++) Console.Write (" ");
         for (int y = 0; y <= x; y++) Console.Write ($"{Combination (x, y)} ");
         Console.WriteLine ();
      }
   }

   static long Combination (int n, int r) {
      if (r > n) return 0;
      if (r == 0 || r == n) return 1;
      long result = 1;
      for (int i = 1; i <= r; i++) result = result * (n - i + 1) / i;
      return result;
   }
}

