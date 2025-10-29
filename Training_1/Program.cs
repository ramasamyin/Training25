// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on Test3 branch.
// ------------------------------------------------------------------------------------------------
namespace Training_1;

internal class Program {
   static void Main () {
      Console.Write ("Enter an input (1-16384): ");
      int n;
      while (!int.TryParse (Console.ReadLine (), out n) || n < 1 || n > 16384) Console.Write ("Enter a valid input: ");
      char firstChar = 'A';
      if (n <= 26) {
         char result = (char)(firstChar + (n - 1));
         Console.WriteLine (result);
      }
      if (n >= 27 && n <= 702) {
         int firstIndex = (n - 1) / 26;
         int secondIndex = (n - 1) % 26;
         char firstCharResult = (char)(firstChar + (firstIndex - 1));
         char secondCharResult = (char)(firstChar + secondIndex);
         Console.WriteLine ($"{firstCharResult}{secondCharResult}");
      }
      if (n >= 703 && n <= 16384) {
         int firstIndex = (n - 1) / (26 * 26);
         int secondIndex = (n - 1) % (26 * 26);
         int thirdIndex = secondIndex % 26;
         char firstCharResult = (char)(firstChar + (firstIndex - 1));
         char secondCharResult = (char)(firstChar + ((secondIndex / 26) - 1));
         char thirdCharResult = (char)(firstChar + thirdIndex);
         Console.WriteLine ($"{firstCharResult}{secondCharResult}{thirdCharResult}");
      }
   }
}



