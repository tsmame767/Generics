using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3
{
    public class DeleteArray<T> where T : IComparable<T>
    {
        public void DeleteMethod(T[] arr, T element)
        {
            var newarr = Array.Empty<T>();



            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i].CompareTo(element) == 0)
                    {
                        continue;
                    }
                   
                

                else if (arr[i].CompareTo(element) == 0)
                    {
                        continue;
                    }
                    
                else if (arr[i].CompareTo(element) == 0)
                {
                    continue;
                }
                else
                {
                    newarr = newarr.Append(arr[i]).ToArray();
                    Console.Write(arr[i] + ", ");
                }
            }

            Console.WriteLine("");
            for (int i = 0; i < newarr.Length; i++)
            {
                Console.Write(newarr[i] + ", ");
            }
            Console.WriteLine(element.GetType().Name);
        }


    }
}
