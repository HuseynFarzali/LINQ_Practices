using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practices
{
    public static class CharExtensions
    {
        public static int GetAlphabeticCode(this char c)
        {
            if (c >= 'a' && c <= 'z') return -1;
            else if (c >= 'A' && c <= 'Z') return 1;
            else return 0;
        }

        public static char ReturnUpper(this char c)
        {
            if (c.GetAlphabeticCode() >= 0)
                throw new ArgumentException("Cannot return the uppercase version of a non-alphabetic or a uppercase letter");

            return (char)((int)c + (int)('A' - 'a'));
        }

        public static char ReturnLower(this char c)
        {
            if (c.GetAlphabeticCode() <= 0)
                throw new ArgumentException("Cannot return the lowercase version of a non-alphabetic or a lowercase letter");

            return (char)((int)c - (int)('A' - 'a'));
        }
    }
}
