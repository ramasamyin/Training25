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
      int n1, n2;
      Print ("Enter the first number: ");
      while (!int.TryParse (Console.ReadLine (), out n1)) Print ("The input is not valid.\nEnter another number: ");
      Print ("Enter the second number: ");
      while (!int.TryParse (Console.ReadLine (), out n2)) Print ("The input is not valid.\nEnter another number: ");
      if (n1 == 0 || n2 == 0) {
         Print ("\nGCD: 0\nLCM: 0");
      } else {
         var (num1, num2) = (n1, n2);
         int rem = -1;
         while (rem != 0) {
            rem = n1 % n2;
            (n1, n2) = (n2, rem);
         }
         ;
         Print ($"\nGCD: {n1}\nLCM: {(num1 * num2) / n1}");
      }
   }

   static void Print (string str) => Console.Write (str);
}


