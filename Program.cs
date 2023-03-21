// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please input a string: ");
String toCheck = Console.ReadLine();

string[] ignoredChars = { " ", "_", "–", "—", "!", "\"", "#", "¤", "%", "&", "/", "(", ")", "=", "+", "`", "\\", ",", "." };

string toCheckTrimmed = toCheck;

for (int i = 0; i < ignoredChars.Length; i++)
{
    toCheckTrimmed = toCheckTrimmed.Replace(ignoredChars[i], "");
}


char[] strArray = toCheckTrimmed.ToCharArray();

Array.Reverse(strArray);

String reverseString = new string(strArray);

toCheckTrimmed = toCheckTrimmed.ToLower();
reverseString = reverseString.ToLower();


if (toCheckTrimmed.Equals(reverseString))
{
    Console.WriteLine(toCheckTrimmed + " is a palindrome.");
}
else
{
    Console.WriteLine(toCheckTrimmed + " is not a palindrome.");
}