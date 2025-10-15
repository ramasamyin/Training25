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
      Write ("Enter an input: ");
      string? input = ReadLine ();
      char[] splChars = "!@#$%^&*()-+".ToCharArray ();
      if (string.IsNullOrEmpty (input)) WriteLine ("Input is empty");
      else {
         if (input.Length < 6) Append (errors, "The length must be atleast 6.");
         if (!input.Any (char.IsDigit)) Append (errors, "It must contain atleast one digit.");
         if (!input.Any (char.IsUpper)) Append (errors, "It must contain atleast one Uppercase letter.");
         if (!input.Any (char.IsLower)) Append (errors, "It must contain atleast one Lowercase letter.");
         if (!splChars.Any (s => input.Contains (s))) Append (errors, "It must contain atleast one special character (!@#$%^&*()-+).");
         WriteLine (errors.Length > 0 ? $"The password is not strong.\n{errors}" : "Password is strong");
      }
   }

   // Adds the string to a string builder
   static void Append (StringBuilder sb, string str) => sb.AppendLine (str);
}

