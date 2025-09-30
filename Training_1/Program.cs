// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T06 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_1;

internal class Program {
   static void Main (string[] args) {
      Write ("Enter a number: ");
      int n;
      while (!int.TryParse (ReadLine (), out n)) Write ("Please enter a valid number: ");
      while (n >= 10) {
         int sum = 0;
         for (int i = n; i > 0; i /= 10) sum += i % 10;
         n = sum;
      }
      WriteLine ($"The digital root is {n}");
   }
}

