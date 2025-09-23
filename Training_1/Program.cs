// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
namespace Training_1 {
   internal class Program {
      static void Main (string[] args) {
         int number = 0;
         Console.WriteLine ("Enter n (Which Armstrong number do you want) : ");
         int.TryParse (Console.ReadLine (), out number);
         FindNthArmstrong (number);

      }

      static void FindNthArmstrong (int nth) {

         int count = 0;

         for (int n1 = 0; ; n1++) {
            int sum = 0;
            int length = n1.ToString ().Length;
            foreach (char c in n1.ToString ()) {
               int digit = c - '0';
               sum += (int)Math.Pow (digit, length);

            }
            if (n1 == sum) {
               count++;
               if (count == nth) {
                  Console.WriteLine ($"\nThe Armstrong number - {nth} is {n1}");
                  return;
               }
            }

         }


      }
   }
}
