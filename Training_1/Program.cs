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
   static void Main (string[] args) {
      Write ("Enter a number: ");
      int.TryParse (ReadLine (), out int n);
      WriteLine (MinTransform (n));
   }

   //Returns the smallest number of changes it takes to transform a number into a number with identical digits
   //by incrementing or decrementing a digit by one.
   static int MinTransform (int num) {
      int minSum = int.MaxValue;
      for (int k = 0; k < 10; k++) {
         int temp = num;
         int sum = 0;
         while (temp > 0) {
            int digit = temp % 10;
            sum += Math.Abs (digit - k);
            temp /= 10;
         }
         if (sum < minSum) minSum = sum;
      }
      return minSum;
   }
}
