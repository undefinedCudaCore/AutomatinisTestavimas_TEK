using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skaiciuotuvas
{
    public class LyginiaiSkaiciai
    {
        public static int Skaicius()
        {
            int count = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
