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
      StringBuilder sb = new ();
      Write ("Enter an input: ");
      string? input = ReadLine ();
      char[] spl = ['!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+'];
      if (string.IsNullOrEmpty (input)) WriteLine ("Input is empty");
      else {
         if (input.Length < 6) Append (sb, "The length must be atleast 6.");
         if (!input.Any (char.IsDigit)) Append (sb, "It must contain atleast one digit.");
         if (!input.Any (char.IsUpper)) Append (sb, "It must contain atleast one Uppercase letter.");
         if (!input.Any (char.IsLower)) Append (sb, "It must contain atleast one Lowercase letter.");
         if (!spl.Any (s => input.Contains (s))) Append (sb, "It must contain atleast one special character (!@#$%^&*()-+).");
         if (sb.Length > 0) WriteLine ($"The password is not strong.\n{sb}");
         else WriteLine ("Password is strong");
      }
   }

   // Adds the string to a string builder
   static void Append (StringBuilder sb, string str) => sb.AppendLine (str);
}

