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
      Console.WriteLine ("Enter n - Which Armstrong number do you want (upto 25) : ");
      int.TryParse (Console.ReadLine (), out int n);
      FindNthArmstrong (n);
   }

   //0 is included as the first Armstrong Number
   static void FindNthArmstrong (int n) {
      int count = 0;
      for (int i = 0; ; i++) {
         var (sum, len) = (0, i.ToString ().Length);
         for (int j = i; j > 0; j /= 10) sum += (int)Math.Pow (j % 10, len);
         if (i == sum) {
            count++;
            if (count == n) {
               Console.WriteLine ($"\nThe {n}th Armstrong number is {i}");
               return;
            }
         }
      }
   }
}

