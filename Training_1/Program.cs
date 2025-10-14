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
      Write ("Enter an input: ");
      string? str = ReadLine ();
      if (String.IsNullOrEmpty (str)) WriteLine ("No input is entered");
      else {
         FindWinner (str.ToUpper (), out char winner, out int wVotes);
         WriteLine ($"{winner},{wVotes}");
      }
   }

   // Returns the winner and the number of votes received by the winner
   // by counting the no of times each element appears in the str ,stores it in a list and applies Max() on the list
   static void FindWinner (string votes, out char winner, out int wVotes) {
      List<int> myInts = [];
      foreach (char c in votes) myInts.Add ((votes.Count (a => a == c)));
      wVotes = myInts.Max ();
      winner = votes[wVotes];
   }
}

