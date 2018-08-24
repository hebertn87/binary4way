using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public int Chop(int key, List<int> array, int top, int bottom)
        {
            var middle = array.Count / 2;
            if (array[middle] == key)
               return middle;
            if (top >= bottom)
            {
                return -1;
            }
            else
            {
                if(array[middle] > key)
                {
                    return Chop(key, array, middle-1, bottom);
                        
                }
                else
                {
                    return Chop(key, array, top, middle+1);
                }
            }
        }

        static void Main(string[] args)
        {
            assert_equal(-1, chop(3, []));
            assert_equal(-1, chop(3, [1]));
            assert_equal(0, chop(1, [1]));

            assert_equal(0, chop(1, [1, 3, 5]));
            assert_equal(1, chop(3, [1, 3, 5]));
            assert_equal(2, chop(5, [1, 3, 5]));
            assert_equal(-1, chop(0, [1, 3, 5]));
            assert_equal(-1, chop(2, [1, 3, 5]));
            assert_equal(-1, chop(4, [1, 3, 5]));
            assert_equal(-1, chop(6, [1, 3, 5]));

            assert_equal(0, chop(1, [1, 3, 5, 7]));
            assert_equal(1, chop(3, [1, 3, 5, 7]));
            assert_equal(2, chop(5, [1, 3, 5, 7]));
            assert_equal(3, chop(7, [1, 3, 5, 7]));
            assert_equal(-1, chop(0, [1, 3, 5, 7]));
            assert_equal(-1, chop(2, [1, 3, 5, 7]));
            assert_equal(-1, chop(4, [1, 3, 5, 7]));
            assert_equal(-1, chop(6, [1, 3, 5, 7]));
            assert_equal(-1, chop(8, [1, 3, 5, 7]));
        }
        
    }
}
