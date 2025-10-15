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

   // Determines the character with the highest number of votes from a given string
   static void FindWinner (string votes, out char winner, out int maxVotes) {
      Dictionary<char, int> voteCounts = [];
      (maxVotes, winner) = (0, ' ');
      foreach (char c in votes) {
         voteCounts[c] = voteCounts.TryGetValue (c, out int value) ? ++value : 1;
         if (voteCounts[c] > maxVotes) (maxVotes, winner) = (voteCounts[c], c);
      }
   }
}

