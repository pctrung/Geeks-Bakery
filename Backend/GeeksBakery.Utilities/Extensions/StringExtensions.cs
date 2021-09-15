using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksBakery.Utilities.Extensions
{
    public static class StringExtensions
    {
        public static string ToVND(this decimal number)
        {
            var culture = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            return String.Format(culture, "{0:N0}", number) + " đ";
        }
    }
}