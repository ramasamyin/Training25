// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_1;

internal class Program {
   static void Main () {
      WriteLine ("Enter letters separated by comma");
      string? input = ReadLine ();
      if (string.IsNullOrWhiteSpace (input)) {
         WriteLine ("Input cannot be empty");
         return;
      }
      char[] arr = [.. input.Split (',').Select (char.Parse)];
      WriteLine ("Enter special character");
      string? specialInput = ReadLine ();
      if (string.IsNullOrWhiteSpace (specialInput) || specialInput.Length != 1) {
         WriteLine ("Invalid special character input");
         return;
      }
      char special = specialInput[0];
      WriteLine ("Enter order (ascending or descending), press Enter for default");
      string? order = ReadLine ();
      if (string.IsNullOrWhiteSpace (order)) order = "ascending";
      Sort (ref arr, special, order);
      WriteLine ($"Sorted output: {string.Join (',', arr)}");

   }

   // Sorts the array such that all occurrences of special character are at the end
   static void Sort (ref char[] A, char S, string O = "ascending") {
      if (A == null || A.Length == 0) {
         WriteLine ("Array is empty");
         return;
      }
      if (!char.IsLetter (S)) {
         WriteLine ("Special character must be an alphabet");
         return;
      }
      char special = char.ToLower (S);
      var sorted = (O.Equals ("descending")) ? A.OrderByDescending (c => char.ToLower (c)).ToArray () : [.. A.OrderBy (c => char.ToLower (c))];
      var notSpl = sorted.Where (c => char.ToLower (c) != special).ToList ();
      var splChars = sorted.Where (c => char.ToLower (c) == special).ToList ();
      A = [.. notSpl, .. splChars];

   }
}


