using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelpers
{
    public static class ValueHelper
    {
        public static string GetAnonymousString()
        {
            return Guid.NewGuid().ToString();
        }


        public static int GetAnonymousInt()
        {
            var rand = new Random();
            return rand.Next();
        }

        public static DateTime GetAnonymousDate()
        {
            return DateTime.Now;
        }
    }
}
