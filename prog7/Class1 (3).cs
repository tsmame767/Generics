using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics4
{
    public class Minnum <T> where T : IComparable<T>
    {
        public void min(T[] arr)
        {
            T min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(min) < 0)
                {
                    min = arr[i];
                }

               
            

           
               

               


            }

            Console.WriteLine(min);


        }


    }
}
