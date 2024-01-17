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

        if (array == null || array.Length == 0 || k < 0) { // we check the edge cases of the array for when it is null or length is 0
            throw new ArgumentException("Invalid argument"); // we throw a custom exception
        }

        if(array.Distinct().Count() == 1) { // Distinct returns a new collection with no duplicates, if the count is 1 then all the elements are the same
            return array;
        }

        k = k % array.Length; // we get the remainder of the array length and k, this is to avoid unnecessary rotations

        return array.Skip(array.Length - k).Concat(array.Take(array.Length - k)).ToArray(); // we skip the first n elements and concat both skips and take
    }
}