// C# code below
using System;
using System.IO;

public class Answer
{
    public static bool Exists(int[] ints, int k)
    {
        // base case
        if (ints.Length < 2)
        {
            if (ints.Length == 0)
            {
                return false;
            }

            if (ints[0] == k)
            {
                return true;
            }
        }

        int lower = 0;
        int upper = ints.Length - 1; 

        if ( k < ints[lower] || k > ints[upper])
        {
            return false;
        } 
        else if ( k == ints[lower] || k == ints[upper])
        {
            return true;
        }

        do
        {
            if  (lower == upper)
            {
                return false; // at end of search 
            }

            int middle = lower + (upper - lower) / 2;
            
            if ( ints[middle] == k)
            {
                return true; // number found 
            }

            if ( k < ints[middle])
            {
                upper = Math.Max(lower, middle - 1);
            }
            else
            {
                lower = Math.Max(upper, middle + 1);
            }
            
        } while (true);

    }
}
