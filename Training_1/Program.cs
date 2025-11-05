// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T13 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_1;

internal class Program {
   static void Main () {
      Write ("Enter letters separated by comma: ");
      string? input = ReadLine ();
      if (string.IsNullOrWhiteSpace (input)) {
         WriteLine ("Input cannot be empty");
         return;
      }
      char[] arr = [.. input.Split (',').Select (char.Parse)];
      Write ("Enter special character: ");
      string? splCharInput = ReadLine ();
      if (string.IsNullOrWhiteSpace (splCharInput) || splCharInput.Length != 1) {
         WriteLine ("Invalid special character input");
         return;
      }
      char splChar = splCharInput[0];
      Write ("Enter order ('ascending' or 'descending'), press Enter for default: ");
      string? order = ReadLine ();
      if (string.IsNullOrWhiteSpace (order)) order = "ascending";
      Sort (ref arr, splChar, order);
      WriteLine ($"Sorted output: {string.Join (',', arr)}");
   }

   // Sorts the array such that all occurrences of special character are at the end
   static void Sort (ref char[] arr, char splChar, string order = "ascending") {
      if (arr == null || arr.Length == 0) {
         WriteLine ("Array is empty");
         return;
      }
      if (!char.IsLetter (splChar)) {
         WriteLine ("Special character must be an alphabet");
         return;
      }
      var sorted = (order.Equals ("descending")) ? arr.OrderByDescending (c => char.ToLower (c)).ToArray () : [.. arr.OrderBy (c => char.ToLower (c))];
      var notSpl = sorted.Where (c => char.ToLower (c) != Char.ToLower (splChar)).ToList ();
      var splChars = sorted.Where (c => char.ToLower (c) == splChar).ToList ();
      arr = [.. notSpl, .. splChars];
   }
}


