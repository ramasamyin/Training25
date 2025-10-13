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
   static void Main (string[] args) {
      Write ("Enter a string for which adjacent matching letters must be deleted: ");
      string? word = ReadLine ()?.ToLower ();
      Stack<char> st = new ();
      if (!string.IsNullOrEmpty (word)) {
         foreach (char c in word) {
            if (st.Count > 0 && st.Peek () == c) st.Pop ();
            else st.Push (c);
         }
         var Arr = st.ToArray ();
         if (Arr.Length != 0) for (int i = Arr.Length - 1; i >= 0; i--) Write ($"Output: {Arr[i]}");
         else WriteLine ("Output: Empty string ");
      } else WriteLine ("Enter a valid input");
   }
}


