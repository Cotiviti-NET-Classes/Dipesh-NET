using System;

namespace Assignments;
class Assignment1
{

    //This method by using multiple parameters.
    public static (int sum, decimal avg) NumbersMethodParam(params int[] arrays)
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

    //This method by using arrays.
    public static (int sum, decimal avg) NumbersMethodArray(int[] arrays)
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