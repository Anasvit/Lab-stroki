// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//
using System;
public class PhoneNumber
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        if (numbers.Length != 10)
        {
            throw new ArgumentException("Массив должен содержать 10 цифр");
        }

        return string.Format("({0}{1}{2}) {3}{4}{5}–{6}{7}–{8}{9}",
            numbers[0], numbers[1], numbers[2],
            numbers[3], numbers[4], numbers[5],
            numbers[6], numbers[7],
            numbers[8], numbers[9]
        );
    }
}

public class StringUtil
{
    public static string TrimString(string phrase, int len)
    {
        if (phrase.Length <= len)
        {
            return phrase;
        }

        if (len <= 3)
        {
            return phrase.Substring(0, len) + "...";
        }

        return phrase.Substring(0, len - 3) + "...";
    }
}

public class NumberUtil
{
    public static long SquareDigits(long n)
    {
        string numberStr = n.ToString();
        string result = "";

        foreach (char digit in numberStr)
        {
            int digitValue = int.Parse(digit.ToString());
            result += (digitValue * digitValue).ToString();
        }

        return long.Parse(result);
    }
}


public class Likess
{
    public static string Likes(string[] names)
    {
        int count = names.Length;

        if (count == 0)
        {
            return "no one likes this";
        }
        else if (count == 1)
        {
            return $"{names[0]} likes this";
        }
        else if (count == 2)
        {
            return $"{names[0]} and {names[1]} like this";
        }
        else if (count == 3)
        {
            return $"{names[0]}, {names[1]} and {names[2]} like this";
        }
        else
        {
            return $"{names[0]}, {names[1]} and {count - 2} others like this";
        }
    }
}