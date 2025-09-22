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
         int number1;
         int number2;

         Console.WriteLine ("Type in a number");
         int.TryParse (Console.ReadLine (), out number1);
         Console.WriteLine ("Type in the second number");
         int.TryParse (Console.ReadLine (), out number2);

         if (number1 == 0 || number2 == 0) {
            Console.WriteLine ("GCD: 0");
            Console.WriteLine ("LCM: 0");

         } else {
            int num1 = number1;
            int num2 = number2;
            int remainder;

            do {

               remainder = number1 % number2;
               number1 = number2;
               number2 = remainder;



            } while (remainder != 0);

            Console.WriteLine ($"\nGCD: {number1}");
            Console.WriteLine ($"LCM: {(num1 * num2) / number1}");


         }

      }
   }
}
