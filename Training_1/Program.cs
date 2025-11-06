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
   enum SortOrder { Ascending, Descending }
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
      if (string.IsNullOrWhiteSpace (splCharInput) || splCharInput.Length != 1 || !char.IsLetter (splCharInput[0])) {
         WriteLine ("Invalid special character input");
         return;
      }
      char splChar = splCharInput[0];
      Write ("Enter order ('ascending' or 'descending'), press Enter for default: ");
      string? orderInput = ReadLine ()?.Trim ().ToLower ();
      SortOrder order = string.IsNullOrWhiteSpace (orderInput) || orderInput != "descending" ? SortOrder.Ascending
                        : SortOrder.Descending;
      Sort (ref arr, splChar, order);
      WriteLine ($"Sorted output: {string.Join (',', arr)}");
   }

   // Sorts the array such that all occurrences of special character are at the end
   static void Sort (ref char[] arr, char splChar, SortOrder order) {
      var sorted = (order.Equals (SortOrder.Descending) ? arr.OrderByDescending (c => char.ToLower (c)) :
                   arr.OrderBy (c => char.ToLower (c))).ToArray ();
      var notSpl = sorted.Where (c => char.ToLower (c) != char.ToLower (splChar)).ToList ();
      var splChars = sorted.Where (c => char.ToLower (c) == splChar).ToList ();
      arr = [.. notSpl, .. splChars];
   }
}


