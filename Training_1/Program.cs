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
      Console.WriteLine ("Enter a string which has to be reversed: ");
      string? word = Console.ReadLine ();
      if (!string.IsNullOrEmpty (word)) {
         char[] chars = word.ToCharArray ();
         Array.Reverse (chars);
         for (int i = 0; i < word.Length; i++) {
            if (char.IsUpper (word[i])) chars[i] = char.ToUpper (chars[i]);
            else if (char.IsLower (word[i])) chars[i] = char.ToLower (chars[i]);
         }
         Console.WriteLine (chars);
      } else Console.WriteLine ("No input provided.");
   }
}

