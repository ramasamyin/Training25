// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
namespace Training_1 {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter an input: ");
         string? input = Console.ReadLine ();
         if (String.IsNullOrEmpty (input)) Console.WriteLine ("No input is entered");
         else {
            FindWinner (input.ToUpper (), out char winner, out int wVotes);
            Console.WriteLine ($"{winner},{wVotes}");
         }

      }

      static void FindWinner (string votes, out char winner, out int wVotes) {
         List<int> myInts = [];
         foreach (char c in votes) myInts.Add ((votes.Count (a => a == c)));
         wVotes = myInts.Max ();
         winner = votes[wVotes];
      }
   }
}
