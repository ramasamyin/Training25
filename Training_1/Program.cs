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
      Console.WriteLine ("Give a number as input");
      int n;
      while (!int.TryParse (Console.ReadLine (), out n)) Console.WriteLine ("\nThe number is not valid.");
      // Binary Conversion
      List<int> binaries = [];
      int tmp = n;
      while (tmp > 0) {
         binaries.Add (tmp % 2);
         tmp /= 2;
      }
      binaries.Reverse ();
      string binaryString = string.Join ("", binaries);
      // Hexadecimal Conversion
      List<string> hexaDecimals = [];
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
         hexaDecimals.Add (str);
         tmp /= 16;
      }
      hexaDecimals.Reverse ();
      string hexString = string.Join ("", hexaDecimals);
      Console.WriteLine ($"\nInput: {n}\nBinary: {binaryString}\nHexadecimal: {hexString}");
   }
}

