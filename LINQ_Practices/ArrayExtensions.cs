using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practices
{
    public static class ArrayExtensions
    {
        public static void WriteInside<Any>(this Any[] array) where Any : IParsable<Any>
        {
            string? userinput; Any element;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Element {i}: ");
                userinput = Console.ReadLine();

                if (userinput != null)
                {
                    element = userinput.ChangeType<Any>();
                }
                else
                {
                    throw new ArgumentException("Parameter that is null is not accepted as an input.");
                }

                array[i] = element;
            }
        }
    }
}
