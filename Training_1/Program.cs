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
         if (!ContainsDigit (input)) Append (errors, "It must contain atleast one digit.");
         if (!ContainsUppercase (input)) Append (errors, "It must contain atleast one Uppercase letter.");
         if (!ContainsLowercase (input)) Append (errors, "It must contain atleast one Lowercase letter.");
         if (!ContainsSpecialChar (input, splChars)) Append (errors, "It must contain atleast one special character (!@#$%^&*()-+).");
         WriteLine (errors.Length > 0 ? $"The password is not strong.\n{errors}" : "Password is strong");
      }
   }

   // Adds the string to a string builder
   static void Append (StringBuilder sb, string str) => sb.AppendLine (str);

   //Returns true if there is a digit in the string
   static bool ContainsDigit (string s) {
      foreach (char c in s) {
         if (char.IsDigit (c))
            return true;
      }
      return false;
   }

   //Returns true if there is a lowercase alphabet in the string
   static bool ContainsLowercase (string s) {
      foreach (char c in s) {
         if (char.IsLower (c))
            return true;
      }
      return false;
   }

   //Returns true if there is a special character in the string
   static bool ContainsSpecialChar (string s, char[] specialChars) {
      foreach (char c in s) {
         foreach (char sc in specialChars) {
            if (c == sc)
               return true;
         }
      }
      return false;
   }

   //Returns true if there is a uppercase alphabet in the string
   static bool ContainsUppercase (string s) {
      foreach (char c in s) {
         if (char.IsUpper (c))
            return true;
      }
      return false;
   }
}

