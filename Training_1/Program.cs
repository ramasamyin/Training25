// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T14 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_1;

internal class Program {
   static void Main () {
      Write ("Enter a number: ");
      WriteLine (int.TryParse (ReadLine (), out int n) ? MinTransform (n) : "Invalid input");
   }

   // Function to calculate the minimum transformation cost by changing all digits to a single digit by calculating the
   // absolute difference between each digit and the target digit
   static int MinTransform (int n) {
      int minSum = int.MaxValue;
      for (int i = 0; i < 10; i++) {
         var (sum, temp) = (0, n);
         while (temp > 0) {
            int digit = temp % 10;
            sum += Math.Abs (digit - i);
            temp /= 10;
         }
         if (sum < minSum) minSum = sum;
      }
      return minSum;
   }
}
