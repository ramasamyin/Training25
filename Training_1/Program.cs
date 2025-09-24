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
      for (int i = 1; i <= 10; i++) {
         for (int j = 1; j <= 10; j++) Console.WriteLine ($"{i,2} * {j,2} = {i * j,3}");
         Console.WriteLine ();
      }
   }
}

