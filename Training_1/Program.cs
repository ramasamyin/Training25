// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T09 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_1;

internal class Program {
   static void Main () {
      Write ("Enter a string for which adjacent matching letters must be deleted: ");
      string? str = ReadLine ()?.ToLower ();
      if (!string.IsNullOrEmpty (str)) {
         int index = 0;
         var result = new char[str.Length];
         foreach (char c in str) {
            if (index > 0 && result[index - 1] == c) index--;
            else result[index++] = c;
         }
         Console.WriteLine ($"Output: {(index > 0 ? new string (result, 0, index) : "Empty string")}");
      } else WriteLine ("Enter a valid input");
   }
}
