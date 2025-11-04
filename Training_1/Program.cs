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
      OutputEncoding = new UnicodeEncoding ();
      const int BoardSize = 8;
      char[] whitePieces = { '\u2656', '\u2658', '\u2657', '\u2655', '\u2654', '\u2657', '\u2658', '\u2656' };
      char[] blackPieces = { '\u265C', '\u265E', '\u265D', '\u265B', '\u265A', '\u265D', '\u265E', '\u265C' };
      char whitePawn = '\u2659', blackPawn = '\u265F';
      char[,] board = new char[BoardSize, BoardSize];
      for (int i = 0; i < BoardSize; i++) {
         for (int j = 0; j < BoardSize; j++) {
            board[i, j] = i switch {
               0 => blackPieces[j],
               1 => blackPawn,
               6 => whitePawn,
               7 => whitePieces[j],
               _ => ' '
            };
         }
      }
      WriteLine ("┌────┬────┬────┬────┬────┬────┬────┬────┐");
      for (int i = 0; i < BoardSize; i++) {
         Write ("│");
         for (int j = 0; j < BoardSize; j++) Write ($" {board[i, j]}  │");
         WriteLine ();
         if (i < 7) WriteLine ("├────┼────┼────┼────┼────┼────┼────┼────┤");
      }
      WriteLine ("└────┴────┴────┴────┴────┴────┴────┴────┘");
   }
}
