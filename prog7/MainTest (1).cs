using Generics4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MainTest
    {
        static void Main()
        {

            int[] integer = { 1, 2, 3, 4, 5, 6 };
            float[] float1 = { 12.8f, 34.5f, 65.7f, 2.76f, 54.9f, 12.2f};
            string[] string1 = { "rahul", "rohan", "Amey", "Hemant" };
            char[] character = { 'a', 'r', 'o', 'm', 'h' , 'z' };

            Minnum<int> maxNum = new Minnum<int>();
            maxNum.min(integer);


             Minnum<float> maxNum1 = new Minnum<float>();
             maxNum1.min(float1);


            Minnum<string> maxStr = new Minnum<string>();
            maxStr.min(string1);


           Minnum<char> char1 = new Minnum<char>();
            char1.min(character);






        }
    }
}