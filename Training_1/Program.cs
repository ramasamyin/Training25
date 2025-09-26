// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
using System.Diagnostics.CodeAnalysis;

namespace Training_1;
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter n - Which Armstrong number do you want (upto 25) : ");
      int.TryParse (Console.ReadLine (), out int n);
      Console.WriteLine ($"\nThe {n}th Armstrong Number is {FindNthArmstrong (n)}. ");
   }

   //0 is the first Armstrong Number
   static int FindNthArmstrong (int n) {
      int count = 0;
      for (int i = 0; ; i++) {
         if (IsArmstrong (i)) {
            count++;
            if (count == n) return i;
         }
      }
   }

   static bool IsArmstrong (int n) {
      int sum = 0;
      for (int i = n; i > 0; i /= 10) sum += (int)Math.Pow (i % 10, n.ToString ().Length);
      return n == sum;
   }
}

