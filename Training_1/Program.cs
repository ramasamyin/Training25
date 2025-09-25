// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
using System;
using System.Text;
namespace Training_1;
internal class Program {
   static void Main (string[] args) {
      Console.Write ("Enter a number: ");
      int n;
      StringBuilder sb = new ();
      while (!int.TryParse (Console.ReadLine (), out n)) Console.Write ("The number is not valid.\nEnter a number :");
      // Binary Conversion
      int tmp = n;
      while (tmp > 0) {
         sb.Insert (0, tmp % 2);
         tmp /= 2;
      }
      string binary = sb.ToString ();
      sb.Clear ();
      // Hexadecimal Conversion
      tmp = n;
      while (tmp > 0) {
         string str = (tmp % 16) switch {
            10 => "A",
            11 => "B",
            12 => "C",
            13 => "D",
            14 => "E",
            15 => "F",
            _ => (tmp % 16).ToString ()
         };
         sb.Insert (0, str);
         tmp /= 16;
      }
      Console.WriteLine ($"\nInput: {n}\nBinary: {binary}\nHexadecimal: {sb.ToString ()}");
   }
}


