// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T04 branch.
// ------------------------------------------------------------------------------------------------
using System.Text;
namespace Training_1;

internal class Program {
   static void Main (string[] args) {
      Console.OutputEncoding = new UnicodeEncoding ();
      char[] whitePieces = { '\u2656', '\u2658', '\u2657', '\u2655', '\u2654', '\u2657', '\u2658', '\u2656' };
      char[] blackPieces = { '\u265C', '\u265E', '\u265D', '\u265B', '\u265A', '\u265D', '\u265E', '\u265C' };
      char whitePawn = '\u2659', blackPawn = '\u265F';
      char[,] board = new char[8, 8];
      for (int i = 0; i < 8; i++) {
         for (int j = 0; j < 8; j++) board[i, j] = ' ';
      }
      for (int i = 0; i < 8; i++) {
         board[0, i] = blackPieces[i];
         board[1, i] = blackPawn;
         board[7, i] = whitePieces[i];
         board[6, i] = whitePawn;
      }
      Console.WriteLine ("┌────┬────┬────┬────┬────┬────┬────┬────┐");
      for (int i = 0; i < 8; i++) {
         Console.Write ("│");
         for (int j = 0; j < 8; j++) Console.Write ($" {board[i, j]}  │");
         Console.WriteLine ();
         if (i < 7) Console.WriteLine ("├────┼────┼────┼────┼────┼────┼────┼────┤");
      }
      Console.WriteLine ("└────┴────┴────┴────┴────┴────┴────┴────┘");
   }
}
