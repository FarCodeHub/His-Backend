using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.His.Extensions
{
   public static class PersianDataTimeExtention
    {

        public static string PersianDateFormat(this DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            StringBuilder sb = new StringBuilder();
            sb.Append(pc.GetYear(date).ToString("0000"));
            sb.Append("/");
            sb.Append(pc.GetMonth(date).ToString("00"));
            sb.Append("/");
            sb.Append(pc.GetDayOfMonth(date).ToString("00"));
            return sb.ToString();
        }

    }
}
