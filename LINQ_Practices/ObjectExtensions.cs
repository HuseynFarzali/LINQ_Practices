using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practices
{
    public static class ObjectExtensions
    {
        public static Any ChangeType<Any>(this object obj)
        {
            return (Any)Convert.ChangeType(obj, typeof(Any));
        }
    }
}
