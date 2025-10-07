// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_1 {
   internal class Program {
      static void Main (string[] args) {
         Write ("Enter a number: ");
         int.TryParse (ReadLine (), out int n);
         int minSum = int.MaxValue;
         for (int k = 0; k < 10; k++) {
            int temp = n;
            int sum = 0;
            while (temp > 0) {
               int digit = temp % 10;
               sum += Math.Abs (digit - k);
               temp /= 10;
            }
            if (sum < minSum) minSum = sum;
         }
         WriteLine (minSum);
      }
   }
}
