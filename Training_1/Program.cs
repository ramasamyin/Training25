// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
using System.Text;
namespace Training_1;
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Give a number as input");
      int n;
      StringBuilder sb = new StringBuilder ();
      while (!int.TryParse (Console.ReadLine (), out n)) Console.WriteLine ("\nThe number is not valid.");
      // Binary Conversion
      List<int> binaries = [];
      int tmp = n;
      while (tmp > 0) {
         sb.Insert (0, tmp % 2);
         tmp /= 2;
      }
      // Hexadecimal Conversion
      List<string> hexaDecimals = [];
      tmp = n;
      StringBuilder sbhexa = new StringBuilder ();
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
         sbhexa.Insert (0, str);
         tmp /= 16;
      }
      Console.WriteLine ($"\nInput: {n}\nBinary: {sb}\nHexadecimal: {sbhexa}");
   }
}


