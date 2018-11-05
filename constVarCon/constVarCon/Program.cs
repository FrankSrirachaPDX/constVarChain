using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constVarCon
{
    class Program
    {
        static void Main(string[] args)
        {
            const string variable = "Constant";
            string variable1 = Console.ReadLine();
            var myVar = new Method1(variable, variable1);



            Console.ReadLine();
        }
    }
    class Method1
    {
        public Method1(string a, string b) : this(a, b, "", "")
        {
            Console.WriteLine(a + b);
        }

        public static Method1 CreateMethodWithEndParams(string c, string d)
        {
            Method1 method = new Method1("", "", c, d);

            return method;
        }

        public Method1(string a, string b, string c, string d)
        {
            Console.WriteLine(a + b + c + d);
        }
    }
}
