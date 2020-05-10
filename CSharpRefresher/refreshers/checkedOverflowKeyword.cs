using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpRefresher.refreshers
{
    class checkedOverflowKeyword
    {
        public void checkedKeyword(int overflownuma, int overflownumb)
        {
            int c = 1000000;
            checked
            {
                int result = checked(overflownuma + overflownumb) + c;
            }

        }
    }
}
