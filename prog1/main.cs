using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog1 {
    
    class DeleteArray
    {

        
        public int[] DeleteMethod(int[] arr)
        {
            
            Console.WriteLine("Enter Element to Remove :");
            int element = Convert.ToInt32(Console.ReadLine());
            var newarr = Array.Empty<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    continue;
                }
                else
                {
                    
                    newarr = newarr.Append(arr[i]).ToArray();
                    

                }
                
            }
            /*
            foreach(int i in newarr)
            {
                Console.Write(i + ", ");
            }
            
            //Console.Write(newarr + ", ");
            */
            return newarr;
        }

        public double[] DeleteMethod(double[] arr)
        {
            Console.WriteLine("\nEnter Element to Remove :");
            double element = Convert.ToDouble(Console.ReadLine());
            //double[] newarr = { };
            var newarr = Array.Empty<double>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    continue;
                }
                else
                {

                    newarr = newarr.Append(arr[i]).ToArray();
                    //newarr.Append(arr[i]);
                    //Console.Write(arr[i] + ", ");

                }
            }
            /*
            foreach (double i in newarr)
            {
                Console.Write(i + ", ");
            }

            //Console.Write(newarr + ", ");
            */
            return newarr.ToArray();
        }

        public string[] DeleteMethod(string[] arr)
        {
            Console.WriteLine("\nEnter Element to Remove :");
            string element = Console.ReadLine();
            //string[] newarr = new string[arr.Length];
            var newarr = Array.Empty<string>();
            

            for (int i = 0; i < arr.Length; i++)
            {
                
                if (arr[i] == element)
                {
                    continue;
                }
                else
                {
                    newarr = newarr.Append(arr[i]).ToArray();


                }

                

            }/*
            foreach (string i in newarr)
            {
                Console.Write(i + ", ");
            }
            */
            //Console.Write(newarr + ", ");




            return newarr.ToArray();

        }

        public void PrintArr<T>(T[] arr)
        {
            for (int i=0;i<arr.Length; i++)
            {
                Console.Write(arr[i]+", "); 
            }
            Console.Write("\n");
        }
    }

    

    internal class main1
    {

        

        static void Main()
        {

            int[] arr1 = { 1, 2, 3, 4, 5 };
            string[] arr2 = { "a", "e", "i", "o", "u" };
            double[] arr3 = { 11.2,22.3,33.4,44.5,55.6};

            DeleteArray obj = new DeleteArray();

           
            
            arr1=obj.DeleteMethod(arr1);
            arr2=obj.DeleteMethod(arr2);
            arr3=obj.DeleteMethod(arr3);

            /*
            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr2[0]);
            Console.WriteLine(arr3[0]);*/
            obj.PrintArr(arr1);
            obj.PrintArr(arr2);
            obj.PrintArr(arr3);





        }


    }
}
