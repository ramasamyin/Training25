// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T12 branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training_1;

internal class Program {
   static void Main () {
      Write ("Enter a string: ");
      string? str = ReadLine ();
      if (!string.IsNullOrEmpty (str) && str.Any (char.IsLetter)) {
         FindWinner (str.ToUpper (), out char winner, out int maxVotes);
         WriteLine ($"{winner},{maxVotes}");
      } else WriteLine ("Input should not be empty and should not contain digits.");
   }

   // Returns the winner and the no of votes received by the winner by counting the no of times each element appears
   // in the str, stores it in a list and applies Max() on the list
   static void FindWinner (string votes, out char winner, out int maxVotes) {
      List<int> noOfVotes = [];
      foreach (char c in votes) noOfVotes.Add ((votes.Count (a => a == c)));
      maxVotes = noOfVotes.Max ();
      winner = votes[noOfVotes.IndexOf (maxVotes)];
   }
}

