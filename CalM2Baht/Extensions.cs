using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalM2Baht
{
    public static class Extensions
    {
        public static bool IsNullableType(Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
        }
        public static bool IsNullOrEmpty(this object data)
        {
            return string.IsNullOrEmpty(Convert.ToString(data));
        }
        public static decimal AsDecimal(this object data, decimal? defaultValue = null)
        {
            if (IsNullOrEmpty(data))
                return defaultValue != null ? Convert.ToDecimal(defaultValue) : 0;

            return Convert.ToDecimal(data);
        }
    }
}
