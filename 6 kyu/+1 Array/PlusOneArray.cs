using System;
using System.Linq;

public class PlusOneArray
{
    public static int[] UpArray(int[] num)
    {
        if (!IsValid(num))
        {
            return null;
        }

        var needInsert = false;
        for (int i = num.Length - 1; i >= 0; i--)
        {
            var number = num[i];
            if (number >= 9)
            {
                num[i] = 0;
                if (i == 0)
                {
                    needInsert = true;
                }
            }
            else
            {
                num[i]++;
                break;
            }
        }

        if (needInsert)
        {
            var newArray = new int[num.Length + 1];
            newArray[0] = 1;
            Array.Copy(num, 0, newArray, 1, num.Length);
            num = newArray;
        }

        if (num.Length == 0)
        {
            return null;
        }
        
        return num;
    }

    private static bool IsValid(int[] num)
    {
        if (num == null)
        {
            return false;
        }

        foreach (var number in num)
        {
            if (number < 0 || number > 9)
            {
                return false;
            }
        }

        return true;
    }
}