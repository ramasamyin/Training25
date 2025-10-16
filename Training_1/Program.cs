// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on T08 branch.
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;
namespace Training_1;

internal class Program {
   static void Main () {
      StringBuilder errors = new ();
      Write ("Enter a password: ");
      string? input = ReadLine ();
      char[] splChars = "!@#$%^&*()-+".ToCharArray ();
      if (string.IsNullOrEmpty (input)) WriteLine ("Input is empty");
      else {
         if (input.Length < 6) Append ("The length must be atleast 6.");
         if (!splChars.Any (input.Contains)) Append ("It must contain at least one special character (!@#$%^&*()-+).");
         bool hasDigit = false, hasUpper = false, hasLower = false;
         foreach (char c in input) {
            if (char.IsDigit (c)) hasDigit = true;
            else if (char.IsUpper (c)) hasUpper = true;
            else if (char.IsLower (c)) hasLower = true;
         }
         if (!hasDigit) Append ("It must contain at least one digit.");
         if (!hasLower) Append ("It must contain at least one lowercase letter.");
         if (!hasUpper) Append ("It must contain at least one uppercase letter.");
         WriteLine (errors.Length > 0 ? $"The password is not strong.\n{errors}" : "Password is strong");

         // Adds the string to a string builder
         void Append (string str) => errors.AppendLine (str);
      }
   }
}





