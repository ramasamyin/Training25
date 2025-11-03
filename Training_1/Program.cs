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
      if (int.TryParse (ReadLine (), out int n)) {
         var (minSum, bestTarget) = MinTransform (n);
         WriteLine ($"Minimum cost: {minSum}");
         WriteLine ($"Transformed digit : {bestTarget}");
      } else WriteLine ("Invalid input");
   }

   // Function to calculate the minimum transformation cost by changing all digits to a single digit by calculating the
   // absolute difference between each digit and the target digit
   static (int MinSum, int bestTarget) MinTransform (int n) {
      HashSet<int> uniqueDigits = [];
      List<int> digits = new (10);
      int temp = n;
      while (temp > 0) {
         int rem = temp % 10;
         uniqueDigits.Add (rem);
         digits.Add (rem);
         temp /= 10;
      }
      int minSum = int.MaxValue, bestTarget = 0;
      foreach (int target in uniqueDigits) {
         int sum = 0;
         foreach (int digit in digits) sum += Math.Abs (digit - target);
         if (sum < minSum) (minSum, bestTarget) = (sum, target);
      }
      return (minSum, bestTarget);
   }
}
