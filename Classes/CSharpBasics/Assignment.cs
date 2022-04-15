using System;

namespace Assignments;
class Assignment
{

    public static (int sum, decimal avg) NumbersMethod(params int[] arrays)
    {
        int sum = 0;
        decimal avg = 0;
        for (int i = 0; i < arrays.Length; i++)
        {
            sum += arrays[i];
        }
        avg = (decimal)sum / arrays.Length;
        return (sum, avg);
    }

}