using System.Collections.Generic;
using System.Linq;

namespace LibElite.Helper
{
    public static class LINQExtensions
    {
        public static IEnumerable<IEnumerable<T>> Split<T>(this IEnumerable<T> list, int parts)
        {
            int i = 0;
            IEnumerable<IEnumerable<T>> splits = from item in list
                                                 group item by i++ % parts into part
                                                 select part.AsEnumerable();
            return splits;
        }
    }
}