using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practices
{
    public static class RandomOps
    {
        public static int[] GetRandomArray(int lowerLimit = 0, int UpperLimit = int.MaxValue,
            int size = 8)
        {
            int[] resultArray = new int[size];
            int interval = UpperLimit - lowerLimit;

            Random randomInstance = new Random();
            for (int i = 0; i < size; i++)
            {
                resultArray[i] = lowerLimit + randomInstance.Next() % (interval + 1);
            }

            return resultArray;
        }
    }
}
