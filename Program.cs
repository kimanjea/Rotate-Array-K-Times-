using System;

using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Hello World!");

        var array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;
        
        int [] result = RotateArray(array, k);
    }

    public static int [] RotateArray(int [] array , int k) {

        if (array == null || array.Length == 0 || k < 0) {
            throw new ArgumentException("Invalid argument");
        }

        if(array.Distinct().Count() == 1) {
            return array;
        }

        k = k % array.Length;

        return array.Skip(array.Length - k).Concat(array.Take(array.Length - k)).ToArray();
    }
}