// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T09 branch.
// ------------------------------------------------------------------------------------------------
namespace Training_1;

internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter a string for which adjacent matching letters must be deleted ");
      string? word = Console.ReadLine ()?.ToLower ();
      Stack<char> st = new ();
      if (!string.IsNullOrEmpty (word)) {
         foreach (char c in word) {
            if (st.Count > 0 && st.Peek () == c) st.Pop ();
            else st.Push (c);
         }
         var Arr = st.ToArray ();
         Array.Reverse (Arr);
         if (Arr.Length != 0) {
            Console.Write ($"\nOutput: " + new string (Arr));
         } else Console.WriteLine ($"Output: Empty string ");
      } else Console.WriteLine ("Enter a valid input");
   }
}
