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

         /// <summary>
         /// Converts a decimal number to binary and hexadecimal.
         /// Uses either manual division method or built-in Convert.ToString(number, base).
         /// </summary>


         Console.WriteLine ("Give a number as input");
         int number = 0;
         bool isValid = false;

         while (!isValid) {
            Console.WriteLine ("Type in a decimal number");
            isValid = int.TryParse (Console.ReadLine (), out number);

            if (!isValid) {
               Console.WriteLine ("\nThe number is not valid.");
            }
         }

         int originalNumber = number;

         // Binary Conversion
         List<int> binaryRemainders = new List<int> ();
         int tempNumber = number;
         while (tempNumber > 0) {
            int remainder = tempNumber % 2;
            binaryRemainders.Add (remainder);
            tempNumber /= 2;
         }
         binaryRemainders.Reverse ();

         Console.WriteLine ($"\nInput: {originalNumber}");
         Console.Write ("Binary: ");
         foreach (int value in binaryRemainders) {
            Console.Write (value);
         }

         // Hexadecimal Conversion
         List<string> hexRemainders = new List<string> ();
         tempNumber = number;
         while (tempNumber > 0) {

            int remainder = tempNumber % 16;
            string strRemainder;

            switch (remainder) {
               case 10: strRemainder = "A"; break;
               case 11: strRemainder = "B"; break;
               case 12: strRemainder = "C"; break;
               case 13: strRemainder = "D"; break;
               case 14: strRemainder = "E"; break;
               case 15: strRemainder = "F"; break;
               default: strRemainder = remainder.ToString (); break;
            }


            hexRemainders.Add (strRemainder);
            tempNumber /= 16;
         }
         hexRemainders.Reverse ();

         Console.Write ("\nHexadecimal: ");
         foreach (string value in hexRemainders) {
            Console.Write (value);
         }
      }

   }
}
