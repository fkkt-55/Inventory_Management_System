using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_For_Windows.Utilities
{
    public class Utility
    {
        public static string EnsureStringIsNotNull(string value)
        {
            if (value == null || value.Length == 0)
            {
                return "默认";
            }
            return value;
        }

        public static float StringToFloat(string str)
        {
            if (float.TryParse(str, out float result))
            {
                return result;
            }
            return 0.0f;
        }

        public static decimal StringToDecimal(string str)
        {
            if (decimal.TryParse(str, out decimal result))
            {
                return result;
            }
            return 0.0m;
        }

        public static long DateTimeToTimeStamp(DateTime dt)
        {
            return (long)(dt - new DateTime(1970, 1, 1)).TotalSeconds;
        }

        public static DateTime TimestampToDateTime(long timestamp)
        {
            return new DateTime(1970, 1, 1).AddSeconds(timestamp);
        }
    }
}
