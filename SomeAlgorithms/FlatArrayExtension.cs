using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SomeAlgorithms
{
    /// <summary>
    /// extension for array that allows flatten an array
    /// </summary>
    public static class FlatArrayExtensionRecursive 
    {
        private static T[] Concat<T>(this T[] a, T[] b)
        {
            T[] result = new T[a.Length + b.Length];
            Array.Copy(a, result, a.Length);
            Array.Copy(b, 0, result, a.Length, b.Length);
            return result;
        }

        /// <summary>
        /// recursive method that ask about if the next element is a value or array
        /// object param allow this overhead
        /// </summary>
        /// <param name="array"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        static private object[] GetFlatArrayRecursive(object array, int i)
        {
            if (((object[])array).Length == i)
            {
                return new object[] { };
            }
            else
            {
                Type array_i_type = (((object[])array)[i]).GetType();
                if (array_i_type == typeof(object[]))
                {
                    return GetFlatArrayRecursive((((object[])array)[i]), 0).
                            Concat(GetFlatArrayRecursive(array, i + 1)).
                                                     ToArray();

                }
                else
                {
                    return (new[] { (((object[])array)[i]) }).
                        Concat(GetFlatArrayRecursive(array, i + 1)).
                        ToArray();
                }
             }
        }

        static public object[] GetFlatArray(this object array)
        {
            return GetFlatArrayRecursive(array, 0);
        }      
    }
}
