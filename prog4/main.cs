using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog4
{
    internal class main
    {

        static void Main()
        {

            int[] arr1 = { 1,6, 2, 3, 4, 5 };
            double[] arr2 = { 11.2, 6.77, 22.3, 33.4, 44.5, 55.6 };
            string[] arr3 = { "Tushar", "Hemant", "Vikas" };

            MinClass<int> obj = new MinClass<int>();
            MinClass<double> obj2 = new MinClass<double>();
            MinClass<string> obj3 = new MinClass<string>();

            Console.WriteLine(obj.Minnum(arr1));
            Console.WriteLine(obj.MinDoub(arr2));
            Console.WriteLine(obj.MinStr(arr3));
        }
    }
}
