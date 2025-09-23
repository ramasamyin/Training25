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
         /// <summary>
         /// Converts a decimal number to binary and hexadecimal.
         /// Uses either manual division method or built-in Convert.ToString(number, base).
         /// </summary>
         int number = 0;
         Console.WriteLine ("Give a number as input");
         while (!int.TryParse (Console.ReadLine (), out number)) {
            Console.WriteLine ("\nThe number is not valid.");
         }
         // Binary Conversion
         List<int> binaryRemainders = new ();
         int tempNumber = number;
         while (tempNumber > 0) {
            binaryRemainders.Add (tempNumber % 2);
            tempNumber /= 2;
         }
         binaryRemainders.Reverse ();
         Console.WriteLine ($"\nInput: {number}");
         Console.Write ("Binary: ");
         foreach (int value in binaryRemainders) {
            Console.Write (value);
         }
         // Hexadecimal Conversion
         List<string> hexRemainders = new ();
         tempNumber = number;
         while (tempNumber > 0) {
            string strRemainder = (tempNumber % 16) switch {
               10 => "A",
               11 => "B",
               12 => "C",
               13 => "D",
               14 => "E",
               15 => "F",
               _ => (tempNumber % 16).ToString ()
            };
            hexRemainders.Add (strRemainder);
            tempNumber /= 16;
         }
         hexRemainders.Reverse ();
         Console.Write ("\nHexadecimal: ");
         foreach (string value in hexRemainders) {
            Console.Write (value);
         }
      }
   }
}
