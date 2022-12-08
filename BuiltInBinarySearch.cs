// C# code below
using System;
using System.IO;

public class Answer
{
    public static bool Exists(int[] ints, int k)
    {
        int result = Array.BinarySearch(ints, k);
        Console.WriteLine(result.ToString());
        if (result < 0 || result > ints.Length)
        {
            return false;
        }
        return true;
    }
}
