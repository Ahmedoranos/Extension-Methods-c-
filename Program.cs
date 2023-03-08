using System;					
public class Program
{
	public static void Main()
	{
		string str = "ahmed";
		string method_result = str.ChangeFirstLetterCase();
	}
}
public static class StringHelper
{
	public static string ChangeFirstLetterCase(this string inputString)
	{
		if (inputString.Length > 0)
        {
            char[] charArray = inputString.ToCharArray();
            charArray[0] = char.IsUpper(charArray[0]) ?
                char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
            return new string(charArray);
        }
        return inputString;
	}
}
