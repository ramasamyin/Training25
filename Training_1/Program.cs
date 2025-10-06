// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T05 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_1;

internal class Program {
   static void Main (string[] args) {
      int n = 10;
      for (int i = 1; i <= n; i++) {
         for (int j = 1; j <= n; j++) WriteLine ($"{i,2} * {j,2} = {i * j}");
         WriteLine ();
      }
   }
}

