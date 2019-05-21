using System;
using System.Threading;

namespace Session
{
    public class test
    {
        public static void Main(String[] args)
        {


            SNT snt = new SNT();
            Console.WriteLine("Please enter your number: ");
            snt.TimSoNguyenTo(Convert.ToInt32(Console.ReadLine()));
            

        }
    }


    public class SNT
    {
        public bool soNguyenTo(int n)
        {
            bool e = true;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    e = false;
                return e;
            }

            return false;
        }

        public void TimSoNguyenTo(int n )
        {
            for (int i = 2; i < n; i++)
            {
                if (soNguyenTo(i))
                    Console.WriteLine("show" + i);
            }

            for (int i = 2; i < n; i++)
            {
                if (fibonanci(i))
                    Console.WriteLine("Fibonanci");
            }
        }

        public bool fibonanci(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("Invalid input!");

            }
            else if (n == 1)
            {
                Console.WriteLine(0);

            }

            int x1 = 0;
            int x2 = 1;
            Console.Write("{0} {1} ", x1, x2);

            for (int i = 2; i < n; i++)
            {
                int x3 = x1 + x2;
                Console.Write("{0} ", x3);
                x1 = x2;
                x2 = x3;
            }
            
            return true;

        }

    }
}

