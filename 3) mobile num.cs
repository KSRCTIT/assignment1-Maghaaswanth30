using System;
using System.Text.RegularExpressions;
class Validation
{
 static void Main()
 {
 // Prompt the user to enter the mobile number
 Console.Write("Enter the mobile number: ");
 string mobileNumber = Console.ReadLine();
 // Validate the mobile number
 if (IsValidMobileNumber(mobileNumber))
 {
 Console.WriteLine("The mobile number is valid.");
 }
 else
 {
 Console.WriteLine("The mobile number is invalid.");
 }
 }
 static bool IsValidMobileNumber(string mobileNumber)
 {
 // Check the format using a regular expression
 // Pattern explanation:
 // ^ : Start of string
 // [98] : The first digit should be 9 or 8
 // [0-9]{3} : The next three digits should be numbers
 // - : A hyphen
 // [0-9]{6} : The next six digits should be numbers
 // $ : End of string
 string pattern = @"^[98][0-9]{3}-[0-9]{6}$";
 if (Regex.IsMatch(mobileNumber, pattern))
 {
 return true;
 }
 return false;
 }
}