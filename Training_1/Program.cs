// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T10 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_1;

internal class Program {
   static void Main (string[] args) {
      Write ("Enter a string which has to be reversed: ");
      string? word = ReadLine ();
      if (!string.IsNullOrEmpty (word)) {
         char[] chars = word.ToCharArray ();
         int len = chars.Length;
         char[] result = new char[len];
         for (int i = 0, j = len - 1; i < len; i++) {
            if (Char.IsWhiteSpace (chars[i])) result[i] = ' ';
            else {
               while (j >= 0 && word[j] == ' ') j--;
               char ch = chars[j--];
               result[i] = char.IsUpper (word[i]) ? char.ToUpper (ch) : char.ToLower (ch);
            }
         }
         WriteLine (result);
      } else WriteLine ("Empty string");
   }
}



