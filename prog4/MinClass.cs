using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace prog4
{


    internal class MinClass<T> where T : IComparable<T>
    {
        /*
        public Boolean CompareStr(string name1,string name2) {
            int count_str1 = 0;
            int count_str2 = 0;


            return true;*/
        

        public int Minnum(int[] arr)
        {
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public double MinDoub(Double[] arr)
        {
            Double min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public string MinStr(String[] arr)
        {
            String min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(min)>0)
                {
                    min = arr[i];
                }
            }
            return min;
        }

    }
}
