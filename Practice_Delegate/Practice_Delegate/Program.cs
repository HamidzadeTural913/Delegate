using System;

namespace Practice_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //Console.WriteLine(Sum(arr,IsDividedBy2));
            Action<double,double >  action = ProductNum;
            action(1, 1);



        }

       
        public static void ProductNum(double one ,double two )
        {
            double count = 0;
            double total = 0;
            double[] arr = { 1, 2, 3, 6, 8, 9, 10, 12, 24, 67, 87, 90, 88, 34 };
            foreach (double num in arr)
            {
                total += num;
                count++;
            }
            Console.WriteLine("Arrayin cemi:");
            Console.WriteLine(total);
            Console.WriteLine("Say:");
            Console.WriteLine(count);
        }


        #region Anonym
        //public static int SumEven(int[] arr, callback)
        //{
        //    int total = default(int);
        //    foreach (int num in arr)
        //    {
        //        if (num % 2 == 0)
        //        {
        //            total += num;
        //        }

        //    }
        //    return total;
        //}
        #endregion

        #region Practice
        //public delegate bool MyDel(int number);

        //public static int Sum(int[] arr,MyDel method)
        //{
        //    int total=default(int);
        //    foreach (int num in arr)
        //    {
        //        if (method(num))
        //        {
        //            total += num;
        //        }
        //    }
        //    return total;
        //}





        //public static bool IsDividedBy2(int number)
        //{
        //    return number % 2 == 0;
        //}

        //public static bool IsNotDividedBy2(int number)
        //{
        //    return number % 2 != 0;
        //}

        //public static bool IsDividedBy3(int number)
        //{
        //    return number % 3 == 0;
        //}
        #endregion


    }
}
