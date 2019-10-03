using System;
using System.Collections.Generic;

namespace patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //computeseries(int.Parse(Console.ReadLine()));
            //patternRightPyramid(int.Parse(Console.ReadLine()));
            //int n=int.Parse(Console.ReadLine());
            //properpyramid(int.Parse(Console.ReadLine()));
            //getmean(n);
            //elementfrequency();
            mergearrays();
        }
        public static void getmean(int n)
        {
            string forlength = n.ToString();
            int length = forlength.Length;


            int divider = 0;
            int count = 0;
            for (int i = n; i > 0; i /= 10)
            {
                divider = divider + i % 10;

            }
            int mean = divider / length;
            Console.WriteLine(mean);


        }
        public static void reversepyramid(int n)
        {
            int start = 0;
            for (int i = 1; i < n; i++)
            {
                start = start + i;
                Console.Write("{0},", start);
            }
        }
        public static void computeseries(int n)
        {
            //var result = new List<int>();
            int count = 0;

            for (int i = 1; i <= n; i++)
            {


                for (int j = 1; j <= i; j++)
                {

                    Console.Write(i);
                    count++;


                    //result.Add(i);
                }




            }


            Console.WriteLine();
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(result[i]);
            //}
        }

        public static void properpyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= n - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
        }

        public static void elementfrequency()
        {
            int[] a = { 2000,4, 4, 1, 3, 3, -1, 2,2000, 1,9,2000,100,-1 };


            //int[] a = new int[10];
            //foreach (var i in a)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //}

            int gratest = a[0];
            int lowest = a[0];
            for (int i=1;i<a.Length;i++)
            {
                if(gratest<a[i])
                {
                    gratest = a[i];
                }
                if(lowest>a[i])
                {
                    lowest = a[i];
                }

            }
            int maxF = 0;
            int minF = 0;
            for(int i=0;i<a.Length;i++) 
            {
                if(a[i]==gratest)
                {
                    maxF++;
                }
                if(a[i]==lowest)
                {
                    minF++;
                }
            }
                
            Console.WriteLine("The lowest integer in the series is {0} with frequency {1}", lowest, maxF);
            Console.WriteLine("The gratest integer in the series is {0}with frequency {1}", gratest, minF);

        }

        public static void mergearrays()
        {
            int[] a = { 3,5,7,9};
            int[] b = { 2,4,6,8};
            int[] c = new int[8];
            int j = 0;
            int k = 0;
            int i = 0;

                while (j < 4 && k < 4)
                {
                    if ((a[j] > b[k]))
                    {
                        c[i] = b[k];
                        //Console.WriteLine("The {0} element is {1}", i, c[i]);
                        //Console.WriteLine("inside");
                        k++;
                    }
                    else if ((a[j] < b[k]))
                    {
                        c[i] = a[j];
                        //Console.WriteLine("The {0} element is {1}", i, c[i]);
                        //Console.WriteLine("inside");

                        j++;
                    }
                i++;
                }

            while (j<4)
            {
                c[i] = a[j];
                j++;
            }
            while(k<4)
            {
                c[i] = b[k];
                k++;
            }

         for(int y=0;y<c.Length;y++)
        {
          Console.Write("{0},", c[y]);
        }
           

        }

        public static void meergearrays()
        {
            int[] a = { 3, 5, 7, 9 };
            int[] b = { 8,6,4,2 };
            int[] c = new int[8];
            int j = 0;
            int k = 3;
            int i = 0;

            while (j < 4 && k < 4)
            {
                if ((a[j] > b[k]))
                {
                    c[i] = b[k];
                    //Console.WriteLine("The {0} element is {1}", i, c[i]);
                    //Console.WriteLine("inside");
                    k--;
                }
                else if ((a[j] < b[k]))
                {
                    c[i] = a[j];
                    //Console.WriteLine("The {0} element is {1}", i, c[i]);
                    //Console.WriteLine("inside");

                    j++;
                }
                i++;
            }

            while (j < 4)
            {
                c[i] = a[j];
                j++;
            }
            while (k>=0)
            {
                c[i] = b[k];
                k--;
            }

            for (int y = 0; y < c.Length; y++)
            {
                Console.Write("{0},", c[y]);
            }


        }
    }

}
