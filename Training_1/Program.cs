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
         var (minSum, convertedNumber) = MinTransform (n);
         WriteLine ($"Minimum cost: {minSum}");
         WriteLine ($"Transformed number: {convertedNumber}");
      } else WriteLine ("Invalid input");
   }

   // Function to calculate the minimum transformation cost by changing all digits to a single digit by calculating the
   // absolute difference between each digit and the target digit
   static (int minSum, string convertedNumber) MinTransform (int n) {
      HashSet<int> uniqueDigits = [];
      int temp = n;
      while (temp > 0) {
         uniqueDigits.Add (temp % 10);
         temp /= 10;
      }
      int minSum = int.MaxValue;
      int bestTarget = 0;
      foreach (int target in uniqueDigits) {
         int sum = 0;
         temp = n;
         while (temp > 0) {
            int digit = temp % 10;
            sum += Math.Abs (digit - target);
            temp /= 10;
         }
         if (sum < minSum) {
            minSum = sum;
            bestTarget = target;
         }
      }
      return (minSum, new string (bestTarget.ToString ()[0], n.ToString ().Length));
   }
}
