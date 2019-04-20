using System;
using System.Collections.Generic;
using System.Linq;

namespace SomeAlgorithms
{
    class Program
    {
        static public void WriteArray(object[] array, string name)
        {

            Console.Write(name + " array: [ ");
            for (int i = 0; i < array.Length; i++)
            {
                if (i != 0) { Console.Write(","); }
                Console.Write(" " + array[i].ToString() + " ");
            }
            Console.Write(" ]");
        }


        static void Main(string[] args)
        {
            /*Write some code, that will flatten an array
             * of arbitrarily nested arrays of integers into 
             * a flat array of integers.
             * e.g. [[1,2,[3]],4] -> [1,2,3,4]. *
            */

            Console.WriteLine("Input 1: [[1,2,[3]],4]");         
            object[] array1 = new object[] { new object[] { 1, 2, new object[] { 3 } }, new object[] { 4 } };
            var flatArray1 = array1.GetFlatArray();
            WriteArray(flatArray1, "Flat 1");

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Input 2: [[1,2,[3]],4, [hi,bye,[5]] ]");
            object[] array2 = new object[] { new object[] { 1, 2, new object[] { 3 } }, new object[] { 4 },
                              new object[] {"hi","bye",new object[] { 5 } } };
            var flatArray2 = array2.GetFlatArray();
            WriteArray(flatArray2, "Flat 2");


            Console.ReadLine();
        }
    }
}
