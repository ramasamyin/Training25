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

[Flags]
enum PasswordIssues {
   None = 0,
   TooShort = 1 << 0,
   MissingDigit = 1 << 1,
   MissingLower = 1 << 2,
   MissingUpper = 1 << 3,
   MissingSpecial = 1 << 4
}

internal class Program {
   static void Main () {
      StringBuilder errors = new ();
      Write ("Enter a password: ");
      string? input = ReadLine ();
      PasswordIssues issues = PasswordIssues.None;
      if (string.IsNullOrEmpty (input)) {
         WriteLine ("Input is empty");
         return;
      }
      var specials = "!@#$%^&*()-+";
      if (input.Length < 6) issues |= PasswordIssues.TooShort;
      issues |= PasswordIssues.MissingDigit | PasswordIssues.MissingLower |
          PasswordIssues.MissingUpper | PasswordIssues.MissingSpecial;
      foreach (char c in input) {
         if (char.IsDigit (c))
            issues &= ~PasswordIssues.MissingDigit;
         if (char.IsLower (c))
            issues &= ~PasswordIssues.MissingLower;
         if (char.IsUpper (c))
            issues &= ~PasswordIssues.MissingUpper;
         if (specials.Contains (c))
            issues &= ~PasswordIssues.MissingSpecial;
      }
      if (issues == PasswordIssues.None) {
         Console.WriteLine ("Password is strong");
         return;
      }
      Console.WriteLine ("The password is not strong.");
      if (issues.HasFlag (PasswordIssues.TooShort))
         errors.AppendLine ("The length must be at least 6.");
      if (issues.HasFlag (PasswordIssues.MissingDigit))
         errors.AppendLine ("It must contain at least one digit.");
      if (issues.HasFlag (PasswordIssues.MissingLower))
         errors.AppendLine ("It must contain at least one lowercase letter.");
      if (issues.HasFlag (PasswordIssues.MissingUpper))
         errors.AppendLine ("It must contain at least one uppercase letter.");
      if (issues.HasFlag (PasswordIssues.MissingSpecial))
         errors.AppendLine ("It must contain at least one special character. (!@#$%^&*()-+)");
      Console.WriteLine (errors);
   }
}
