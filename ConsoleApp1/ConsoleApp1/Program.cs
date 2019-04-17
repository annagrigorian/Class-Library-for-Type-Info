using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeInfo t = new TypeInfo(typeof(int));

            t.GetMethods();

            t.GetInterfaces();

            t.GetCustomAttributes();
        }
    }
}
