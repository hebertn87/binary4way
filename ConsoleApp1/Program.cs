using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft;
using System.Data.OleDb;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {   
        //Recursive Approach
        public static int ChopRecursive(int key, int[] array, int bottom, int top)
        {
                  
            
            if (bottom > top)
            {
                return -1;
            }
            else
            {
                var middle = (top + bottom) / 2;

                if (array[middle] == key)
                {
                    return middle;
                }
                else if (array[middle] > key)
                {
                    return ChopRecursive(key, array, bottom, middle - 1);
                }
                else
                {
                    return ChopRecursive(key, array, middle + 1, top);
                }
            }
        }
  

        //Iterative Approach
        public static int ChopIterate(int key, int[] array)
        {
            int top = array.Length - 1;
            int bottom = 0;

            while (bottom <= top)
            {
                int middle = (top + bottom) / 2;

                if(key == array[middle])
                {
                    return middle;
                }
                else if (key < array[middle])
                {
                    top = middle - 1;
                }
                else
                {
                    bottom = middle + 1;
                }
            }
            return -1;
        }

        //Binary Search Library
        public static int ChopSearch(int key, int[] array)
        {
            int middle = Array.BinarySearch(array, key);
            return middle;    
        }

        //I need a middleman that takes the asserts and passes top and bottom to chop
        public static String ChopTest(int key, int[] array)
        {
            int bottom = 0;
            int top = array.Length -1;

            ChopRecursive(key, array, bottom, top);
            ChopIterate(key, array);
            ChopSearch(key, array);

            return "true";
        }

        static void Main(string[] args)
        {
            Debug.Assert(true, ChopTest(3, new int[] { }));
            Debug.Assert(true, ChopTest(3, new int[] { 1 }));
            Debug.Assert(true, ChopTest(1, new int[] { 1 }));

            Debug.Assert(true, ChopTest(1, new int[] { 1, 3, 5 }));
            Debug.Assert(true, ChopTest(3, new int[] { 1, 3, 5 }));
            Debug.Assert(true, ChopTest(5, new int[] { 1, 3, 5 }));
            Debug.Assert(true, ChopTest(0, new int[] { 1, 3, 5 }));
            Debug.Assert(true, ChopTest(2, new int[] { 1, 3, 5 }));
            Debug.Assert(true, ChopTest(4, new int[] { 1, 3, 5 }));
            Debug.Assert(true, ChopTest(6, new int[] { 1, 3, 5 }));

            Debug.Assert(true, ChopTest(1, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(true, ChopTest(3, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(true, ChopTest(5, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(true, ChopTest(7, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(true, ChopTest(0, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(true, ChopTest(2, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(true, ChopTest(4, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(true, ChopTest(6, new int[] { 1, 3, 5, 7 }));
            Debug.Assert(true, ChopTest(8, new int[] { 1, 3, 5, 7 }));
        }
        
    }
}
