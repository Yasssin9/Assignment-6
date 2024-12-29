namespace Assignment_6
{
    internal class Program
    {
        #region Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
        //when u pass ref type by value ,ref pass as copy but when pass ref type as ref ,ref pass inside the function and print actual number(number u write it in call) as reference

        //static void swap(int? x, int? y)
        //{
        //    int? temp;
        //    temp = x;
        //    x =  y;
        //    y = temp;
        //}
        //static void swap2(ref int? x, ref int? y)
        //{
        //    int? temp;
        //    temp = x;
        //    x =  y;
        //    y = temp;
        //}
        #endregion
        #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers


        //static void SumMul(int x, int y,out int sum,out int mul)
        //{
        //    sum = x+y;
        //    mul = x*y;
        //}

        //static void Main(string[] args)
        //{
        //    int a = 5, b = 3, Sum_Result, Mul_Result;
        //    SumMul(a, b, out Sum_Result, out Mul_Result);
        //    Console.WriteLine($"Sum is {Sum_Result} and Mul is {Mul_Result}");
        //}
        #endregion
        #region Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

        //static void MinMaxArray(int[] array, ref int min, ref int max)
        //{
        //    if (array == null) { 
        //    Console.WriteLine("sry array is null i can't get max and min values in array");
        //    }
        //    else
        //    {
        //        min = array[0];
        //        max = array[0];
        //        foreach (var item in array)
        //        {
        //            if (item < min)
        //                min = item;

        //            if (item > max)
        //                max = item;
        //        }

        //    }
        //}

        //static void Main(string[] args)
        //{
        //    int[] arr = { 1, 2, 3, 4, 5 }; // sugar syntax
        //    int a = 0, b = 0;
        //    MinMaxArray(arr, ref a, ref b);
        //    Console.WriteLine(a, b);

        //}
        #endregion



    }
}
