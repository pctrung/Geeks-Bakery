using System.Collections.Generic;
using System.Linq;

namespace GeeksBakery.Utilities.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> Paged<T>(this IQueryable<T> source, int page, int pageSize)
        {
            return source.Skip((page - 1) * pageSize).Take(pageSize);
        }
    }
    public static class IEnumerableExtension
    {
        public static bool IsSafe<T>(this IEnumerable<T> source)
        {
            return source?.Any() == true;
        }
    }
}