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
      Console.Write ("Enter which nth Armstrong number (only upto 25) you would like to find: ");
      int.TryParse (Console.ReadLine (), out int n);
      Console.WriteLine ($"\nThe {n}th Armstrong Number is {NthArmstrong (n)}. ");
   }

   //Finds the Armstrong Number at a particular position
   static int NthArmstrong (int n, int count = 0) {
      for (int i = 0; ; i++) if (IsArmstrong (i) && ++count == n) return i;
   }

   //Returns True if the integer is an Armstrong Number
   static bool IsArmstrong (int n) {
      var (sum, len) = (0, n.ToString ().Length);
      for (int i = n; i > 0; i /= 10) sum += (int)Math.Pow (i % 10, len);
      return n == sum;
   }
}

