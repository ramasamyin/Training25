// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T11.1 branch.
// ------------------------------------------------------------------------------------------------
namespace Training_1;
internal class Program {
   static void Main (string[] args) {
      Console.Write ("Enter which nth armstrong number (only upto 25) you would like to find: ");
      int.TryParse (Console.ReadLine (), out int n);
      Console.WriteLine ($"\nThe {n}th armstrong number is {NthArmstrong (n)}. ");
   }

   //Returns true if the integer is an armstrong number
   static bool IsArmstrong (int n) {
      var (sum, len) = (0, 0);
      int temp = n;
      while (temp > 0) {
         len++;
         temp /= 10;
      }
      for (int i = n; i > 0; i /= 10) sum += (int)Math.Pow (i % 10, len);
      return n == sum;
   }

   //Returns the armstrong number of the given index
   static int NthArmstrong (int n) {
      for (int i = 0, count = 0; ; i++) if (IsArmstrong (i) && ++count == n) return i;
   }
}


