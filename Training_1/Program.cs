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
      GetValidInput ("Enter the first number: ", out int n1);
      GetValidInput ("Enter the second number: ", out int n2);
      if (n1 == 0 || n2 == 0) Print ("\nGCD: 0\nLCM: 0");
      else {
         var (rem, prod) = (-1, n1 * n2);
         while (rem != 0) {
            rem = n1 % n2;
            (n1, n2) = (n2, rem);
         }
         Print ($"\nGCD: {n1}\nLCM: {prod / n1}");
      }
   }

   static void GetValidInput (string prompt, out int n) {
      Print (prompt);
      while (!int.TryParse (Console.ReadLine (), out n)) Print ("Enter a valid input: ");
   }

   static void Print (string str) => Console.Write (str);
}
