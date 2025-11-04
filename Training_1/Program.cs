// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T04 branch.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;
namespace Training_1;

internal class Program {
   static void Main () {
      Console.OutputEncoding = new UnicodeEncoding ();
      char[] whitePieces = { '\u2656', '\u2658', '\u2657', '\u2655', '\u2654', '\u2657', '\u2658', '\u2656' };
      char[] blackPieces = { '\u265C', '\u265E', '\u265D', '\u265B', '\u265A', '\u265D', '\u265E', '\u265C' };
      char whitePawn = '\u2659', blackPawn = '\u265F';
      char[,] board = new char[8, 8];
      for (int i = 0; i < 8; i++) {
         for (int j = 0; j < 8; j++) {
            if (i == 0) board[i, j] = blackPieces[j];
            else if (i == 1) board[i, j] = blackPawn;
            else if (i == 6) board[i, j] = whitePawn;
            else if (i == 7) board[i, j] = whitePieces[j];
            else board[i, j] = ' ';
         }
      }
      WriteLine ("┌────┬────┬────┬────┬────┬────┬────┬────┐");
      for (int i = 0; i < 8; i++) {
         Write ("│");
         for (int j = 0; j < 8; j++) Write ($" {board[i, j]}  │");
         WriteLine ();
         if (i < 7) WriteLine ("├────┼────┼────┼────┼────┼────┼────┼────┤");
      }
      WriteLine ("└────┴────┴────┴────┴────┴────┴────┴────┘");
   }
}
