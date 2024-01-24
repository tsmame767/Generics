using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3
{
    internal class main
    {

        static void Main()
        {

            int[] arr = { 1, 2, 3, 4, 5 };
            double[] arr2 = { 2.6543, 4.7654, 6.876543, 4.98, 34.876 };
            string[] arr3 = { "Tushar", "Hemant", "Vikas" };
            DeleteArray<int> obj = new DeleteArray<int>();
            DeleteArray<double> obj1 = new DeleteArray<double>();
            DeleteArray<string> obj2 = new DeleteArray<string>();

            obj1.DeleteMethod(arr2, 2.6543);
            obj2.DeleteMethod(arr3, "Tushar");
            obj.DeleteMethod(arr, 5);
        }
    }
}
