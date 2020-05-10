using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefresher.refreshers
{
    class testDynamic
    {
        public void testDynamicType()
        {
            //compiler present dynamic variable as object to runtime.
            //Compiler does not attempt to understand the type of the object at compile type
            dynamic x = 22;
        }
    }
}
