using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHelpers
{
    public static class StringHelper
    {
        public static string GetAnonymousString()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
