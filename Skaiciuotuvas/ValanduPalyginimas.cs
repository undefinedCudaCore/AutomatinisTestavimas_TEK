using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skaiciuotuvas
{
    public class ValanduPalyginimas
    {
        public static string Valanda()
        {
            DateTime dt = DateTime.Now;
            string hour = dt.Hour.ToString() + "h";
            return hour;
        }
    }
}
