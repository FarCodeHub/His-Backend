using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.SMSManagment.Extensions
{
    public static class ListExtension
    {
        public static bool TryAny<T>(this List<T> value) => value?.Count > 0;
        public static bool TryAny<T>(this ICollection<T> value) => value?.Count > 0;
        public static string StringJoin<T>(this IList<T> value) => string.Join(",", value);
    }
}
