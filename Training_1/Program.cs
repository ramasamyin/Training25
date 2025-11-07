// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T13 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_1;

enum SortOrder { Ascending, Descending }
internal class Program {
   static void Main () {
      Write ("Enter letters separated by comma: ");
      string? input = ReadLine ();
      if (string.IsNullOrWhiteSpace (input)) {
         WriteLine ("Input cannot be empty");
         return;
      }
      char[] arr = [.. input.Split (',').Select (s => char.ToLower (char.Parse (s)))];
      Write ("Enter special character: ");
      string? splChars = ReadLine ();
      if (string.IsNullOrWhiteSpace (splChars) || splChars.Length != 1 || !char.IsLetter (splChars[0])) {
         WriteLine ("Invalid special character input");
         return;
      }
      char splChar = char.ToLower (splChars[0]);
      Write ("Enter order 'a' for (ascending) or 'd' for (descending), press Enter for default (ascending): ");
      SortOrder order = (ReadKey ().Key == ConsoleKey.D) ? SortOrder.Descending : SortOrder.Ascending;
      Sort (ref arr, splChar, order);
      WriteLine ($"\nSorted output: {string.Join (',', arr)}");
   }

   // Sorts the array such that all occurrences of special character are at the end
   static void Sort (ref char[] arr, char splChar, SortOrder order) {
      var sorted = (order.Equals (SortOrder.Descending) ? arr.OrderByDescending (c => c) :
                   arr.OrderBy (c => c)).ToArray ();
      var notSpl = sorted.Where (c => c != splChar).ToList ();
      var splChars = sorted.Where (c => c == splChar).ToList ();
      arr = [.. notSpl, .. splChars];
   }
}




