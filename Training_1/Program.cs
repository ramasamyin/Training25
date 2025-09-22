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

         int inputNumber = 0;
         bool isValidNumber = false;

         while (!isValidNumber) {
            Console.WriteLine ("Type in a decimal number");
            isValidNumber = int.TryParse (Console.ReadLine (), out inputNumber);

            if (!isValidNumber) {
               Console.WriteLine ("\nThe number is not valid.");
            }

         }

         Console.WriteLine ($"\nInput: {inputNumber}");

         //binary conversion
         Console.WriteLine ($"Binary: {Convert.ToString (inputNumber, 2)}");

         //hexadecimal conversion
         Console.WriteLine ($"HEX: {Convert.ToString (inputNumber, 16).ToUpper ()}");

      }
   }
}
