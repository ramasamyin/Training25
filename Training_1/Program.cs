// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on Test2 branch.
// ------------------------------------------------------------------------------------------------
namespace Training_1;

internal class Program {
   static void Main () {
      Console.WriteLine ("Enter row-1 elements separated by a space");
      int[] row1 = [.. Console.ReadLine ()!.Split (' ').Select (int.Parse)];
      Console.WriteLine ("Enter row-2 elements separated by a space");
      int[] row2 = [.. Console.ReadLine ()!.Split (' ').Select (int.Parse)];
      Console.WriteLine ("Enter row-3 elements separated by a space");
      int[] row3 = [.. Console.ReadLine ()!.Split (' ').Select (int.Parse)];
      int[,] array2D = new int[3, 3] {
                { row1[0], row1[1], row1[2] },
                { row2[0], row2[1], row2[2] },
                { row3[0], row3[1], row3[2] }
      };
      for (int i = 0; i < 3;) {
         int sum1 = array2D[i, 0] + array2D[i, 1] + array2D[i, 2];
         int sum2 = array2D[0, i] + array2D[1, i] + array2D[2, i];
         int sum3 = array2D[0, 0] + array2D[1, 1] + array2D[2, 2];
         int sum4 = array2D[0, 2] + array2D[1, 1] + array2D[2, 0];
         if (sum1 == sum2 && sum2 == sum3 && sum3 == sum4) {
            Console.WriteLine ("The given 3x3 matrix is a magic square.");
            break;
         } else {
            Console.WriteLine ("The given 3x3 matrix is not a magic square.");
            break;
         }
      }
   }
}

