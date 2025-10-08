// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T10 branch.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;
namespace Training_1;

internal class Program {
   static void Main (string[] args) {
      WriteLine ("Enter a string which has to be reversed: ");
      string? word = ReadLine ();
      if (!string.IsNullOrEmpty (word)) {
         char[] chars = word.ToCharArray ();
         char[] result = new char[chars.Length];
         int j = chars.Length - 1;
         for (int i = 0; i < chars.Length; i++) {
            if (chars[i] == ' ') result[i] = ' ';
         }
         for (int i = 0; i < chars.Length; i++) {
            if (chars[i] != ' ') {
               while (j >= 0 && result[j] == ' ') j--;
               result[j] = chars[i];
               j--;
            }
         }
         for (int i = 0; i < chars.Length; i++) {
            if (char.IsUpper (word[i])) result[i] = char.ToUpper (result[i]);
            else if (char.IsLower (word[i])) result[i] = char.ToLower (result[i]);
         }
         WriteLine (result);
      } else WriteLine ("No input provided.");
   }
}


