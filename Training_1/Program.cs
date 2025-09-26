// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
using System.Text;

namespace Training_1 {
   internal class Program {
      static void Main (string[] args) {
         StringBuilder sb = new ();
         string? word = Console.ReadLine ();
         char[] Special = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+' };
         if (string.IsNullOrEmpty (word)) Console.WriteLine ("You haven't entered anything.");
         else {
            if (word.Length < 6) Append (sb, "The length must be atleast 6.");
            if (!word.Any (char.IsDigit)) Append (sb, "It must contain atleast one digit.");
            if (!word.Any (char.IsUpper)) Append (sb, "It must contain atleast one Uppercase letter.");
            if (!word.Any (char.IsLower)) Append (sb, "It must contain atleast one Lowercase letter.");
            if (!Special.Any (s => word.Contains (s))) Append (sb, "It must contain atleast one special character (!@#$%^&*()-+).");
            if (sb.Length > 0) Console.WriteLine ($"The password is not strong.\n{sb}");
            else Console.WriteLine ("Password is strong");
         }
      }

      static void Append (StringBuilder sb, string str) => sb.AppendLine (str);
   }
}

