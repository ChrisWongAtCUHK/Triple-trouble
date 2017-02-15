using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Kata
{
    public static int TripleDouble(long num1, long num2)
    {
        MatchCollection num1Straight = StraightNum(num1, 3);
        MatchCollection num2Straight = StraightNum(num2, 2);

        // try to match all triples and doubles
        foreach (Match match1 in num1Straight)
        {
            foreach (Match match2 in num2Straight)
            {
                if(match1.Groups[1].Value == match2.Groups[1].Value)
                {
                    return 1;
                }
            }
        }

        return 0;
    }

    /// <summary>
    /// Get the number of straight
    /// </summary>
    /// <param name="num"></param>
    /// <param name="length"></param>
    /// <returns></returns>
    static MatchCollection StraightNum(long num, int length)
    {
        MatchCollection matches = Regex.Matches(String.Format("{0}", num), @"(\d)\1{" + (length - 1) + "}");

        // Here we check the Match instance.
        return matches;
    }
}

