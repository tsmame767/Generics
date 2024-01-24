using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2
{
    public class DeleteArray<T> where T : IComparable<T>
    {
        public void DeleteMethod(T[] arr, T element)
        {
            var newarr = Array.Empty<T>();



            for (int i = 0; i < arr.Length; i++)
            {
                
                if (arr[i].GetType().Name == "Int32")
                    
                {
                    if (Convert.ToInt32(arr[i]) == Convert.ToInt32(element))
                    //if (arr[i].CompareTo(element) == 0)
                    {
                        continue;
                    }
                    else
                    {
                        newarr=newarr.Append(arr[i]).ToArray();
                        Console.Write(arr[i] + ", ");
                    }
                }

                else if (arr[i].GetType().Name == "Double")

                {
                    if (Convert.ToDouble (arr[i]) == Convert.ToDouble(element))
                    //if (arr[i].CompareTo(element) == 0)
                    {
                        continue;
                    }
                    else
                    {
                        newarr = newarr.Append(arr[i]).ToArray();
                        Console.Write(arr[i] + ", ");
                    }
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
