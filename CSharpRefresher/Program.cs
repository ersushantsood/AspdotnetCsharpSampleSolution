using CSharpRefresher.refreshers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRefresher
{
    class Program
    {
       static void Main(string[] args)
       {
            
           Console.WriteLine("Refresh C# in Style");
            compilationDirectives directives = new compilationDirectives();
            directives.testCompilationDirective(null);
            directives.compilerDirectiveAnnotation();
        }
    }
}
