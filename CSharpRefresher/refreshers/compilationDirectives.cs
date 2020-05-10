using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefresher.refreshers
{
    class compilationDirectives
    {
        public void testCompilationDirective(string[] args)
        {
        #if DEBUG
            Console.WriteLine("Starting Work in Debug Mode");
        #endif

            Console.WriteLine("Testing out compilation directives and symbols");
        }

        [System.Diagnostics.Conditional("DEBUG")]
        public void compilerDirectiveAnnotation()
        {
            Console.WriteLine("I will be printed only in Debug Mode");
        }
    }
}
