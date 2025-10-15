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
      if (!string.IsNullOrEmpty (str) && str.All (char.IsLetter)) {
         FindWinner (str.ToUpper (), out char winner, out int maxVotes);
         WriteLine ($"{winner},{maxVotes}");
      } else WriteLine ("Input should not be empty and should only contain alphabets.");
   }

   // Finds the winner and the no of votes received by the winner by counting the no of times each element appears
   // in the string
   static void FindWinner (string votes, out char winner, out int maxVotes) {
      List<int> noOfVotes = [];
      foreach (char c in votes) noOfVotes.Add ((votes.Count (a => a == c)));
      (maxVotes, winner) = (0, ' ');
      for (int i = 0; i < votes.Length; i++) {
         if (noOfVotes[i] > maxVotes) {
            maxVotes = noOfVotes[i];
            winner = votes[i];
         }
      }
   }
}
