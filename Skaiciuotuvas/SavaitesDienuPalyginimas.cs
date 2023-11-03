using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skaiciuotuvas
{
    public class SavaitesDienuPalyginimas
    {
        public static string DienuPalyginimas()
        {
            DateTime dt = DateTime.Now;
            string dayOfWeek = dt.DayOfWeek.ToString();

            return dayOfWeek;
        }
    }
}
